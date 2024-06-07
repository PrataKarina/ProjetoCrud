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
    public partial class Excluir_Cliente : Form
    {
        public Excluir_Cliente()
        {
            InitializeComponent();
        }
            private void button2_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Deseja excluir permanentemente o registro?", "Controle de Estoque", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sqlQuery;

                    SqlConnection conCliente = Conexao.getconnection();

                    sqlQuery = "DELETE FROM CADASTRO WHERE ID_CLIENTE=@CPF";

                    try
                    {
                        conCliente.Open();
                        SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);

                        string cpfSemMascara = mskCPF.Text.Replace(".", "").Replace("-", "");

                        cmd.Parameters.Add(new SqlParameter("@CPF", cpfSemMascara));

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if(linhasAfetadas == 0)
                        {
                            MessageBox.Show("Cliente não encontrado", "Controle de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Cliente excluído com sucesso", "Controle de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problema ao excluir cliente " + ex, "Controle de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        if (conCliente != null)
                        {
                            conCliente.Close();
                        }
                    }

                }
            }

            private void button4_Click(object sender, EventArgs e)
            {
                this.Close();
            }



            private void Excluir_Cliente_Load(object sender, EventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

