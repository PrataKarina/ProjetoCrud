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

namespace ProjetoCrud
{
    public partial class frmEndereço : Form
    {
        public frmEndereço()
        {
            InitializeComponent();
        }
        private void txtEndereço_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void habilitar()
        {
            txtEndereço.Enabled = false;
            txtBairro.Enabled = true;
            mskCEP.Enabled = true;
        }
        private void desabilitar()
        {
            txtEndereço.Enabled = false;
            txtBairro.Enabled = false;
            mskCEP.Enabled = false;
        }

        private void limparControles()
        {
            txtEndereço.Clear();
            txtBairro.Clear();
            mskCEP.Clear();
            mskCEP.Focus();
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

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            string sqlQuery;

            SqlConnection conCliente = Conexao.getconnection();

            sqlQuery = "INSERT INTO Endereço(Endereço,Bairro,CEP) VALUES(@Endereço,@Bairro,@CEP)";

            try
            {
                conCliente.Open();

                SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);

                string cepSemMascara = mskCEP.Text.Replace(".", "").Replace("-", "");

                cmd.Parameters.Add(new SqlParameter("@Endereço", txtEndereço.Text));
                cmd.Parameters.Add(new SqlParameter("@Bairro", txtBairro.Text));
                cmd.Parameters.Add(new SqlParameter("@CEP", cepSemMascara));


                cmd.ExecuteNonQuery();

                MessageBox.Show("Endereço incluído com sucesso", "Controle de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao incluir Endereço " + ex, "Controle de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conCliente != null)
                {
                    conCliente.Close();
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
       

        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmEndereço_Load(object sender, EventArgs e)
        {

        }
    }
}
