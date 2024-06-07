using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoCrud
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();

        }
        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }
        private void habilitar()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = true;
            mskCPF.Enabled = true;
        }
        private void desabilitar()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mskCPF.Enabled = false;
        }

        private void limparControles()
        {
            txtNome.Clear();
            txtEmail.Clear();
            mskCPF.Clear();
            mskCPF.Focus();
        }
           
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        
    }

        private void button1_Click(object sender, EventArgs e)
        {

            string sqlQuery;

            SqlConnection conCliente = Conexao.getconnection();

            sqlQuery = "INSERT INTO Cadastro(Nome,Email,CPF) VALUES(@Nome,@Email,@CPF)";

            try
            {
                conCliente.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);

                string cpfSemMascara = mskCPF.Text.Replace(".", "").Replace("-", "").Replace(",", "");

                cmd.Parameters.Add(new SqlParameter("@Nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@Email", txtEmail.Text));
                cmd.Parameters.Add(new SqlParameter("@CPF", cpfSemMascara));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente incluído com sucesso", "Controle de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao incluir cliente " + ex, "Controle de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conCliente != null)
                {
                    conCliente.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
