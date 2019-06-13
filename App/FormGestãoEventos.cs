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
            // TODO: This line of code loads data into the 'databaseDataSet.Eventoes' table. You can move, or remove it, as needed.
            this.eventoesTableAdapter.Fill(this.databaseDataSet.Eventoes);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.CurrentRow.Selected = true;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                tbDescrição.Text = row.Cells[1].Value.ToString();
                tbLocal.Text = row.Cells[2].Value.ToString();
                tbHora.Text = Convert.ToDateTime(row.Cells[3].Value.ToString()).ToShortTimeString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                nmLimite.Value = Convert.ToInt32(row.Cells[4].Value.ToString());
                nmInferior.Value = Convert.ToInt32(row.Cells[5].Value.ToString());
                nmSuperior.Value = Convert.ToInt32(row.Cells[6].Value.ToString());
                tbTipoEvento.Text = row.Cells[7].Value.ToString();

                isEditing = true;
                updateLayout();
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
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
                Evento esc = (Evento)dataGridView1.SelectedRows[0].DataBoundItem;

 
                var evento = (from eventos in modelContainer.Eventoes
                              where eventos.NrEvento == esc.NrEvento
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
            catch (Exception ex)
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
            catch(Exception ex)
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
    }
}
