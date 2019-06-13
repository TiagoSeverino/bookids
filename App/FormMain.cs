using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookids
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Bookids_Load(object sender, EventArgs e)
        {
            /*
            FormLogin fLogin = new FormLogin();
            while(!fLogin.isLoggedin)
                fLogin.ShowDialog();
            */
        }

        private void BtnGestãoClientes_Click(object sender, EventArgs e)
        {
            new FormGestãoClientes().ShowDialog();
        }

        private void BtnGestãoEscolas_Click(object sender, EventArgs e)
        {
            new FormGestãoEscolas().ShowDialog();
        }

        private void BtnGestãoEventos_Click(object sender, EventArgs e)
        {
            new FormGestãoEventos().ShowDialog();
        }

        private void BtnGestãoAnimadores_Click(object sender, EventArgs e)
        {
            new FormGestãoAnimadores().ShowDialog();
        }

        private void BtnGestãoDeProdutos_Click(object sender, EventArgs e)
        {
            new FormGestãoProdutos().ShowDialog();
        }
    }
}
