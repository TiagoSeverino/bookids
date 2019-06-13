namespace Bookids
{
    partial class FormMain
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
            this.btnGestãoClientes = new System.Windows.Forms.Button();
            this.btnGestãoEscolas = new System.Windows.Forms.Button();
            this.btnGestãoEventos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestãoClientes
            // 
            this.btnGestãoClientes.Location = new System.Drawing.Point(12, 12);
            this.btnGestãoClientes.Name = "btnGestãoClientes";
            this.btnGestãoClientes.Size = new System.Drawing.Size(100, 100);
            this.btnGestãoClientes.TabIndex = 0;
            this.btnGestãoClientes.Text = "Gestão de Clientes";
            this.btnGestãoClientes.UseVisualStyleBackColor = true;
            this.btnGestãoClientes.Click += new System.EventHandler(this.BtnGestãoClientes_Click);
            // 
            // btnGestãoEscolas
            // 
            this.btnGestãoEscolas.Location = new System.Drawing.Point(118, 12);
            this.btnGestãoEscolas.Name = "btnGestãoEscolas";
            this.btnGestãoEscolas.Size = new System.Drawing.Size(100, 100);
            this.btnGestãoEscolas.TabIndex = 0;
            this.btnGestãoEscolas.Text = "Gestão de Escolas";
            this.btnGestãoEscolas.UseVisualStyleBackColor = true;
            this.btnGestãoEscolas.Click += new System.EventHandler(this.BtnGestãoEscolas_Click);
            // 
            // btnGestãoEventos
            // 
            this.btnGestãoEventos.Location = new System.Drawing.Point(224, 12);
            this.btnGestãoEventos.Name = "btnGestãoEventos";
            this.btnGestãoEventos.Size = new System.Drawing.Size(100, 100);
            this.btnGestãoEventos.TabIndex = 0;
            this.btnGestãoEventos.Text = "Gestão de Eventos";
            this.btnGestãoEventos.UseVisualStyleBackColor = true;
            this.btnGestãoEventos.Click += new System.EventHandler(this.BtnGestãoEventos_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGestãoEventos);
            this.Controls.Add(this.btnGestãoEscolas);
            this.Controls.Add(this.btnGestãoClientes);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookids";
            this.Load += new System.EventHandler(this.Bookids_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestãoClientes;
        private System.Windows.Forms.Button btnGestãoEscolas;
        private System.Windows.Forms.Button btnGestãoEventos;
    }
}