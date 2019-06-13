namespace Bookids
{
    partial class FormGestãoEventos
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
            this.descriçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limiteParticipaçõesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeInferiorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeSuperiorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Bookids.DatabaseDataSet();
            this.tbDescrição = new System.Windows.Forms.TextBox();
            this.tbLocal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmSuperior = new System.Windows.Forms.NumericUpDown();
            this.nmInferior = new System.Windows.Forms.NumericUpDown();
            this.nmLimite = new System.Windows.Forms.NumericUpDown();
            this.tbHora = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTipoEvento = new System.Windows.Forms.TextBox();
            this.eventosTableAdapter = new Bookids.DatabaseDataSetTableAdapters.EscolasTableAdapter();
            this.eventoesTableAdapter = new Bookids.DatabaseDataSetTableAdapters.EventoesTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAdicionarColaborador = new System.Windows.Forms.Button();
            this.btnRemoverColaborador = new System.Windows.Forms.Button();
            this.cbColaborações = new System.Windows.Forms.ComboBox();
            this.pessoasAnimadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colaboraçãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colaboraçãoTableAdapter = new Bookids.DatabaseDataSetTableAdapters.ColaboraçãoTableAdapter();
            this.pessoas_AnimadorTableAdapter = new Bookids.DatabaseDataSetTableAdapters.Pessoas_AnimadorTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnAdicionarEscolas = new System.Windows.Forms.Button();
            this.btnEleminarEscolas = new System.Windows.Forms.Button();
            this.cbParticipações = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btnAdicionarFilho = new System.Windows.Forms.Button();
            this.btnEliminarFilho = new System.Windows.Forms.Button();
            this.cbInscrições = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmInferior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLimite)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasAnimadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboraçãoBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriçãoDataGridViewTextBoxColumn,
            this.localDataGridViewTextBoxColumn,
            this.dataHoraDataGridViewTextBoxColumn,
            this.limiteParticipaçõesDataGridViewTextBoxColumn,
            this.idadeInferiorDataGridViewTextBoxColumn,
            this.idadeSuperiorDataGridViewTextBoxColumn,
            this.tipoEventoDataGridViewTextBoxColumn,
            this.nrEventoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eventosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(695, 492);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // descriçãoDataGridViewTextBoxColumn
            // 
            this.descriçãoDataGridViewTextBoxColumn.DataPropertyName = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriçãoDataGridViewTextBoxColumn.Name = "descriçãoDataGridViewTextBoxColumn";
            this.descriçãoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriçãoDataGridViewTextBoxColumn.Width = 150;
            // 
            // localDataGridViewTextBoxColumn
            // 
            this.localDataGridViewTextBoxColumn.DataPropertyName = "Local";
            this.localDataGridViewTextBoxColumn.HeaderText = "Local";
            this.localDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.localDataGridViewTextBoxColumn.Name = "localDataGridViewTextBoxColumn";
            this.localDataGridViewTextBoxColumn.ReadOnly = true;
            this.localDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataHoraDataGridViewTextBoxColumn
            // 
            this.dataHoraDataGridViewTextBoxColumn.DataPropertyName = "DataHora";
            this.dataHoraDataGridViewTextBoxColumn.HeaderText = "DataHora";
            this.dataHoraDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataHoraDataGridViewTextBoxColumn.Name = "dataHoraDataGridViewTextBoxColumn";
            this.dataHoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataHoraDataGridViewTextBoxColumn.Width = 150;
            // 
            // limiteParticipaçõesDataGridViewTextBoxColumn
            // 
            this.limiteParticipaçõesDataGridViewTextBoxColumn.DataPropertyName = "LimiteParticipações";
            this.limiteParticipaçõesDataGridViewTextBoxColumn.HeaderText = "LimiteParticipações";
            this.limiteParticipaçõesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.limiteParticipaçõesDataGridViewTextBoxColumn.Name = "limiteParticipaçõesDataGridViewTextBoxColumn";
            this.limiteParticipaçõesDataGridViewTextBoxColumn.ReadOnly = true;
            this.limiteParticipaçõesDataGridViewTextBoxColumn.Width = 150;
            // 
            // idadeInferiorDataGridViewTextBoxColumn
            // 
            this.idadeInferiorDataGridViewTextBoxColumn.DataPropertyName = "IdadeInferior";
            this.idadeInferiorDataGridViewTextBoxColumn.HeaderText = "IdadeInferior";
            this.idadeInferiorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idadeInferiorDataGridViewTextBoxColumn.Name = "idadeInferiorDataGridViewTextBoxColumn";
            this.idadeInferiorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idadeInferiorDataGridViewTextBoxColumn.Width = 150;
            // 
            // idadeSuperiorDataGridViewTextBoxColumn
            // 
            this.idadeSuperiorDataGridViewTextBoxColumn.DataPropertyName = "IdadeSuperior";
            this.idadeSuperiorDataGridViewTextBoxColumn.HeaderText = "IdadeSuperior";
            this.idadeSuperiorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idadeSuperiorDataGridViewTextBoxColumn.Name = "idadeSuperiorDataGridViewTextBoxColumn";
            this.idadeSuperiorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idadeSuperiorDataGridViewTextBoxColumn.Width = 150;
            // 
            // tipoEventoDataGridViewTextBoxColumn
            // 
            this.tipoEventoDataGridViewTextBoxColumn.DataPropertyName = "TipoEvento";
            this.tipoEventoDataGridViewTextBoxColumn.HeaderText = "TipoEvento";
            this.tipoEventoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tipoEventoDataGridViewTextBoxColumn.Name = "tipoEventoDataGridViewTextBoxColumn";
            this.tipoEventoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoEventoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nrEventoDataGridViewTextBoxColumn
            // 
            this.nrEventoDataGridViewTextBoxColumn.DataPropertyName = "NrEvento";
            this.nrEventoDataGridViewTextBoxColumn.HeaderText = "NrEvento";
            this.nrEventoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nrEventoDataGridViewTextBoxColumn.Name = "nrEventoDataGridViewTextBoxColumn";
            this.nrEventoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrEventoDataGridViewTextBoxColumn.Width = 150;
            // 
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataMember = "Eventoes";
            this.eventosBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbDescrição
            // 
            this.tbDescrição.Location = new System.Drawing.Point(117, 58);
            this.tbDescrição.Name = "tbDescrição";
            this.tbDescrição.Size = new System.Drawing.Size(355, 26);
            this.tbDescrição.TabIndex = 1;
            // 
            // tbLocal
            // 
            this.tbLocal.Location = new System.Drawing.Point(117, 90);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.Size = new System.Drawing.Size(355, 26);
            this.tbLocal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Local";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Idade Inferior";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Idade Superior";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmSuperior);
            this.groupBox1.Controls.Add(this.nmInferior);
            this.groupBox1.Controls.Add(this.nmLimite);
            this.groupBox1.Controls.Add(this.tbHora);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.tbDescrição);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbLocal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTipoEvento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(713, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 492);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eventos";
            // 
            // nmSuperior
            // 
            this.nmSuperior.Location = new System.Drawing.Point(145, 251);
            this.nmSuperior.Name = "nmSuperior";
            this.nmSuperior.Size = new System.Drawing.Size(327, 26);
            this.nmSuperior.TabIndex = 7;
            // 
            // nmInferior
            // 
            this.nmInferior.Location = new System.Drawing.Point(135, 219);
            this.nmInferior.Name = "nmInferior";
            this.nmInferior.Size = new System.Drawing.Size(337, 26);
            this.nmInferior.TabIndex = 6;
            // 
            // nmLimite
            // 
            this.nmLimite.Location = new System.Drawing.Point(181, 186);
            this.nmLimite.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmLimite.Name = "nmLimite";
            this.nmLimite.Size = new System.Drawing.Size(291, 26);
            this.nmLimite.TabIndex = 5;
            // 
            // tbHora
            // 
            this.tbHora.Location = new System.Drawing.Point(117, 122);
            this.tbHora.Mask = "00:00";
            this.tbHora.Name = "tbHora";
            this.tbHora.Size = new System.Drawing.Size(355, 26);
            this.tbHora.TabIndex = 3;
            this.tbHora.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(355, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(29, 314);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(443, 35);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(29, 437);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(443, 35);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar Edição";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(29, 396);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(443, 35);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(29, 355);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(443, 35);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tipo Evento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Limite Participações";
            // 
            // tbTipoEvento
            // 
            this.tbTipoEvento.Location = new System.Drawing.Point(124, 282);
            this.tbTipoEvento.Name = "tbTipoEvento";
            this.tbTipoEvento.Size = new System.Drawing.Size(348, 26);
            this.tbTipoEvento.TabIndex = 8;
            // 
            // eventosTableAdapter
            // 
            this.eventosTableAdapter.ClearBeforeFill = true;
            // 
            // eventoesTableAdapter
            // 
            this.eventoesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.btnAdicionarColaborador);
            this.groupBox2.Controls.Add(this.btnRemoverColaborador);
            this.groupBox2.Controls.Add(this.cbColaborações);
            this.groupBox2.Location = new System.Drawing.Point(12, 510);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 391);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colaborações";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 59);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(381, 216);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellClick);
            // 
            // btnAdicionarColaborador
            // 
            this.btnAdicionarColaborador.Location = new System.Drawing.Point(6, 281);
            this.btnAdicionarColaborador.Name = "btnAdicionarColaborador";
            this.btnAdicionarColaborador.Size = new System.Drawing.Size(381, 50);
            this.btnAdicionarColaborador.TabIndex = 1;
            this.btnAdicionarColaborador.Text = "Adicionar";
            this.btnAdicionarColaborador.UseVisualStyleBackColor = true;
            this.btnAdicionarColaborador.Click += new System.EventHandler(this.BtnAdicionarColaborador_Click);
            // 
            // btnRemoverColaborador
            // 
            this.btnRemoverColaborador.Location = new System.Drawing.Point(6, 337);
            this.btnRemoverColaborador.Name = "btnRemoverColaborador";
            this.btnRemoverColaborador.Size = new System.Drawing.Size(381, 50);
            this.btnRemoverColaborador.TabIndex = 1;
            this.btnRemoverColaborador.Text = "Eliminar";
            this.btnRemoverColaborador.UseVisualStyleBackColor = true;
            this.btnRemoverColaborador.Click += new System.EventHandler(this.BtnRemoverColaborador_Click);
            // 
            // cbColaborações
            // 
            this.cbColaborações.FormattingEnabled = true;
            this.cbColaborações.Location = new System.Drawing.Point(6, 25);
            this.cbColaborações.Name = "cbColaborações";
            this.cbColaborações.Size = new System.Drawing.Size(381, 28);
            this.cbColaborações.TabIndex = 0;
            // 
            // pessoasAnimadorBindingSource
            // 
            this.pessoasAnimadorBindingSource.DataMember = "Pessoas_Animador";
            this.pessoasAnimadorBindingSource.DataSource = this.databaseDataSet;
            // 
            // colaboraçãoBindingSource
            // 
            this.colaboraçãoBindingSource.DataMember = "Colaboração";
            this.colaboraçãoBindingSource.DataSource = this.databaseDataSet;
            // 
            // colaboraçãoTableAdapter
            // 
            this.colaboraçãoTableAdapter.ClearBeforeFill = true;
            // 
            // pessoas_AnimadorTableAdapter
            // 
            this.pessoas_AnimadorTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Controls.Add(this.btnAdicionarEscolas);
            this.groupBox3.Controls.Add(this.btnEleminarEscolas);
            this.groupBox3.Controls.Add(this.cbParticipações);
            this.groupBox3.Location = new System.Drawing.Point(411, 510);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 391);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Participações";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 59);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(381, 216);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellClick);
            // 
            // btnAdicionarEscolas
            // 
            this.btnAdicionarEscolas.Location = new System.Drawing.Point(6, 281);
            this.btnAdicionarEscolas.Name = "btnAdicionarEscolas";
            this.btnAdicionarEscolas.Size = new System.Drawing.Size(381, 50);
            this.btnAdicionarEscolas.TabIndex = 1;
            this.btnAdicionarEscolas.Text = "Adicionar";
            this.btnAdicionarEscolas.UseVisualStyleBackColor = true;
            this.btnAdicionarEscolas.Click += new System.EventHandler(this.BtnAdicionarEscolas_Click);
            // 
            // btnEleminarEscolas
            // 
            this.btnEleminarEscolas.Location = new System.Drawing.Point(6, 337);
            this.btnEleminarEscolas.Name = "btnEleminarEscolas";
            this.btnEleminarEscolas.Size = new System.Drawing.Size(381, 50);
            this.btnEleminarEscolas.TabIndex = 1;
            this.btnEleminarEscolas.Text = "Eliminar";
            this.btnEleminarEscolas.UseVisualStyleBackColor = true;
            this.btnEleminarEscolas.Click += new System.EventHandler(this.BtnEleminarEscolas_Click);
            // 
            // cbParticipações
            // 
            this.cbParticipações.FormattingEnabled = true;
            this.cbParticipações.Location = new System.Drawing.Point(6, 25);
            this.cbParticipações.Name = "cbParticipações";
            this.cbParticipações.Size = new System.Drawing.Size(381, 28);
            this.cbParticipações.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView4);
            this.groupBox4.Controls.Add(this.btnAdicionarFilho);
            this.groupBox4.Controls.Add(this.btnEliminarFilho);
            this.groupBox4.Controls.Add(this.cbInscrições);
            this.groupBox4.Location = new System.Drawing.Point(810, 510);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 391);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inscrições";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 59);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(381, 216);
            this.dataGridView4.TabIndex = 2;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView4_CellClick);
            // 
            // btnAdicionarFilho
            // 
            this.btnAdicionarFilho.Location = new System.Drawing.Point(6, 281);
            this.btnAdicionarFilho.Name = "btnAdicionarFilho";
            this.btnAdicionarFilho.Size = new System.Drawing.Size(381, 50);
            this.btnAdicionarFilho.TabIndex = 1;
            this.btnAdicionarFilho.Text = "Adicionar";
            this.btnAdicionarFilho.UseVisualStyleBackColor = true;
            this.btnAdicionarFilho.Click += new System.EventHandler(this.BtnAdicionarFilho_Click);
            // 
            // btnEliminarFilho
            // 
            this.btnEliminarFilho.Location = new System.Drawing.Point(6, 337);
            this.btnEliminarFilho.Name = "btnEliminarFilho";
            this.btnEliminarFilho.Size = new System.Drawing.Size(381, 50);
            this.btnEliminarFilho.TabIndex = 1;
            this.btnEliminarFilho.Text = "Eliminar";
            this.btnEliminarFilho.UseVisualStyleBackColor = true;
            this.btnEliminarFilho.Click += new System.EventHandler(this.BtnEliminarFilho_Click);
            // 
            // cbInscrições
            // 
            this.cbInscrições.FormattingEnabled = true;
            this.cbInscrições.Location = new System.Drawing.Point(6, 25);
            this.cbInscrições.Name = "cbInscrições";
            this.cbInscrições.Size = new System.Drawing.Size(381, 28);
            this.cbInscrições.TabIndex = 0;
            // 
            // FormGestãoEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 913);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGestãoEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Eventos";
            this.Load += new System.EventHandler(this.FormGestãoEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmInferior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLimite)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasAnimadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboraçãoBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbDescrição;
        private System.Windows.Forms.TextBox tbLocal;
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
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private DatabaseDataSetTableAdapters.EscolasTableAdapter eventosTableAdapter;
        private DatabaseDataSetTableAdapters.EventoesTableAdapter eventoesTableAdapter;
        private System.Windows.Forms.NumericUpDown nmLimite;
        private System.Windows.Forms.MaskedTextBox tbHora;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmSuperior;
        private System.Windows.Forms.NumericUpDown nmInferior;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTipoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limiteParticipaçõesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeInferiorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeSuperiorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdicionarColaborador;
        private System.Windows.Forms.Button btnRemoverColaborador;
        private System.Windows.Forms.ComboBox cbColaborações;
        private System.Windows.Forms.BindingSource colaboraçãoBindingSource;
        private DatabaseDataSetTableAdapters.ColaboraçãoTableAdapter colaboraçãoTableAdapter;
        private System.Windows.Forms.BindingSource pessoasAnimadorBindingSource;
        private DatabaseDataSetTableAdapters.Pessoas_AnimadorTableAdapter pessoas_AnimadorTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnAdicionarEscolas;
        private System.Windows.Forms.Button btnEleminarEscolas;
        private System.Windows.Forms.ComboBox cbParticipações;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btnAdicionarFilho;
        private System.Windows.Forms.Button btnEliminarFilho;
        private System.Windows.Forms.ComboBox cbInscrições;
    }
}