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
    public partial class FormGestãoAnimadores : Form
    {
        ModelContainer modelContainer;
        bool isEditing = false;

        public FormGestãoAnimadores()
        {
            InitializeComponent();

            modelContainer = new ModelContainer();

            carregarAnimadores();
            clearTextBoxes();
        }

        private void FormGestãoAnimadores_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.CurrentRow.Selected = true;

                Animador animador= (Animador)dataGridView1.SelectedRows[0].DataBoundItem;

                tbNome.Text = animador.Nome;
                tbMorada.Text = animador.Morada;
                tbTelefone.Text = animador.Telefone;
                tbTelemovel.Text = animador.Telemovel;
                tbMail.Text = animador.Mail;
                tbCodPostal.Text = animador.CodPostal;
                tbLocalidade.Text = animador.Localidade;
                tbEspecialidade.Text = animador.Especialidade;

                isEditing = true;
                updateLayout();
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Animador animador = new Animador
            {
                Nome = tbNome.Text,
                Morada = tbMorada.Text,
                Telefone = tbTelefone.Text,
                Telemovel = tbTelemovel.Text,
                Mail = tbMail.Text,
                CodPostal = tbCodPostal.Text,
                Localidade = tbLocalidade.Text,
                Especialidade = tbEspecialidade.Text
        };

            modelContainer.Animadores.Add(animador);
            modelContainer.SaveChanges();
            carregarAnimadores();

            clearTextBoxes();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Animador esc = (Animador)dataGridView1.SelectedRows[0].DataBoundItem;


                var animador = (from _animador in modelContainer.Animadores
                                where _animador.IdPessoa == esc.IdPessoa
                                select _animador).FirstOrDefault();

                animador.Nome = tbNome.Text;
                animador.Morada = tbMorada.Text;
                animador.Telefone = tbTelefone.Text;
                animador.Telemovel = tbTelemovel.Text;
                animador.Mail = tbMail.Text;
                animador.CodPostal = tbCodPostal.Text;
                animador.Localidade = tbLocalidade.Text;
                animador.Especialidade = tbEspecialidade.Text;

                modelContainer.SaveChanges();
                carregarAnimadores();

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
                Animador escola = (Animador)dataGridView1.SelectedRows[0].DataBoundItem;

                modelContainer.Animadores.Remove(escola);
                modelContainer.SaveChanges();
                carregarAnimadores();

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

        private void carregarAnimadores()
        {
            var listaAnimadores = from animador in modelContainer.Animadores
                               orderby animador.Nome
                               select animador;
            animadoresBindingSource.DataSource = listaAnimadores.ToList();

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
            tbNome.Text = "";
            tbMorada.Text = "";
            tbTelefone.Text = "";
            tbTelemovel.Text = "";
            tbMail.Text = "";
            tbCodPostal.Text = "";
            tbLocalidade.Text = "";
            tbEspecialidade.Text = "";

            isEditing = false;

            updateLayout();
        }
    }
}
