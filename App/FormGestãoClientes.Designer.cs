namespace Bookids
{
    partial class FormGestãoClientes
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
            this.pessoasClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Bookids.DatabaseDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMorada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTelemovel = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodPostal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNrCartao = new System.Windows.Forms.TextBox();
            this.tbOferta = new System.Windows.Forms.TextBox();
            this.tbLocalidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pessoasFilhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuardar1 = new System.Windows.Forms.Button();
            this.btnEleminar1 = new System.Windows.Forms.Button();
            this.btnCancelar1 = new System.Windows.Forms.Button();
            this.btnAdicionar1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.escolasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rFeminino = new System.Windows.Forms.RadioButton();
            this.rMasculino = new System.Windows.Forms.RadioButton();
            this.tbNome1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMorada1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTelemovel1 = new System.Windows.Forms.TextBox();
            this.tbTelefone1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbMail1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbCodPostal1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbLocalidade1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pessoas_ClienteTableAdapter = new Bookids.DatabaseDataSetTableAdapters.Pessoas_ClienteTableAdapter();
            this.pessoas_FilhoTableAdapter = new Bookids.DatabaseDataSetTableAdapters.Pessoas_FilhoTableAdapter();
            this.escolasTableAdapter = new Bookids.DatabaseDataSetTableAdapters.EscolasTableAdapter();
            this.idPessoaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIdPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escolaIdEscolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorOfertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCartaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasFilhoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escolasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoaDataGridViewTextBoxColumn,
            this.valorOfertaDataGridViewTextBoxColumn,
            this.nrCartaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pessoasClienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(768, 624);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // pessoasClienteBindingSource
            // 
            this.pessoasClienteBindingSource.DataMember = "Pessoas_Cliente";
            this.pessoasClienteBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbMorada);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbTelemovel);
            this.groupBox1.Controls.Add(this.tbTelefone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbMail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCodPostal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNrCartao);
            this.groupBox1.Controls.Add(this.tbOferta);
            this.groupBox1.Controls.Add(this.tbLocalidade);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(792, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 624);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(117, 25);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(355, 26);
            this.tbNome.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Numero Cartao";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor Oferta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Localidade";
            // 
            // tbMorada
            // 
            this.tbMorada.Location = new System.Drawing.Point(117, 57);
            this.tbMorada.Name = "tbMorada";
            this.tbMorada.Size = new System.Drawing.Size(355, 26);
            this.tbMorada.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "CodPostal";
            // 
            // tbTelemovel
            // 
            this.tbTelemovel.Location = new System.Drawing.Point(117, 121);
            this.tbTelemovel.Name = "tbTelemovel";
            this.tbTelemovel.Size = new System.Drawing.Size(355, 26);
            this.tbTelemovel.TabIndex = 7;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(117, 89);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(355, 26);
            this.tbTelefone.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Telemovel";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(117, 153);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(355, 26);
            this.tbMail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefone";
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(117, 185);
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.Size = new System.Drawing.Size(355, 26);
            this.tbCodPostal.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Morada";
            // 
            // tbNrCartao
            // 
            this.tbNrCartao.Location = new System.Drawing.Point(148, 281);
            this.tbNrCartao.Name = "tbNrCartao";
            this.tbNrCartao.Size = new System.Drawing.Size(324, 26);
            this.tbNrCartao.TabIndex = 11;
            // 
            // tbOferta
            // 
            this.tbOferta.Location = new System.Drawing.Point(139, 249);
            this.tbOferta.Name = "tbOferta";
            this.tbOferta.Size = new System.Drawing.Size(333, 26);
            this.tbOferta.TabIndex = 11;
            // 
            // tbLocalidade
            // 
            this.tbLocalidade.Location = new System.Drawing.Point(117, 217);
            this.tbLocalidade.Name = "tbLocalidade";
            this.tbLocalidade.Size = new System.Drawing.Size(355, 26);
            this.tbLocalidade.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nome";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(29, 400);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(443, 50);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(29, 568);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(443, 50);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar Edição";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(29, 512);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(443, 50);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(29, 456);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(443, 50);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoaDataGridViewTextBoxColumn1,
            this.sexoDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.clienteIdPessoaDataGridViewTextBoxColumn,
            this.escolaIdEscolaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.pessoasFilhoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1792, 15);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(490, 621);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // pessoasFilhoBindingSource
            // 
            this.pessoasFilhoBindingSource.DataMember = "Pessoas_Filho";
            this.pessoasFilhoBindingSource.DataSource = this.databaseDataSet;
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.Location = new System.Drawing.Point(20, 453);
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(443, 50);
            this.btnGuardar1.TabIndex = 4;
            this.btnGuardar1.Text = "Guardar";
            this.btnGuardar1.UseVisualStyleBackColor = true;
            this.btnGuardar1.Click += new System.EventHandler(this.BtnGuardar1_Click);
            // 
            // btnEleminar1
            // 
            this.btnEleminar1.Location = new System.Drawing.Point(20, 509);
            this.btnEleminar1.Name = "btnEleminar1";
            this.btnEleminar1.Size = new System.Drawing.Size(443, 50);
            this.btnEleminar1.TabIndex = 4;
            this.btnEleminar1.Text = "Eliminar";
            this.btnEleminar1.UseVisualStyleBackColor = true;
            this.btnEleminar1.Click += new System.EventHandler(this.BtnEleminar1_Click);
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.Location = new System.Drawing.Point(20, 565);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new System.Drawing.Size(443, 50);
            this.btnCancelar1.TabIndex = 4;
            this.btnCancelar1.Text = "Cancelar Edição";
            this.btnCancelar1.UseVisualStyleBackColor = true;
            this.btnCancelar1.Click += new System.EventHandler(this.BtnCancelar1_Click);
            // 
            // btnAdicionar1
            // 
            this.btnAdicionar1.Location = new System.Drawing.Point(20, 397);
            this.btnAdicionar1.Name = "btnAdicionar1";
            this.btnAdicionar1.Size = new System.Drawing.Size(443, 50);
            this.btnAdicionar1.TabIndex = 4;
            this.btnAdicionar1.Text = "Adicionar";
            this.btnAdicionar1.UseVisualStyleBackColor = true;
            this.btnAdicionar1.Click += new System.EventHandler(this.BtnAdicionar1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.rFeminino);
            this.groupBox2.Controls.Add(this.rMasculino);
            this.groupBox2.Controls.Add(this.tbNome1);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbMorada1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbTelemovel1);
            this.groupBox2.Controls.Add(this.tbTelefone1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbMail1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tbCodPostal1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tbLocalidade1);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.btnAdicionar1);
            this.groupBox2.Controls.Add(this.btnCancelar1);
            this.groupBox2.Controls.Add(this.btnEleminar1);
            this.groupBox2.Controls.Add(this.btnGuardar1);
            this.groupBox2.Location = new System.Drawing.Point(1292, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 621);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filhos";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.escolasBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(80, 342);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(383, 28);
            this.comboBox2.TabIndex = 39;
            this.comboBox2.ValueMember = "IdEscola";
            // 
            // escolasBindingSource
            // 
            this.escolasBindingSource.DataMember = "Escolas";
            this.escolasBindingSource.DataSource = this.databaseDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pessoasClienteBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 308);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(383, 28);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.ValueMember = "IdPessoa";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 276);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 26);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // rFeminino
            // 
            this.rFeminino.AutoSize = true;
            this.rFeminino.Location = new System.Drawing.Point(219, 248);
            this.rFeminino.Name = "rFeminino";
            this.rFeminino.Size = new System.Drawing.Size(99, 24);
            this.rFeminino.TabIndex = 36;
            this.rFeminino.TabStop = true;
            this.rFeminino.Text = "Feminino";
            this.rFeminino.UseVisualStyleBackColor = true;
            // 
            // rMasculino
            // 
            this.rMasculino.AutoSize = true;
            this.rMasculino.Location = new System.Drawing.Point(108, 249);
            this.rMasculino.Name = "rMasculino";
            this.rMasculino.Size = new System.Drawing.Size(105, 24);
            this.rMasculino.TabIndex = 35;
            this.rMasculino.TabStop = true;
            this.rMasculino.Text = "Masculino";
            this.rMasculino.UseVisualStyleBackColor = true;
            // 
            // tbNome1
            // 
            this.tbNome1.Location = new System.Drawing.Point(108, 22);
            this.tbNome1.Name = "tbNome1";
            this.tbNome1.Size = new System.Drawing.Size(355, 26);
            this.tbNome1.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 345);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 20);
            this.label20.TabIndex = 28;
            this.label20.Text = "Escola";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 311);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 20);
            this.label19.TabIndex = 28;
            this.label19.Text = "Cliente";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 281);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 20);
            this.label18.TabIndex = 28;
            this.label18.Text = "Data Nascimento";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 251);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "Sexo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Localidade";
            // 
            // tbMorada1
            // 
            this.tbMorada1.Location = new System.Drawing.Point(108, 54);
            this.tbMorada1.Name = "tbMorada1";
            this.tbMorada1.Size = new System.Drawing.Size(355, 26);
            this.tbMorada1.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "CodPostal";
            // 
            // tbTelemovel1
            // 
            this.tbTelemovel1.Location = new System.Drawing.Point(108, 118);
            this.tbTelemovel1.Name = "tbTelemovel1";
            this.tbTelemovel1.Size = new System.Drawing.Size(355, 26);
            this.tbTelemovel1.TabIndex = 23;
            // 
            // tbTelefone1
            // 
            this.tbTelefone1.Location = new System.Drawing.Point(108, 86);
            this.tbTelefone1.Name = "tbTelefone1";
            this.tbTelefone1.Size = new System.Drawing.Size(355, 26);
            this.tbTelefone1.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Mail";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Telemovel";
            // 
            // tbMail1
            // 
            this.tbMail1.Location = new System.Drawing.Point(108, 150);
            this.tbMail1.Name = "tbMail1";
            this.tbMail1.Size = new System.Drawing.Size(355, 26);
            this.tbMail1.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "Telefone";
            // 
            // tbCodPostal1
            // 
            this.tbCodPostal1.Location = new System.Drawing.Point(108, 182);
            this.tbCodPostal1.Name = "tbCodPostal1";
            this.tbCodPostal1.Size = new System.Drawing.Size(355, 26);
            this.tbCodPostal1.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "Morada";
            // 
            // tbLocalidade1
            // 
            this.tbLocalidade1.Location = new System.Drawing.Point(108, 214);
            this.tbLocalidade1.Name = "tbLocalidade1";
            this.tbLocalidade1.Size = new System.Drawing.Size(355, 26);
            this.tbLocalidade1.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "Nome";
            // 
            // pessoas_ClienteTableAdapter
            // 
            this.pessoas_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // pessoas_FilhoTableAdapter
            // 
            this.pessoas_FilhoTableAdapter.ClearBeforeFill = true;
            // 
            // escolasTableAdapter
            // 
            this.escolasTableAdapter.ClearBeforeFill = true;
            // 
            // idPessoaDataGridViewTextBoxColumn1
            // 
            this.idPessoaDataGridViewTextBoxColumn1.DataPropertyName = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn1.HeaderText = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idPessoaDataGridViewTextBoxColumn1.Name = "idPessoaDataGridViewTextBoxColumn1";
            this.idPessoaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idPessoaDataGridViewTextBoxColumn1.Width = 150;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataNascimentoDataGridViewTextBoxColumn.Width = 150;
            // 
            // clienteIdPessoaDataGridViewTextBoxColumn
            // 
            this.clienteIdPessoaDataGridViewTextBoxColumn.DataPropertyName = "ClienteIdPessoa";
            this.clienteIdPessoaDataGridViewTextBoxColumn.HeaderText = "ClienteIdPessoa";
            this.clienteIdPessoaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.clienteIdPessoaDataGridViewTextBoxColumn.Name = "clienteIdPessoaDataGridViewTextBoxColumn";
            this.clienteIdPessoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteIdPessoaDataGridViewTextBoxColumn.Width = 150;
            // 
            // escolaIdEscolaDataGridViewTextBoxColumn
            // 
            this.escolaIdEscolaDataGridViewTextBoxColumn.DataPropertyName = "EscolaIdEscola";
            this.escolaIdEscolaDataGridViewTextBoxColumn.HeaderText = "EscolaIdEscola";
            this.escolaIdEscolaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.escolaIdEscolaDataGridViewTextBoxColumn.Name = "escolaIdEscolaDataGridViewTextBoxColumn";
            this.escolaIdEscolaDataGridViewTextBoxColumn.ReadOnly = true;
            this.escolaIdEscolaDataGridViewTextBoxColumn.Width = 150;
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
            // valorOfertaDataGridViewTextBoxColumn
            // 
            this.valorOfertaDataGridViewTextBoxColumn.DataPropertyName = "ValorOferta";
            this.valorOfertaDataGridViewTextBoxColumn.HeaderText = "ValorOferta";
            this.valorOfertaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.valorOfertaDataGridViewTextBoxColumn.Name = "valorOfertaDataGridViewTextBoxColumn";
            this.valorOfertaDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorOfertaDataGridViewTextBoxColumn.Width = 150;
            // 
            // nrCartaoDataGridViewTextBoxColumn
            // 
            this.nrCartaoDataGridViewTextBoxColumn.DataPropertyName = "NrCartao";
            this.nrCartaoDataGridViewTextBoxColumn.HeaderText = "NrCartao";
            this.nrCartaoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nrCartaoDataGridViewTextBoxColumn.Name = "nrCartaoDataGridViewTextBoxColumn";
            this.nrCartaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrCartaoDataGridViewTextBoxColumn.Width = 150;
            // 
            // FormGestãoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2294, 648);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGestãoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Clientes";
            this.Load += new System.EventHandler(this.FormGestãoEscolas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasFilhoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escolasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnGuardar1;
        private System.Windows.Forms.Button btnEleminar1;
        private System.Windows.Forms.Button btnCancelar1;
        private System.Windows.Forms.Button btnAdicionar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource pessoasClienteBindingSource;
        private DatabaseDataSetTableAdapters.Pessoas_ClienteTableAdapter pessoas_ClienteTableAdapter;
        private System.Windows.Forms.BindingSource pessoasFilhoBindingSource;
        private DatabaseDataSetTableAdapters.Pessoas_FilhoTableAdapter pessoas_FilhoTableAdapter;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMorada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTelemovel;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodPostal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOferta;
        private System.Windows.Forms.TextBox tbLocalidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNrCartao;
        private System.Windows.Forms.TextBox tbNome1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMorada1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTelemovel1;
        private System.Windows.Forms.TextBox tbTelefone1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbMail1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbCodPostal1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbLocalidade1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rFeminino;
        private System.Windows.Forms.RadioButton rMasculino;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.BindingSource escolasBindingSource;
        private DatabaseDataSetTableAdapters.EscolasTableAdapter escolasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorOfertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCartaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIdPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn escolaIdEscolaDataGridViewTextBoxColumn;
    }
}