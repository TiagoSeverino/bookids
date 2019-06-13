namespace Bookids
{
    partial class FormGestãoAnimadores
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
            this.especialidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Bookids.DatabaseDataSet();
            this.pessoasAnimadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.label7 = new System.Windows.Forms.Label();
            this.tbTelemovel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEspecialidade = new System.Windows.Forms.TextBox();
            this.animadoresTableAdapter = new Bookids.DatabaseDataSetTableAdapters.EscolasTableAdapter();
            this.pessoas_AnimadorTableAdapter = new Bookids.DatabaseDataSetTableAdapters.Pessoas_AnimadorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasAnimadorBindingSource)).BeginInit();
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
            this.especialidadeDataGridViewTextBoxColumn,
            this.idPessoaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.animadoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(471, 555);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // especialidadeDataGridViewTextBoxColumn
            // 
            this.especialidadeDataGridViewTextBoxColumn.DataPropertyName = "Especialidade";
            this.especialidadeDataGridViewTextBoxColumn.HeaderText = "Especialidade";
            this.especialidadeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.especialidadeDataGridViewTextBoxColumn.Name = "especialidadeDataGridViewTextBoxColumn";
            this.especialidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.especialidadeDataGridViewTextBoxColumn.Width = 150;
            // 
            // idPessoaDataGridViewTextBoxColumn
            // 
            this.idPessoaDataGridViewTextBoxColumn.DataPropertyName = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.HeaderText = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idPessoaDataGridViewTextBoxColumn.Name = "idPessoaDataGridViewTextBoxColumn";
            this.idPessoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPessoaDataGridViewTextBoxColumn.Width = 150;
            // 
            // animadoresBindingSource
            // 
            this.animadoresBindingSource.DataMember = "Pessoas_Animador";
            this.animadoresBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoasAnimadorBindingSource
            // 
            this.pessoasAnimadorBindingSource.DataMember = "Pessoas_Animador";
            this.pessoasAnimadorBindingSource.DataSource = this.databaseDataSet;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(117, 58);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(225, 26);
            this.tbNome.TabIndex = 1;
            // 
            // tbMorada
            // 
            this.tbMorada.Location = new System.Drawing.Point(117, 90);
            this.tbMorada.Name = "tbMorada";
            this.tbMorada.Size = new System.Drawing.Size(225, 26);
            this.tbMorada.TabIndex = 2;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(117, 122);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(225, 26);
            this.tbTelefone.TabIndex = 3;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(117, 186);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(225, 26);
            this.tbMail.TabIndex = 5;
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(117, 218);
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(225, 26);
            this.tbCodPostal.TabIndex = 6;
            // 
            // tbLocalidade
            // 
            this.tbLocalidade.Location = new System.Drawing.Point(117, 250);
            this.tbLocalidade.Name = "tbLocalidade";
            this.tbLocalidade.Size = new System.Drawing.Size(225, 26);
            this.tbLocalidade.TabIndex = 7;
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
            this.label4.Location = new System.Drawing.Point(25, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "CodPostal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 253);
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
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbMorada);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbTelemovel);
            this.groupBox1.Controls.Add(this.tbTelefone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbMail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCodPostal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbEspecialidade);
            this.groupBox1.Controls.Add(this.tbLocalidade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(489, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 546);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animadores";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(29, 314);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(313, 50);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(29, 482);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(313, 50);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar Edição";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(29, 426);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(313, 50);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(29, 370);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(313, 50);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Especialidade";
            // 
            // tbTelemovel
            // 
            this.tbTelemovel.Location = new System.Drawing.Point(117, 154);
            this.tbTelemovel.Name = "tbTelemovel";
            this.tbTelemovel.Size = new System.Drawing.Size(225, 26);
            this.tbTelemovel.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Telemovel";
            // 
            // tbEspecialidade
            // 
            this.tbEspecialidade.Location = new System.Drawing.Point(139, 282);
            this.tbEspecialidade.Name = "tbEspecialidade";
            this.tbEspecialidade.Size = new System.Drawing.Size(203, 26);
            this.tbEspecialidade.TabIndex = 8;
            // 
            // animadoresTableAdapter
            // 
            this.animadoresTableAdapter.ClearBeforeFill = true;
            // 
            // pessoas_AnimadorTableAdapter
            // 
            this.pessoas_AnimadorTableAdapter.ClearBeforeFill = true;
            // 
            // FormGestãoAnimadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 579);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGestãoAnimadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Animadores";
            this.Load += new System.EventHandler(this.FormGestãoAnimadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasAnimadorBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource animadoresBindingSource;
        private DatabaseDataSetTableAdapters.EscolasTableAdapter animadoresTableAdapter;
        private DatabaseDataSetTableAdapters.Pessoas_AnimadorTableAdapter pessoas_AnimadorTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEspecialidade;
        private System.Windows.Forms.TextBox tbTelemovel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pessoasAnimadorBindingSource;
    }
}