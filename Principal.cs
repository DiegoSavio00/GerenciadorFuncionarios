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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void PrincipalParaFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario fun = new Funcionario();
            fun.Show();
            Hide();
        }

        // As PictureBox's também podem ir para tela Funcionario, Visuailizar e Salario!!

        private void Deslogar_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }

        private void PrincipalParaVisualizar_Click(object sender, EventArgs e)
        {
            VisualizarFuncionario vf = new VisualizarFuncionario();
            vf.Show();
            Hide();
        }

        private void PrincipalParaSalario_Click(object sender, EventArgs e)
        {
            Salario sl = new Salario();
            sl.Show();
            Hide();
        }
    }
}
