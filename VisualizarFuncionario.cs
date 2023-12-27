using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorEmpregados
{
    public partial class VisualizarFuncionario : Form
    {
        public VisualizarFuncionario()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GerenciadorFuncionarioDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private void BuscarDados()
        {
            Con.Open();
            string query = "select * from FuncionarioTbl where FuncId = '" + ProcurarFuncionarioIdTb.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Funcidlbl.Text = dr["Funcid"].ToString();
                Funcnomelbl.Text = dr["Funcname"].ToString();
                Funcenderecolbl.Text = dr["Funcendereco"].ToString();
                Funccargolbl.Text = dr["Funccargo"].ToString();
                Funcdoblbl.Text = dr["Funcdob"].ToString();
                Functelefonelbl.Text = dr["Functelefone"].ToString();
                Funceducacaolbl.Text = dr["Funceducacao"].ToString();
                Funcgenerolbl.Text = dr["Funcgenero"].ToString();
                Funcidlbl.Visible = true;
                Funcnomelbl.Visible = true;
                Funcenderecolbl.Visible = true;
                Funccargolbl.Visible = true;
                Funcdoblbl.Visible = true;
                Functelefonelbl.Visible = true;
                Funceducacaolbl.Visible = true;
                Funcgenerolbl.Visible = true;
            }
            Con.Close();
        }

        private void VisualizarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void VisualizarAtualizarDados_Click(object sender, EventArgs e)
        {
            BuscarDados();
        }

        private void FuncionarioParaPrincipal_Click(object sender, EventArgs e)
        {
            Principal pri = new Principal();
            pri.Show();
            Hide();
        }

        private void Printar_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("========SUMARIO DE FUNCIONARIOS========",
                new Font("Century Gothic", 20, FontStyle.Bold),
                Brushes.Blue, new Point(180));
            e.Graphics.DrawString("Funcionario ID: " + Funcidlbl + "\tFuncionarioNome" + Funcnomelbl.Text,
                 new Font("Century Gothic", 18, FontStyle.Regular),
                 Brushes.Blue, new Point(10, 100));
            e.Graphics.DrawString("Funcionario Endereco: " + Funcenderecolbl + "\tFuncionarioGenero" + Funcenderecolbl.Text,
                 new Font("Century Gothic", 18, FontStyle.Regular),
                 Brushes.Blue, new Point(10, 140));
            e.Graphics.DrawString("Funcionario Cargo: " + Funccargolbl + "\tFuncionarioDOB" + Funcdoblbl.Text,
                 new Font("Century Gothic", 18, FontStyle.Regular),
                 Brushes.Blue, new Point(10, 180));
            e.Graphics.DrawString("Funcionario Telfone: " + Functelefonelbl + "\tFuncionarioEducacao" + Funceducacaolbl.Text,
                 new Font("Century Gothic", 18, FontStyle.Regular),
                 Brushes.Blue, new Point(10, 220));
            e.Graphics.DrawString("========EMPSOFT========",
                new Font("Century Gothic", 20, FontStyle.Bold),
                Brushes.Blue, new Point(180, 280));
        }
    }
}
