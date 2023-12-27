using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorEmpregados
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsuarioIdTb.Text == "" || SenhaTb.Text == "")
            {
                MessageBox.Show("Entre com Nome do Usuario e Senha do Usuario");
            }
            else if (UsuarioIdTb.Text == "Admin" && SenhaTb.Text == "Admin123")
            {
                Hide();
                Principal pri = new Principal();
                pri.Show();
            }
            else
            {
                MessageBox.Show("Nome do Usuario ou Senha Errados!!");
            }
        }
    }
}
