using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GerenciadorEmpregados
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GerenciadorFuncionarioDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private void FuncAdicionar_Click(object sender, EventArgs e)
        {
            if (FuncIdTb.Text == "" || FuncNomeTb.Text == "" || FuncTelefoneTb.Text == "" ||
                FuncEnderecoTb.Text == "")
            {
                MessageBox.Show("Informação Invalida!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into FuncionarioTbl values('" + FuncIdTb.Text + "', '" + FuncNomeTb.Text + "', '" + FuncEnderecoTb.Text + "', '" + FuncCargoCb.SelectedItem.ToString() + "', " +
                        "'" + FuncDob.Value.Date + "', '" + FuncEnderecoTb.Text + "', '" + FuncEducacaoCb.SelectedItem.ToString() + "', '" + FuncGeneroCb.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionario Registrado com Sucesso!!!");
                    Con.Close();
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FuncSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Populate()
        {
            Con.Open();
            string query = "select * from FuncionarioTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FuncDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void FuncDeletar_Click(object sender, EventArgs e)
        {
            if (FuncIdTb.Text == "")
            {
                MessageBox.Show("Enter com Id do Funcionário");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from FuncinarioTbl where FuncId = '" + FuncIdTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionario Deletado com Sucesso!!");
                    Con.Close();
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FuncDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FuncIdTb.Text = FuncDGV.SelectedRows[0].Cells[0].Value.ToString();
            FuncNomeTb.Text = FuncDGV.SelectedRows[0].Cells[1].Value.ToString();
            FuncEnderecoTb.Text = FuncDGV.SelectedRows[0].Cells[2].Value.ToString();
            FuncGeneroCb.Text = FuncDGV.SelectedRows[0].Cells[3].Value.ToString();
            FuncCargoCb.Text = FuncDGV.SelectedRows[0].Cells[4].Value.ToString();
            FuncTelefoneTb.Text = FuncDGV.SelectedRows[0].Cells[5].Value.ToString();
            FuncEducacaoCb.Text = FuncDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void FuncEditar_Click(object sender, EventArgs e)
        {
            if (FuncIdTb.Text == "" || FuncNomeTb.Text == "" || FuncTelefoneTb.Text == "" ||
                    FuncEnderecoTb.Text == "")
            {
                MessageBox.Show("Informação Invalida!!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update into FuncionarioTbl set FuncId = '" + FuncIdTb.Text + "', FuncName =  '" + FuncNomeTb.Text + "', FuncEndereco = '" + FuncEnderecoTb.Text + "', " +
                        " FuncCargo = '" + FuncCargoCb.SelectedItem.ToString() + "', " + " FuncDOB '" + FuncDob.Value.Date + "', " +
                        " FuncTelefone = '" + FuncTelefoneTb.Text + "', FuncEducacao = '" + FuncEducacaoCb.SelectedItem.ToString() + "', FuncGenero = '" + FuncGeneroCb.SelectedItem.ToString() + "'" +
                        " where FuncId = '" + FuncIdTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionario Atualizado com Sucesso!!!");
                    Con.Close();
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FuncionarioParaPrincipal_Click(object sender, EventArgs e)
        {
            Principal pri = new Principal();
            pri.Show();
            Hide();
        }


    }
}
