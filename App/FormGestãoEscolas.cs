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
    public partial class FormGestãoEscolas : Form
    {
        ModelContainer modelContainer;
        bool isEditing = false;

        public FormGestãoEscolas()
        {
            InitializeComponent();

            modelContainer = new ModelContainer();

            carregarEscolas();
            clearTextBoxes();
        }

        private void FormGestãoEscolas_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.CurrentRow.Selected = true;

                Escola escola = (Escola)dataGridView1.SelectedRows[0].DataBoundItem;

                tbNome.Text = escola.Nome;
                tbMorada.Text = escola.Morada;
                tbTelefone.Text = escola.Telefone;
                tbMail.Text = escola.Mail;
                tbCodPostal.Text = escola.CodPostal;
                tbLocalidade.Text = escola.Localidade;

                isEditing = true;
                updateLayout();
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Escola escola = new Escola
            {
                Nome = tbNome.Text,
                Morada = tbMorada.Text,
                Telefone = tbTelefone.Text,
                Mail = tbMail.Text,
                CodPostal = tbCodPostal.Text,
                Localidade = tbLocalidade.Text
            };

            modelContainer.Escolas.Add(escola);
            modelContainer.SaveChanges();
            carregarEscolas();

            clearTextBoxes();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Escola esc = (Escola)dataGridView1.SelectedRows[0].DataBoundItem;

 
                var escola = (from escolas in modelContainer.Escolas
                              where escolas.IdEscola == esc.IdEscola
                              select escolas).FirstOrDefault();

                escola.Nome = tbNome.Text;
                escola.Morada = tbMorada.Text;
                escola.Telefone = tbTelefone.Text;
                escola.Mail = tbMail.Text;
                escola.CodPostal = tbCodPostal.Text;
                escola.Localidade = tbLocalidade.Text;

                modelContainer.SaveChanges();
                carregarEscolas();

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
                Escola escola = (Escola)dataGridView1.SelectedRows[0].DataBoundItem;

                var produto = from produtos in modelContainer.Filhos
                              where produtos.EscolaIdEscola == escola.IdEscola
                              select produtos;

                if (produto.Any())
                {
                    MessageBox.Show("Esta escola tem um ou mais filhos registados", "Erro ao apagar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    modelContainer.Escolas.Remove(escola);
                    modelContainer.SaveChanges();
                }

                carregarEscolas();

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

        private void carregarEscolas()
        {
            var listaEscolas = from escola in modelContainer.Escolas
                               orderby escola.Nome
                               select escola;
            escolasBindingSource.DataSource = listaEscolas.ToList();

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
            tbMail.Text = "";
            tbCodPostal.Text = "";
            tbLocalidade.Text = "";

            isEditing = false;

            updateLayout();
        }
    }
}
