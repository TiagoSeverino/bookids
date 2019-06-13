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

            carregarTipoProdutos();
            clearTextBoxesTipoProdutos();
            carregarProdutos();
            clearTextBoxesProdutos();
        }

        private void FormGestãoEscolas_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.CurrentRow.Selected = true;

                Produto produto = (Produto)dataGridView1.SelectedRows[0].DataBoundItem;

                tbDesignação.Text = produto.Designação;
                tbPreço.Text = produto.Preço.ToString();
                nStock.Value = produto.StockExistente;

                cbTipoProduto.SelectedValue = produto.TipoProdutoCodTipoProduto;
                cbTipoProduto.Text = produto.TipoProduto.Tipo.ToString();

                isEditing = true;
                updateLayout();
            }
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView2.CurrentRow.Selected = true;

                TipoProduto tipoProduto= (TipoProduto)dataGridView2.SelectedRows[0].DataBoundItem;

                tbTipo.Text = tipoProduto.Tipo;

                isEditing1 = true;
                updateLayout1();
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto
                {
                    Designação = tbDesignação.Text,
                    Preço = double.Parse(tbPreço.Text),
                    StockExistente = (int)nStock.Value,
                    TipoProdutoCodTipoProduto = (int)cbTipoProduto.SelectedValue
                };

                modelContainer.Produtoes.Add(produto);
                modelContainer.SaveChanges();
                carregarProdutos();

                clearTextBoxesProdutos();
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto prod = (Produto)dataGridView1.SelectedRows[0].DataBoundItem;

 
                var produto = (from produtos in modelContainer.Produtoes
                              where produtos.CodProduto == prod.CodProduto
                              select produtos).FirstOrDefault();

                produto.Designação = tbDesignação.Text;
                produto.Preço = double.Parse(tbPreço.Text);
                produto.StockExistente = (int)nStock.Value;
                produto.TipoProdutoCodTipoProduto = (int)cbTipoProduto.SelectedValue;

                modelContainer.SaveChanges();
                carregarProdutos();

                clearTextBoxesProdutos();
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = (Produto)dataGridView1.SelectedRows[0].DataBoundItem;

                modelContainer.Produtoes.Remove(produto);
                modelContainer.SaveChanges();
                carregarProdutos();

                clearTextBoxesProdutos();
            }
            catch(Exception ex)
            {

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            clearTextBoxesProdutos();
        }

        private void carregarProdutos()
        {
            var listaProdutos = from produto in modelContainer.Produtoes
                               orderby produto.Designação
                               select produto;
            produtoBindingSource.DataSource = listaProdutos.ToList();

            updateLayout();
        }

        private void carregarTipoProdutos()
        {
            var listaTipos = from tipo in modelContainer.TipoProdutos
                               orderby tipo.Tipo
                               select tipo;
            tipoProdutosBindingSource.DataSource = listaTipos.ToList();
            tipoProdutosBindingSource1.DataSource = listaTipos.ToList();

            updateLayout1();
        }

        private void updateLayout()
        {
            btnAdicionar.Enabled = !isEditing;
            btnGuardar.Enabled = isEditing;
            btnEliminar.Enabled = isEditing;
            btnCancelar.Enabled = isEditing;
        }

        private void clearTextBoxesProdutos()
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

        private void clearTextBoxesTipoProdutos()
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
            carregarTipoProdutos();

            clearTextBoxesTipoProdutos();
        }

        private void BtnGuardar1_Click(object sender, EventArgs e)
        {
            try
            {
                TipoProduto tp = (TipoProduto)dataGridView2.SelectedRows[0].DataBoundItem;


                var tipo = (from tipos in modelContainer.TipoProdutos
                              where tipos.CodTipoProduto == tp.CodTipoProduto
                              select tipos).FirstOrDefault();

                tipo.Tipo = tbTipo.Text;

                modelContainer.SaveChanges();
                carregarTipoProdutos();

                clearTextBoxesTipoProdutos();
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnEleminar1_Click(object sender, EventArgs e)
        {
            try
            {
                TipoProduto tp = (TipoProduto)dataGridView2.SelectedRows[0].DataBoundItem;

                var produto = from produtos in modelContainer.Produtoes
                            where produtos.TipoProdutoCodTipoProduto == tp.CodTipoProduto
                            select produtos;

                if (produto.Any())
                {
                    MessageBox.Show("Este tipo está a ser usado por outros produtos", "Erro ao apagar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    modelContainer.TipoProdutos.Remove(tp);
                    modelContainer.SaveChanges();
                }

                carregarTipoProdutos();

                clearTextBoxesTipoProdutos();
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnCancelar1_Click(object sender, EventArgs e)
        {
            clearTextBoxesTipoProdutos();
        }
    }
}
