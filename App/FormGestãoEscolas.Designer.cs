namespace Bookids
{
    partial class FormGestãoEscolas
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
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEscolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escolasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Bookids.DatabaseDataSet();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbMorada = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbCodPostal = new System.Windows.Forms.TextBox();
            this.tbLocalidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.escolasTableAdapter = new Bookids.DatabaseDataSetTableAdapters.EscolasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.localidadeDataGridViewTextBoxColumn,
            this.moradaDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.codPostalDataGridViewTextBoxColumn,
            this.idEscolaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.escolasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(528, 800);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // localidadeDataGridViewTextBoxColumn
            // 
            this.localidadeDataGridViewTextBoxColumn.DataPropertyName = "Localidade";
            this.localidadeDataGridViewTextBoxColumn.HeaderText = "Localidade";
            this.localidadeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.localidadeDataGridViewTextBoxColumn.Name = "localidadeDataGridViewTextBoxColumn";
            this.localidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.localidadeDataGridViewTextBoxColumn.Width = 150;
            // 
            // moradaDataGridViewTextBoxColumn
            // 
            this.moradaDataGridViewTextBoxColumn.DataPropertyName = "Morada";
            this.moradaDataGridViewTextBoxColumn.HeaderText = "Morada";
            this.moradaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.moradaDataGridViewTextBoxColumn.Name = "moradaDataGridViewTextBoxColumn";
            this.moradaDataGridViewTextBoxColumn.ReadOnly = true;
            this.moradaDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            this.mailDataGridViewTextBoxColumn.Width = 150;
            // 
            // codPostalDataGridViewTextBoxColumn
            // 
            this.codPostalDataGridViewTextBoxColumn.DataPropertyName = "CodPostal";
            this.codPostalDataGridViewTextBoxColumn.HeaderText = "CodPostal";
            this.codPostalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codPostalDataGridViewTextBoxColumn.Name = "codPostalDataGridViewTextBoxColumn";
            this.codPostalDataGridViewTextBoxColumn.ReadOnly = true;
            this.codPostalDataGridViewTextBoxColumn.Width = 150;
            // 
            // idEscolaDataGridViewTextBoxColumn
            // 
            this.idEscolaDataGridViewTextBoxColumn.DataPropertyName = "IdEscola";
            this.idEscolaDataGridViewTextBoxColumn.HeaderText = "IdEscola";
            this.idEscolaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idEscolaDataGridViewTextBoxColumn.Name = "idEscolaDataGridViewTextBoxColumn";
            this.idEscolaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEscolaDataGridViewTextBoxColumn.Width = 150;
            // 
            // escolasBindingSource
            // 
            this.escolasBindingSource.DataMember = "Escolas";
            this.escolasBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(117, 58);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(355, 26);
            this.tbNome.TabIndex = 1;
            // 
            // tbMorada
            // 
            this.tbMorada.Location = new System.Drawing.Point(117, 90);
            this.tbMorada.Name = "tbMorada";
            this.tbMorada.Size = new System.Drawing.Size(355, 26);
            this.tbMorada.TabIndex = 2;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(117, 122);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(355, 26);
            this.tbTelefone.TabIndex = 3;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(117, 154);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(355, 26);
            this.tbMail.TabIndex = 4;
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(117, 186);
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(355, 26);
            this.tbCodPostal.TabIndex = 5;
            // 
            // tbLocalidade
            // 
            this.tbLocalidade.Location = new System.Drawing.Point(117, 218);
            this.tbLocalidade.Name = "tbLocalidade";
            this.tbLocalidade.Size = new System.Drawing.Size(355, 26);
            this.tbLocalidade.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Morada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "CodPostal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Localidade";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbMorada);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbTelefone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbMail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCodPostal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbLocalidade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(546, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 486);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escola";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(29, 250);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(443, 50);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(29, 418);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(443, 50);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar Edição";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(29, 362);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(443, 50);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(29, 306);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(443, 50);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // escolasTableAdapter
            // 
            this.escolasTableAdapter.ClearBeforeFill = true;
            // 
            // FormGestãoEscolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 824);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGestãoEscolas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Escolas";
            this.Load += new System.EventHandler(this.FormGestãoEscolas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbMorada;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbCodPostal;
        private System.Windows.Forms.TextBox tbLocalidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource escolasBindingSource;
        private DatabaseDataSetTableAdapters.EscolasTableAdapter escolasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEscolaDataGridViewTextBoxColumn;
    }
}