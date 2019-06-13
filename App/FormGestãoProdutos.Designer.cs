namespace Bookids
{
    partial class FormGestãoProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Bookids.DatabaseDataSet();
            this.tbDesignação = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.produtoTableAdapter = new Bookids.DatabaseDataSetTableAdapters.EscolasTableAdapter();
            this.codProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockExistenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoesTableAdapter = new Bookids.DatabaseDataSetTableAdapters.ProdutoesTableAdapter();
            this.nStock = new System.Windows.Forms.NumericUpDown();
            this.tbPreço = new System.Windows.Forms.TextBox();
            this.cbTipoProduto = new System.Windows.Forms.ComboBox();
            this.tipoProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoProdutosTableAdapter = new Bookids.DatabaseDataSetTableAdapters.TipoProdutosTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdicionar1 = new System.Windows.Forms.Button();
            this.btnCancelar1 = new System.Windows.Forms.Button();
            this.btnEleminar1 = new System.Windows.Forms.Button();
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tipoProdutosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.codTipoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProdutoDataGridViewTextBoxColumn,
            this.designaçãoDataGridViewTextBoxColumn,
            this.preçoDataGridViewTextBoxColumn,
            this.stockExistenteDataGridViewTextBoxColumn,
            this.tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1213, 742);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produtoes";
            this.produtoBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbDesignação
            // 
            this.tbDesignação.Location = new System.Drawing.Point(125, 58);
            this.tbDesignação.Name = "tbDesignação";
            this.tbDesignação.Size = new System.Drawing.Size(347, 26);
            this.tbDesignação.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Designação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "StockExistente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo Produto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipoProduto);
            this.groupBox1.Controls.Add(this.nStock);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.tbPreço);
            this.groupBox1.Controls.Add(this.tbDesignação);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1231, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 423);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(29, 186);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(443, 50);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(29, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(443, 50);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar Edição";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(29, 298);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(443, 50);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(29, 242);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(443, 50);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // codProdutoDataGridViewTextBoxColumn
            // 
            this.codProdutoDataGridViewTextBoxColumn.DataPropertyName = "CodProduto";
            this.codProdutoDataGridViewTextBoxColumn.HeaderText = "CodProduto";
            this.codProdutoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codProdutoDataGridViewTextBoxColumn.Name = "codProdutoDataGridViewTextBoxColumn";
            this.codProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codProdutoDataGridViewTextBoxColumn.Width = 150;
            // 
            // designaçãoDataGridViewTextBoxColumn
            // 
            this.designaçãoDataGridViewTextBoxColumn.DataPropertyName = "Designação";
            this.designaçãoDataGridViewTextBoxColumn.HeaderText = "Designação";
            this.designaçãoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.designaçãoDataGridViewTextBoxColumn.Name = "designaçãoDataGridViewTextBoxColumn";
            this.designaçãoDataGridViewTextBoxColumn.ReadOnly = true;
            this.designaçãoDataGridViewTextBoxColumn.Width = 150;
            // 
            // preçoDataGridViewTextBoxColumn
            // 
            this.preçoDataGridViewTextBoxColumn.DataPropertyName = "Preço";
            this.preçoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.preçoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.preçoDataGridViewTextBoxColumn.Name = "preçoDataGridViewTextBoxColumn";
            this.preçoDataGridViewTextBoxColumn.ReadOnly = true;
            this.preçoDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockExistenteDataGridViewTextBoxColumn
            // 
            this.stockExistenteDataGridViewTextBoxColumn.DataPropertyName = "StockExistente";
            this.stockExistenteDataGridViewTextBoxColumn.HeaderText = "StockExistente";
            this.stockExistenteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockExistenteDataGridViewTextBoxColumn.Name = "stockExistenteDataGridViewTextBoxColumn";
            this.stockExistenteDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockExistenteDataGridViewTextBoxColumn.Width = 150;
            // 
            // tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn
            // 
            this.tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn.DataPropertyName = "TipoProdutoCodTipoProduto";
            this.tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn.HeaderText = "TipoProdutoCodTipoProduto";
            this.tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn.Name = "tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn";
            this.tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn.Width = 150;
            // 
            // produtoesTableAdapter
            // 
            this.produtoesTableAdapter.ClearBeforeFill = true;
            // 
            // nStock
            // 
            this.nStock.Location = new System.Drawing.Point(147, 123);
            this.nStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nStock.Name = "nStock";
            this.nStock.Size = new System.Drawing.Size(325, 26);
            this.nStock.TabIndex = 0;
            // 
            // tbPreço
            // 
            this.tbPreço.Location = new System.Drawing.Point(81, 90);
            this.tbPreço.Name = "tbPreço";
            this.tbPreço.Size = new System.Drawing.Size(391, 26);
            this.tbPreço.TabIndex = 2;
            // 
            // cbTipoProduto
            // 
            this.cbTipoProduto.DataSource = this.tipoProdutosBindingSource;
            this.cbTipoProduto.DisplayMember = "Tipo";
            this.cbTipoProduto.FormattingEnabled = true;
            this.cbTipoProduto.Location = new System.Drawing.Point(130, 154);
            this.cbTipoProduto.Name = "cbTipoProduto";
            this.cbTipoProduto.Size = new System.Drawing.Size(342, 28);
            this.cbTipoProduto.TabIndex = 5;
            this.cbTipoProduto.ValueMember = "CodTipoProduto";
            // 
            // tipoProdutosBindingSource
            // 
            this.tipoProdutosBindingSource.DataMember = "TipoProdutos";
            this.tipoProdutosBindingSource.DataSource = this.databaseDataSet;
            // 
            // tipoProdutosTableAdapter
            // 
            this.tipoProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codTipoProdutoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tipoProdutosBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(1731, 12);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(551, 742);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdicionar1);
            this.groupBox2.Controls.Add(this.btnCancelar1);
            this.groupBox2.Controls.Add(this.btnEleminar1);
            this.groupBox2.Controls.Add(this.btnGuardar1);
            this.groupBox2.Controls.Add(this.tbTipo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(1231, 450);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 304);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipos De Produto";
            // 
            // btnAdicionar1
            // 
            this.btnAdicionar1.Location = new System.Drawing.Point(20, 65);
            this.btnAdicionar1.Name = "btnAdicionar1";
            this.btnAdicionar1.Size = new System.Drawing.Size(443, 50);
            this.btnAdicionar1.TabIndex = 4;
            this.btnAdicionar1.Text = "Adicionar";
            this.btnAdicionar1.UseVisualStyleBackColor = true;
            this.btnAdicionar1.Click += new System.EventHandler(this.BtnAdicionar1_Click);
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.Location = new System.Drawing.Point(20, 233);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new System.Drawing.Size(443, 50);
            this.btnCancelar1.TabIndex = 4;
            this.btnCancelar1.Text = "Cancelar Edição";
            this.btnCancelar1.UseVisualStyleBackColor = true;
            this.btnCancelar1.Click += new System.EventHandler(this.BtnCancelar1_Click);
            // 
            // btnEleminar1
            // 
            this.btnEleminar1.Location = new System.Drawing.Point(20, 177);
            this.btnEleminar1.Name = "btnEleminar1";
            this.btnEleminar1.Size = new System.Drawing.Size(443, 50);
            this.btnEleminar1.TabIndex = 4;
            this.btnEleminar1.Text = "Eliminar";
            this.btnEleminar1.UseVisualStyleBackColor = true;
            this.btnEleminar1.Click += new System.EventHandler(this.BtnEleminar1_Click);
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Location = new System.Drawing.Point(20, 121);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(443, 50);
            this.btnGuardar1.TabIndex = 4;
            this.btnGuardar1.Text = "Guardar";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Click += new System.EventHandler(this.BtnGuardar1_Click);
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(61, 33);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(402, 26);
            this.tbTipo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tipo";
            // 
            // tipoProdutosBindingSource1
            // 
            this.tipoProdutosBindingSource1.DataMember = "TipoProdutos";
            this.tipoProdutosBindingSource1.DataSource = this.databaseDataSet;
            // 
            // codTipoProdutoDataGridViewTextBoxColumn
            // 
            this.codTipoProdutoDataGridViewTextBoxColumn.DataPropertyName = "CodTipoProduto";
            this.codTipoProdutoDataGridViewTextBoxColumn.HeaderText = "CodTipoProduto";
            this.codTipoProdutoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codTipoProdutoDataGridViewTextBoxColumn.Name = "codTipoProdutoDataGridViewTextBoxColumn";
            this.codTipoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codTipoProdutoDataGridViewTextBoxColumn.Width = 150;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 150;
            // 
            // FormGestãoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2294, 766);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGestãoProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Produtos";
            this.Load += new System.EventHandler(this.FormGestãoEscolas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbDesignação;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DatabaseDataSetTableAdapters.EscolasTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preçoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockExistenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProdutoCodTipoProdutoDataGridViewTextBoxColumn;
        private DatabaseDataSetTableAdapters.ProdutoesTableAdapter produtoesTableAdapter;
        private System.Windows.Forms.ComboBox cbTipoProduto;
        private System.Windows.Forms.NumericUpDown nStock;
        private System.Windows.Forms.TextBox tbPreço;
        private System.Windows.Forms.BindingSource tipoProdutosBindingSource;
        private DatabaseDataSetTableAdapters.TipoProdutosTableAdapter tipoProdutosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTipoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tipoProdutosBindingSource1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdicionar1;
        private System.Windows.Forms.Button btnCancelar1;
        private System.Windows.Forms.Button btnEleminar1;
        private System.Windows.Forms.Button btnGuardar1;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.Label label8;
    }
}