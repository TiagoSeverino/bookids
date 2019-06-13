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
            InitColumn();

            modelContainer = new ModelContainer();

            carregarClientes();
            clearTextBoxesClientes();
            carregarFilhos();
            clearTextBoxesFilhos();
        }

        private void FormGestãoEscolas_Load(object sender, EventArgs e)
        {

        }

        private void InitColumn()
        {
            System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();

            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 8;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Width = 150;

            System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();

            nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn1.ReadOnly = true;
            nomeDataGridViewTextBoxColumn1.Width = 150;

            this.dataGridView1.Columns.Insert(0, nomeDataGridViewTextBoxColumn);
            this.dataGridView2.Columns.Insert(0, nomeDataGridViewTextBoxColumn1);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.CurrentRow.Selected = true;

                Cliente cliente = (Cliente)dataGridView1.SelectedRows[0].DataBoundItem;

                tbNome.Text = cliente.Nome;
                tbMorada.Text = cliente.Morada;
                tbTelefone.Text = cliente.Telefone;
                tbTelemovel.Text = cliente.Telemovel;
                tbMail.Text = cliente.Mail;
                tbCodPostal.Text = cliente.CodPostal;
                tbLocalidade.Text = cliente.Localidade;
                tbOferta.Text = cliente.ValorOferta.ToString();
                tbNrCartao.Text = cliente.NrCartao.ToString();

                isEditing = true;
                updateLayoutCliente();
            }
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView2.CurrentRow.Selected = true;

                Filho filho = (Filho)dataGridView2.SelectedRows[0].DataBoundItem;

                tbNomeFilho.Text = filho.Nome;
                rMasculino.Checked = filho.Sexo == "Masculino";
                rFeminino.Checked = filho.Sexo != "Masculino";
                dateTimePicker1.Value = DateTime.Parse(filho.DataNascimento);

                comboBox1.SelectedValue = filho.ClienteIdPessoa;
                comboBox1.Text = filho.Clientes.Nome;

                comboBox2.SelectedValue = filho.EscolaIdEscola;
                comboBox2.Text = filho.Escolas.Nome;

                isEditing1 = true;
                updateLayoutFilho();
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!InputValid())
                    return;

                Cliente cliente = new Cliente
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

                modelContainer.Clientes.Add(cliente);
                modelContainer.SaveChanges();
                carregarClientes();

                clearTextBoxesClientes();
            }
            catch (Exception)
            {

            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!InputValid())
                    return;

                Cliente cl = (Cliente)dataGridView1.SelectedRows[0].DataBoundItem;

 
                var cliente = (from clientes in modelContainer.Clientes
                              where clientes.IdPessoa == cl.IdPessoa
                              select clientes).FirstOrDefault();

                cliente.Nome = tbNome.Text;
                cliente.Morada = tbMorada.Text;
                cliente.Telefone = tbTelefone.Text;
                cliente.Telemovel = tbTelemovel.Text;
                cliente.Mail = tbMail.Text;
                cliente.CodPostal = tbCodPostal.Text;
                cliente.Localidade = tbLocalidade.Text;
                cliente.ValorOferta = double.Parse(tbOferta.Text);
                cliente.NrCartao = int.Parse(tbNrCartao.Text);

                modelContainer.SaveChanges();
                carregarClientes();

                clearTextBoxesClientes();
            }
            catch (Exception)
            {

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)dataGridView1.SelectedRows[0].DataBoundItem;

                var filho = from filhos in modelContainer.Filhos
                              where filhos.ClienteIdPessoa == cliente.IdPessoa
                              select filhos;

                if (filho.Any())
                {
                    MessageBox.Show("Este cliente tem um ou mais filhos registados", "Erro ao apagar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    modelContainer.Clientes.Remove(cliente);
                    modelContainer.SaveChanges();
                }

                carregarClientes();

                clearTextBoxesClientes();
            }
            catch(Exception)
            {

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            clearTextBoxesClientes();
        }

        private void carregarClientes()
        {
            var clientes = from cliente in modelContainer.Clientes
                               orderby cliente.Nome
                               select cliente;
            pessoasClienteBindingSource.DataSource = clientes.ToList();

            updateLayoutCliente();
        }

        private void carregarFilhos()
        {
            var filhos = from filho in modelContainer.Filhos
                               orderby filho.Nome
                               select filho;
            pessoasFilhoBindingSource.DataSource = filhos.ToList();

            var listaEscolas = from escola in modelContainer.Escolas
                               orderby escola.Nome
                               select escola;
            escolasBindingSource.DataSource = listaEscolas.ToList();

            updateLayoutFilho();
        }

        private void updateLayoutCliente()
        {
            btnAdicionar.Enabled = !isEditing;
            btnGuardar.Enabled = isEditing;
            btnEliminar.Enabled = isEditing;
            btnCancelar.Enabled = isEditing;
        }

        private void clearTextBoxesClientes()
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

            updateLayoutCliente();
        }

        private void updateLayoutFilho()
        {
            btnAdicionar1.Enabled = !isEditing1;
            btnGuardar1.Enabled = isEditing1;
            btnEleminar1.Enabled = isEditing1;
            btnCancelar1.Enabled = isEditing1;
        }

        private void clearTextBoxesFilhos()
        {
            tbNomeFilho.Text = "";
            rMasculino.Checked = true;
            rFeminino.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            isEditing1 = false;

            updateLayoutFilho();
        }

        private void BtnAdicionar1_Click(object sender, EventArgs e)
        {
            if (!InputValidFilho())
                return;

            Filho filho = new Filho
            {
                Nome = tbNomeFilho.Text,
                Morada = ((Cliente)comboBox1.SelectedItem).Morada,
                Telefone = ((Cliente)comboBox1.SelectedItem).Telefone,
                Telemovel = ((Cliente)comboBox1.SelectedItem).Telemovel,
                Mail = ((Cliente)comboBox1.SelectedItem).Mail,
                CodPostal = ((Cliente)comboBox1.SelectedItem).CodPostal,
                Localidade = ((Cliente)comboBox1.SelectedItem).Localidade,
                Sexo = rMasculino.Checked ? "Masculino" : "Femino",
                DataNascimento = dateTimePicker1.Value.ToShortDateString(),
                ClienteIdPessoa = (int)comboBox1.SelectedValue,
                EscolaIdEscola = (int)comboBox2.SelectedValue
            };

            modelContainer.Filhos.Add(filho);
            modelContainer.SaveChanges();
            carregarFilhos();

            clearTextBoxesFilhos();
        }

        private void BtnGuardar1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!InputValidFilho())
                    return;

                Filho f = (Filho)dataGridView2.SelectedRows[0].DataBoundItem;


                var filho = (from filhos in modelContainer.Filhos
                              where filhos.IdPessoa == f.IdPessoa
                              select filhos).FirstOrDefault();

                filho.Nome = tbNomeFilho.Text;
                filho.Morada = ((Cliente)comboBox1.SelectedItem).Morada;
                filho.Telefone = ((Cliente)comboBox1.SelectedItem).Telefone;
                filho.Telemovel = ((Cliente)comboBox1.SelectedItem).Telemovel;
                filho.Mail = ((Cliente)comboBox1.SelectedItem).Mail;
                filho.CodPostal = ((Cliente)comboBox1.SelectedItem).CodPostal;
                filho.Localidade = ((Cliente)comboBox1.SelectedItem).Localidade;
                filho.Sexo = rMasculino.Checked ? "Masculino" : "Femino";
                filho.DataNascimento = dateTimePicker1.Value.ToShortDateString();
                filho.ClienteIdPessoa = (int)comboBox1.SelectedValue;
                filho.EscolaIdEscola = (int)comboBox2.SelectedValue;

                modelContainer.SaveChanges();
                carregarFilhos();

                clearTextBoxesFilhos();
            }
            catch (Exception)
            {

            }
        }

        private void BtnEleminar1_Click(object sender, EventArgs e)
        {
            try
            {
                Filho f = (Filho)dataGridView2.SelectedRows[0].DataBoundItem;

                modelContainer.Filhos.Remove(f);
                modelContainer.SaveChanges();

                carregarFilhos();

                clearTextBoxesFilhos();
            }
            catch (Exception)
            {

            }
        }

        private void BtnCancelar1_Click(object sender, EventArgs e)
        {
            clearTextBoxesFilhos();
        }

        private bool InputValid()
        {
            if (tbNome.Text == "")
            {
                MessageBox.Show("Insira o nome do cliente", "Parametro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbMorada.Text == "")
            {
                MessageBox.Show("Insira a morada do cliente", "Parametro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbTelefone.Text == "")
            {
                MessageBox.Show("Insira o telefone do cliente", "Parametro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbTelemovel.Text == "")
            {
                MessageBox.Show("Insira o telemovel do cliente", "Parametro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbMail.Text == "")
            {
                MessageBox.Show("Insira o email do cliente", "Parametro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbCodPostal.Text == "")
            {
                MessageBox.Show("Insira o código de postal do cliente", "Parametro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbLocalidade.Text == "")
            {
                MessageBox.Show("Insira a localidade do cliente", "Parametro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbOferta.Text == "")
            {
                MessageBox.Show("Insira o valor de oferta do cliente", "Parametro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tbNrCartao.Text == "")
            {
                MessageBox.Show("Insira o número do cartão do cliente", "Parametro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool InputValidFilho()
        {
            if (tbNomeFilho.Text == "")
            {
                MessageBox.Show("Insira o nome do filho", "Parametro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o pai do filho", "Parametro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a escola do filho", "Parametro Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
