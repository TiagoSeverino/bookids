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

namespace Bookids
{
    public partial class FormMain : Form
    {

        private ModelContainer modelContainer;
        public FormMain()
        {
            InitializeComponent();

            modelContainer = new ModelContainer();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var test = from user in modelContainer.Users
                        where user.Nome == tbNome.Text && user.Pass == tbPass.Text
                       select user;
            if (test.Any())
            {
                MessageBox.Show("Login Válido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Login Invalido", "Conta não encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
