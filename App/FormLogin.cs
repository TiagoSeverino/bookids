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
    public partial class FormLogin : Form
    {
        public bool isLoggedin;
        private ModelContainer modelContainer;
        public FormLogin()
        {
            InitializeComponent();

            modelContainer = new ModelContainer();
            isLoggedin = false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var users = from user in modelContainer.Users
                       where user.Nome == tbNome.Text && user.Pass == tbPass.Text
                       select user;

            if (users.Any())
            {
                this.isLoggedin = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Invalido", "Conta não encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
