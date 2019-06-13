using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bookids
{
    public partial class FormGestãoEventos : Form
    {
        ModelContainer modelContainer;
        bool isEditing = false;

        public FormGestãoEventos()
        {
            InitializeComponent();

            modelContainer = new ModelContainer();

            carregarEventos();
            clearTextBoxes();
        }

        private void FormGestãoEventos_Load(object sender, EventArgs e)
        {
            
        }

        private void UpdateCombos()
        {
            cbColaborações.SelectedIndex = -1;
            cbParticipações.SelectedIndex = -1;
            cbInscrições.SelectedIndex = -1;

            int idEvento = ((Evento)dataGridView1.SelectedRows[0].DataBoundItem).NrEvento;

            var animadoresColaborando = from animador in modelContainer.Animadores
                             join colab in modelContainer.Colaboração
                             on animador.IdPessoa equals colab.AnimadorIdPessoa
                             where colab.EventoNrEvento == idEvento
                             select animador;

            var animadores = from animador in modelContainer.Animadores
                             orderby animador.Nome
                             select animador;

            cbColaborações.DataSource = animadores.Except(animadoresColaborando).ToList();
            cbColaborações.DisplayMember = "Especialidade";
            cbColaborações.ValueMember = "IdPessoa";

            var escolasParticipando = from escola in modelContainer.Escolas
                                        join part in modelContainer.Participação
                                        on escola.IdEscola equals part.EscolaIdEscola
                                        where part.EventoNrEvento == idEvento
                                        select escola;

            var escolas = from escola in modelContainer.Escolas
                          orderby escola.Nome
                          select escola;

            cbParticipações.DataSource = escolas.Except(escolasParticipando).ToList();
            cbParticipações.DisplayMember = "Nome";
            cbParticipações.ValueMember = "IdEscola";

            var filhosInscritos = from filho in modelContainer.Filhos
                                      join insc in modelContainer.Inscrição
                                      on filho.IdPessoa equals insc.FilhoIdPessoa
                                      where insc.EventoNrEvento == idEvento
                                      select filho;

            var filhos = from filho in modelContainer.Filhos
                         join escola in escolasParticipando
                         on filho.EscolaIdEscola equals escola.IdEscola
                         orderby filho.Nome
                         select filho;

            cbInscrições.DataSource = filhos.Except(filhosInscritos).ToList();
            cbInscrições.DisplayMember = "Nome";
            cbInscrições.ValueMember = "IdPessoa";
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.CurrentRow.Selected = true;

                Evento evento = (Evento)dataGridView1.SelectedRows[0].DataBoundItem;

                tbDescrição.Text = evento.Descrição;
                tbLocal.Text = evento.Local;
                tbHora.Text = evento.DataHora.ToShortTimeString();
                dateTimePicker1.Value = evento.DataHora;
                nmLimite.Value = evento.LimiteParticipações;
                nmInferior.Value = evento.IdadeInferior;
                nmSuperior.Value = evento.IdadeSuperior;
                tbTipoEvento.Text = evento.TipoEvento;

                var listaColaborações = from colaboracao in modelContainer.Colaboração
                                        join animador in modelContainer.Animadores
                                        on colaboracao.AnimadorIdPessoa equals animador.IdPessoa
                                        where colaboracao.EventoNrEvento == evento.NrEvento
                                        select new { Nome = animador.Nome, Especialidade = animador.Especialidade, IdPessoa = colaboracao.AnimadorIdPessoa, IdEvento = colaboracao.EventoNrEvento };

                dataGridView2.DataSource = listaColaborações.ToList();


                var listaParticipações = from escola in modelContainer.Escolas
                                        join participacao in modelContainer.Participação
                                        on escola.IdEscola equals participacao.EscolaIdEscola
                                        where participacao.EventoNrEvento == evento.NrEvento
                                        select new { Nome = escola.Nome, IdEscola = escola.IdEscola, IdEvento = participacao.EventoNrEvento };

                dataGridView3.DataSource = listaParticipações.ToList();


                var listaInscrições = from filho in modelContainer.Filhos
                                         join inscrição in modelContainer.Inscrição
                                         on filho.IdPessoa equals inscrição.FilhoIdPessoa
                                      where inscrição.EventoNrEvento == evento.NrEvento
                                         select new { Nome = filho.Nome, IdPessoa = filho.IdPessoa, IdEvento = inscrição.EventoNrEvento };

                dataGridView4.DataSource = listaInscrições.ToList();

                UpdateCombos();

                isEditing = true;
                updateLayout();
            }
        }
        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dataGridView2.CurrentRow.Selected = true;
        }

        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dataGridView3.CurrentRow.Selected = true;
        }

        private void DataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dataGridView4.CurrentRow.Selected = true;
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (!InputValid())
                return;

            Evento evento = new Evento
            {
                Descrição = tbDescrição.Text,
                Local = tbLocal.Text,
                LimiteParticipações = (int)nmLimite.Value,
                DataHora = getDataHora(dateTimePicker1.Value, tbHora.Text),
                IdadeSuperior = (int)nmSuperior.Value,
                IdadeInferior = (int)nmInferior.Value,
                TipoEvento = tbTipoEvento.Text
            };

            modelContainer.Eventoes.Add(evento);
            modelContainer.SaveChanges();
            carregarEventos();

            clearTextBoxes();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!InputValid())
                    return;

                Evento ev = (Evento)dataGridView1.SelectedRows[0].DataBoundItem;


                var evento = (from eventos in modelContainer.Eventoes
                              where eventos.NrEvento == ev.NrEvento
                              select eventos).FirstOrDefault();

                evento.Descrição = tbDescrição.Text;
                evento.Local = tbLocal.Text;
                evento.LimiteParticipações = (int)nmLimite.Value;
                evento.DataHora = getDataHora(dateTimePicker1.Value, tbHora.Text);
                evento.IdadeSuperior = (int)nmSuperior.Value;
                evento.IdadeInferior = (int)nmInferior.Value;
                evento.TipoEvento = tbTipoEvento.Text;

                modelContainer.SaveChanges();
                carregarEventos();

                clearTextBoxes();
            }
            catch (Exception)
            {

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Evento evento = (Evento)dataGridView1.SelectedRows[0].DataBoundItem;

                modelContainer.Eventoes.Remove(evento);
                modelContainer.SaveChanges();
                carregarEventos();

                clearTextBoxes();
            }
            catch (Exception)
            {

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }

        private void carregarEventos()
        {
            var listaEventos = from evento in modelContainer.Eventoes
                               orderby evento.NrEvento descending
                               select evento;
            eventosBindingSource.DataSource = listaEventos.ToList();

            updateLayout();
        }

        private void updateLayout()
        {
            btnAdicionar.Enabled = !isEditing;
            btnGuardar.Enabled = isEditing;
            btnEliminar.Enabled = isEditing;
            btnCancelar.Enabled = isEditing;

            groupBox2.Enabled = isEditing;
            groupBox3.Enabled = isEditing;
            groupBox4.Enabled = isEditing;
        }

        private void clearTextBoxes()
        {
            tbDescrição.Text = "";
            tbLocal.Text = "";
            nmLimite.Value = 0;
            tbHora.Text = getHora(DateTime.Now);
            dateTimePicker1.Value = DateTime.Now;
            nmSuperior.Value = 0;
            nmInferior.Value = 0;
            tbTipoEvento.Text = "";

            cbColaborações.SelectedIndex = -1;
            cbParticipações.SelectedIndex = -1;
            cbInscrições.SelectedIndex = -1;

            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            dataGridView4.DataSource = null;

            isEditing = false;

            updateLayout();
        }


        private DateTime getDataHora(DateTime data, string hora)
        {
            int ihora = Convert.ToInt32(hora.Substring(0, 2));
            int imin = Convert.ToInt32(hora.Substring(3, 2));
            DateTime dt = new DateTime(data.Year, data.Month, data.Day, ihora, imin, 0);
            return dt;
        }

        private string getHora(DateTime data)
        {
            string hora = string.Format("{0:0#}:{1:0#}", data.Hour, data.Minute);
            return hora;
        }

        private bool InputValid()
        {
            if (tbDescrição.Text == "")
            {
                MessageBox.Show("Insira a descrição do evento", "Parametro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbLocal.Text == "")
            {
                MessageBox.Show("Insira o local do evento", "Parametro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbTipoEvento.Text == "")
            {
                MessageBox.Show("Insira o tipo de evento", "Parametro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (nmLimite.Value == 0)
            {
                MessageBox.Show("Insira o limite de participações do evento", "Parametro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (nmSuperior.Value == 0)
            {
                MessageBox.Show("Insira o limite de idade superior do evento", "Parametro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void BtnAdicionarColaborador_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbColaborações.SelectedIndex == -1)
                    return;

                Evento evento = (Evento)dataGridView1.SelectedRows[0].DataBoundItem;

                Colaboração colaboração = new Colaboração
                {
                    EventoNrEvento = evento.NrEvento,
                    AnimadorIdPessoa = (int)cbColaborações.SelectedValue
                };

                modelContainer.Colaboração.Add(colaboração);
                modelContainer.SaveChanges();
                carregarEventos();
                clearTextBoxes();
            }
            catch (Exception)
            {

            }
        }

        private void BtnRemoverColaborador_Click(object sender, EventArgs e)
        {
            try
            {
                int idPessoa = (int)dataGridView2.SelectedRows[0].Cells[2].Value;
                int nrEvento = (int)dataGridView2.SelectedRows[0].Cells[3].Value;

                Colaboração colab = modelContainer.Colaboração.Where(x => x.AnimadorIdPessoa == idPessoa && x.EventoNrEvento == nrEvento).FirstOrDefault();
                modelContainer.Colaboração.Remove(colab);
                modelContainer.SaveChanges();
                carregarEventos();

                clearTextBoxes();
            }
            catch (Exception)
            {

            }
        }

        private void BtnAdicionarEscolas_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbParticipações.SelectedIndex == -1)
                    return;

                Evento evento = (Evento)dataGridView1.SelectedRows[0].DataBoundItem;

                Participação participação = new Participação
                {
                    EventoNrEvento = evento.NrEvento,
                    EscolaIdEscola = (int)cbParticipações.SelectedValue
                };

                modelContainer.Participação.Add(participação);
                modelContainer.SaveChanges();
                carregarEventos();
                clearTextBoxes();
            }
            catch (Exception)
            {

            }
        }

        private void BtnEleminarEscolas_Click(object sender, EventArgs e)
        {
            try
            {
                int idEscola = (int)dataGridView3.SelectedRows[0].Cells[1].Value;
                int nrEvento = (int)dataGridView3.SelectedRows[0].Cells[2].Value;

                Participação colab = modelContainer.Participação.Where(x => x.EscolaIdEscola == idEscola && x.EventoNrEvento == nrEvento).FirstOrDefault();
                modelContainer.Participação.Remove(colab);
                modelContainer.SaveChanges();
                carregarEventos();

                clearTextBoxes();
            }
            catch (Exception)
            {

            }
        }

        private void BtnAdicionarFilho_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbInscrições.SelectedIndex == -1)
                    return;

                Evento evento = (Evento)dataGridView1.SelectedRows[0].DataBoundItem;

                Inscrição inscrição = new Inscrição
                {
                    EventoNrEvento = evento.NrEvento,
                    FilhoIdPessoa = (int)cbInscrições.SelectedValue
                };

                modelContainer.Inscrição.Add(inscrição);
                modelContainer.SaveChanges();
                carregarEventos();
                clearTextBoxes();
            }
            catch (Exception)
            {

            }
        }

        private void BtnEliminarFilho_Click(object sender, EventArgs e)
        {
            try
            {
                int idPessoa = (int)dataGridView4.SelectedRows[0].Cells[1].Value;
                int nrEvento = (int)dataGridView4.SelectedRows[0].Cells[2].Value;

                Inscrição colab = modelContainer.Inscrição.Where(x => x.FilhoIdPessoa == idPessoa && x.EventoNrEvento == nrEvento).FirstOrDefault();
                modelContainer.Inscrição.Remove(colab);
                modelContainer.SaveChanges();
                carregarEventos();

                clearTextBoxes();
            }
            catch (Exception)
            {

            }
        }
    }
}
