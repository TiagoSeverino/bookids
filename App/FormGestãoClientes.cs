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
    public partial class FormGestãoClientes : Form
    {
        ModelContainer modelContainer;
        bool isEditing = false;

        bool isEditing1 = false;
        public FormGestãoClientes()
        {
            InitializeComponent();

            modelContainer = new ModelContainer();

            carregarEscolas();
            clearTextBoxes();
            carregarEscolas1();
            clearTextBoxes1();
        }

        private void FormGestãoEscolas_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.CurrentRow.Selected = true;

                int id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                var animador = (from _animador in modelContainer.Clientes
                                where _animador.IdPessoa == id
                                select _animador).FirstOrDefault();

                tbNome.Text = animador.Nome;
                tbMorada.Text = animador.Morada;
                tbTelefone.Text = animador.Telefone;
                tbTelemovel.Text = animador.Telemovel;
                tbMail.Text = animador.Mail;
                tbCodPostal.Text = animador.CodPostal;
                tbLocalidade.Text = animador.Localidade;
                tbOferta.Text = animador.ValorOferta.ToString();
                tbNrCartao.Text = animador.NrCartao.ToString();

                isEditing = true;
                updateLayout();
            }
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView2.CurrentRow.Selected = true;

                int id = Convert.ToInt32(this.dataGridView2.Rows[e.RowIndex].Cells[0].Value);

                var escola = (from _animador in modelContainer.Filhos
                                where _animador.IdPessoa == id
                                select _animador).FirstOrDefault();

                tbNome1.Text = escola.Nome;
                tbMorada1.Text = escola.Morada;
                tbTelefone1.Text = escola.Telefone;
                tbTelemovel1.Text = escola.Telemovel;
                tbMail1.Text = escola.Mail;
                tbCodPostal1.Text = escola.CodPostal;
                tbLocalidade1.Text = escola.Localidade;
                rMasculino.Checked = escola.Sexo == "Masculino";
                rFeminino.Checked = escola.Sexo != "Masculino";
                dateTimePicker1.Value = DateTime.Parse(escola.DataNascimento);

                comboBox1.SelectedValue = escola.ClienteIdPessoa;
                comboBox1.Text = escola.Clientes.Nome;

                comboBox2.SelectedValue = escola.EscolaIdEscola;
                comboBox2.Text = escola.Escolas.Nome;

                isEditing1 = true;
                updateLayout1();
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente escola = new Cliente
                {
                    Nome = tbNome.Text,
                    Morada = tbMorada.Text,
                    Telefone = tbTelefone.Text,
                    Telemovel = tbTelemovel.Text,
                    Mail = tbMail.Text,
                    CodPostal = tbCodPostal.Text,
                    Localidade = tbLocalidade.Text,
                    ValorOferta = double.Parse(tbOferta.Text),
                    NrCartao = int.Parse(tbNrCartao.Text)
                };

                modelContainer.Clientes.Add(escola);
                modelContainer.SaveChanges();
                carregarEscolas();

                clearTextBoxes();
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente esc = (Cliente)dataGridView1.SelectedRows[0].DataBoundItem;

 
                var escola = (from escolas in modelContainer.Clientes
                              where escolas.IdPessoa == esc.IdPessoa
                              select escolas).FirstOrDefault();

                escola.Nome = tbNome.Text;
                escola.Morada = tbMorada.Text;
                escola.Telefone = tbTelefone.Text;
                escola.Telemovel = tbTelemovel.Text;
                escola.Mail = tbMail.Text;
                escola.CodPostal = tbCodPostal.Text;
                escola.Localidade = tbLocalidade.Text;
                escola.ValorOferta = double.Parse(tbOferta.Text);
                escola.NrCartao = int.Parse(tbNrCartao.Text);

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
                Cliente escola = (Cliente)dataGridView1.SelectedRows[0].DataBoundItem;

                var produto = from produtos in modelContainer.Filhos
                              where produtos.ClienteIdPessoa == escola.IdPessoa
                              select produtos;

                if (produto.Any())
                {
                    MessageBox.Show("Este cliente tem um ou mais filhos registados", "Erro ao apagar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    modelContainer.Clientes.Remove(escola);
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
            var listaEscolas = from escola in modelContainer.Clientes
                               orderby escola.Nome
                               select escola;
            pessoasClienteBindingSource.DataSource = listaEscolas.ToList();

            updateLayout();
        }

        private void carregarEscolas1()
        {
            var listaEscolas = from escola in modelContainer.Filhos
                               orderby escola.Nome
                               select escola;
            pessoasFilhoBindingSource.DataSource = listaEscolas.ToList();

            var listaEscolas1 = from escola in modelContainer.Escolas
                               orderby escola.Nome
                               select escola;
            escolasBindingSource.DataSource = listaEscolas1.ToList();

            updateLayout1();
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
            tbOferta.Text = "";
            tbNrCartao.Text = "";

            isEditing = false;

            updateLayout();
        }

        private void updateLayout1()
        {
            btnAdicionar1.Enabled = !isEditing1;
            btnGuardar1.Enabled = isEditing1;
            btnEleminar1.Enabled = isEditing1;
            btnCancelar1.Enabled = isEditing1;
        }

        private void clearTextBoxes1()
        {
            tbNome1.Text = "";
            tbMorada1.Text = "";
            tbTelefone1.Text = "";
            tbTelemovel1.Text = "";
            tbMail1.Text = "";
            tbCodPostal1.Text = "";
            tbLocalidade1.Text = "";
            rMasculino.Checked = true;
            rFeminino.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            isEditing1 = false;

            updateLayout1();
        }

        private void BtnAdicionar1_Click(object sender, EventArgs e)
        {
            Filho tipoProduto = new Filho
            {
                Nome = tbNome1.Text,
                Morada = tbMorada1.Text,
                Telefone = tbTelefone1.Text,
                Telemovel = tbTelemovel1.Text,
                Mail = tbMail1.Text,
                CodPostal = tbCodPostal1.Text,
                Localidade = tbLocalidade1.Text,
                Sexo = rMasculino.Checked ? "Masculino" : "Femino",
                DataNascimento = dateTimePicker1.Value.ToShortDateString(),
                ClienteIdPessoa = (int)comboBox1.SelectedValue,
                EscolaIdEscola = (int)comboBox2.SelectedValue
            };

            modelContainer.Filhos.Add(tipoProduto);
            modelContainer.SaveChanges();
            carregarEscolas1();

            clearTextBoxes1();
        }

        private void BtnGuardar1_Click(object sender, EventArgs e)
        {
            try
            {
                Filho esc = (Filho)dataGridView2.SelectedRows[0].DataBoundItem;


                var escola = (from escolas in modelContainer.Filhos
                              where escolas.IdPessoa == esc.IdPessoa
                              select escolas).FirstOrDefault();

                escola.Nome = tbNome1.Text;
                escola.Morada = tbMorada1.Text;
                escola.Telefone = tbTelefone1.Text;
                escola.Telemovel = tbTelemovel1.Text;
                escola.Mail = tbMail1.Text;
                escola.CodPostal = tbCodPostal1.Text;
                escola.Localidade = tbLocalidade1.Text;
                escola.Sexo = rMasculino.Checked ? "Masculino" : "Femino";
                escola.DataNascimento = dateTimePicker1.Value.ToShortDateString();
                escola.ClienteIdPessoa = (int)comboBox1.SelectedValue;
                escola.EscolaIdEscola = (int)comboBox2.SelectedValue;

                modelContainer.SaveChanges();
                carregarEscolas1();

                clearTextBoxes1();
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnEleminar1_Click(object sender, EventArgs e)
        {
            try
            {
                Filho escola = (Filho)dataGridView2.SelectedRows[0].DataBoundItem;



                var produto = from produtos in modelContainer.Filhos
                            where produtos.IdPessoa == escola.IdPessoa
                            select produtos;

                modelContainer.Filhos.Remove(escola);
                modelContainer.SaveChanges();

                carregarEscolas1();

                clearTextBoxes1();
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnCancelar1_Click(object sender, EventArgs e)
        {
            clearTextBoxes1();
        }
    }
}
