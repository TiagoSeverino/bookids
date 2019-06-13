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
    public partial class FormGestãoProdutos : Form
    {
        ModelContainer modelContainer;
        bool isEditing = false;

        bool isEditing1 = false;
        public FormGestãoProdutos()
        {
            InitializeComponent();

            modelContainer = new ModelContainer();

            carregarEscolas1();
            clearTextBoxes1();
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

                int cod = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                var animador = (from _animador in modelContainer.Produtoes
                                where _animador.CodProduto == cod
                                select _animador).FirstOrDefault();

                tbDesignação.Text = animador.Designação;
                tbPreço.Text = animador.Preço.ToString();
                nStock.Value = animador.StockExistente;

                cbTipoProduto.SelectedValue = animador.TipoProdutoCodTipoProduto;
                cbTipoProduto.Text = animador.TipoProduto.Tipo.ToString();

                isEditing = true;
                updateLayout();
            }
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView2.CurrentRow.Selected = true;

                int cod = Convert.ToInt32(this.dataGridView2.Rows[e.RowIndex].Cells[0].Value);

                var animador = (from _animador in modelContainer.TipoProdutos
                                where _animador.CodTipoProduto == cod
                                select _animador).FirstOrDefault();

                tbTipo.Text = animador.Tipo;

                isEditing1 = true;
                updateLayout1();
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto escola = new Produto
                {
                    Designação = tbDesignação.Text,
                    Preço = double.Parse(tbPreço.Text),
                    StockExistente = (int)nStock.Value,
                    TipoProdutoCodTipoProduto = (int)cbTipoProduto.SelectedValue
                };

                modelContainer.Produtoes.Add(escola);
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
                Produto esc = (Produto)dataGridView1.SelectedRows[0].DataBoundItem;

 
                var escola = (from escolas in modelContainer.Produtoes
                              where escolas.CodProduto == esc.CodProduto
                              select escolas).FirstOrDefault();

                escola.Designação = tbDesignação.Text;
                escola.Preço = double.Parse(tbPreço.Text);
                escola.StockExistente = (int)nStock.Value;
                escola.TipoProdutoCodTipoProduto = (int)cbTipoProduto.SelectedValue;

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
                Produto escola = (Produto)dataGridView1.SelectedRows[0].DataBoundItem;

                modelContainer.Produtoes.Remove(escola);
                modelContainer.SaveChanges();
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
            var listaEscolas = from escola in modelContainer.Produtoes
                               orderby escola.Designação
                               select escola;
            produtoBindingSource.DataSource = listaEscolas.ToList();

            updateLayout();
        }

        private void carregarEscolas1()
        {
            var listaEscolas = from escola in modelContainer.TipoProdutos
                               orderby escola.Tipo
                               select escola;
            tipoProdutosBindingSource.DataSource = listaEscolas.ToList();
            tipoProdutosBindingSource1.DataSource = listaEscolas.ToList();

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
            tbDesignação.Text = "";
            tbPreço.Text = "";
            nStock.Value = 0;
            cbTipoProduto.SelectedIndex = -1;

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
            tbTipo.Text = "";
            isEditing1 = false;

            updateLayout1();
        }

        private void BtnAdicionar1_Click(object sender, EventArgs e)
        {
            TipoProduto tipoProduto = new TipoProduto
            {
                Tipo = tbTipo.Text
            };

            modelContainer.TipoProdutos.Add(tipoProduto);
            modelContainer.SaveChanges();
            carregarEscolas1();

            clearTextBoxes1();
        }

        private void BtnGuardar1_Click(object sender, EventArgs e)
        {
            try
            {
                TipoProduto esc = (TipoProduto)dataGridView2.SelectedRows[0].DataBoundItem;


                var tipo = (from escolas in modelContainer.TipoProdutos
                              where escolas.CodTipoProduto == esc.CodTipoProduto
                              select escolas).FirstOrDefault();

                tipo.Tipo = tbTipo.Text;

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
                TipoProduto escola = (TipoProduto)dataGridView2.SelectedRows[0].DataBoundItem;



                var produto = from produtos in modelContainer.Produtoes
                            where produtos.TipoProdutoCodTipoProduto == escola.CodTipoProduto
                            select produtos;

                if (produto.Any())
                {
                    MessageBox.Show("Este tipo está a ser usado por outros produtos", "Erro ao apagar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    modelContainer.TipoProdutos.Remove(escola);
                    modelContainer.SaveChanges();
                }

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
