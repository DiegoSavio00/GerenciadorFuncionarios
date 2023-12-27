using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GerenciadorEmpregados
{
    public partial class Salario : Form
    {
        public Salario()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GerenciadorFuncionarioDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private void SalarioParaPrincipal_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            Hide();
        }

        private void BuscarDados()
        {
            if (FuncIdTb.Text == "")
            {
                MessageBox.Show("Entre com o Id");
            }
            else
            {
                Con.Open();
                string query = "select * from FuncionarioTbl where FuncId = '" + FuncIdTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    FuncNomeTb.Text = dr["Funcnome"].ToString();
                    FuncCargoCb.Text = dr["Funccargo"].ToString();
                }
                Con.Close();
            }
        }

        private void Salario_Load(object sender, EventArgs e)
        {

        }

        private void BuscarFuncionario_Click(object sender, EventArgs e)
        {
            BuscarDados();
        }

        int Diaria = 0;
        int Total = 0;
        private void SalarioParaVisualizar_Click(object sender, EventArgs e)
        {
            if (FuncCargoCb.Text == "")
            {
                MessageBox.Show("Selecione um Funcionario");
            }
            else if (DiasTrabalhadosTb.Text == "" || Convert.ToInt32(DiasTrabalhadosTb.Text) > 28)
            {
                MessageBox.Show("Entre com um Dia Valido.");
            }
            else
            {
                if (FuncCargoCb.Text == "Gerente")
                {
                    Diaria = 1200;
                }
                else if (FuncCargoCb.Text == "Dev Senior")
                {
                    Diaria = 1000;
                }
                else if (FuncCargoCb.Text == "Dev Junior")
                {
                    Diaria = 950;
                }
                else
                {
                    Diaria = 800;
                }
                Total += Diaria * Convert.ToInt32(DiasTrabalhadosTb.Text);
                SalarioSlip.Text = " FuncionarioId: " + FuncIdTb.Text + "\n" + "FuncionarioNome: " + FuncNomeTb.Text + "\n" + "FuncionarioCargo: " + FuncCargoCb.Text + "\n"
                    + "\n" + "DiasTrabalhados: " + DiasTrabalhadosTb.Text + "\n" + "Diaria: " + Diaria + "\n" + "Total Amount R$: " + Total + "\n";
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("========RESUMO DO SALARIO========",
                new Font("Century Gothic", 20, FontStyle.Bold),
                Brushes.Blue, new Point(180));
            e.Graphics.DrawString("Funcionario ID: " + FuncIdTb.Text,
                 new Font("Century Gothic", 18, FontStyle.Regular),
                 Brushes.Blue, new Point(20, 100));
            //e.Graphics.DrawString("Funcionario Endereco: ",
            //     new Font("Century Gothic", 18, FontStyle.Regular),
            //     Brushes.Blue, new Point(10, 140));
            e.Graphics.DrawString("Funcionario Cargo: " + FuncCargoCb.Text,
                 new Font("Century Gothic", 18, FontStyle.Regular),
                 Brushes.Blue, new Point(20, 140));
            e.Graphics.DrawString("Dias Trabalhados: " + DiasTrabalhadosTb.Text,
                 new Font("Century Gothic", 18, FontStyle.Regular),
                 Brushes.Blue, new Point(20, 180));
            e.Graphics.DrawString("Diario: " + Diaria,
                 new Font("Century Gothic", 18, FontStyle.Regular),
                 Brushes.Blue, new Point(10, 220));
            e.Graphics.DrawString("Salario Total: " + Total,
                 new Font("Century Gothic", 18, FontStyle.Regular),
                 Brushes.Blue, new Point(10, 26));
            e.Graphics.DrawString("========EMPSOFT========",
                new Font("Century Gothic", 20, FontStyle.Bold),
                Brushes.Blue, new Point(180, 300));
        }
    }
}
