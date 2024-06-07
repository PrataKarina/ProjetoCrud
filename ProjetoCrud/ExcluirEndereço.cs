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
    public partial class ExcluirEndereço : Form
    {
        public ExcluirEndereço()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir permanentemente o registro?", "Controle de Estoque", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlQuery;

                SqlConnection conCliente = Conexao.getconnection();

                sqlQuery = "DELETE FROM Endereço WHERE id=@CEP";

                try
                {
                    conCliente.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);

                    string cepSemMascara = mskCEP.Text.Replace(".", "").Replace("-", "");

                    cmd.Parameters.Add(new SqlParameter("@CEP", cepSemMascara));

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas == 0)
                    {
                        MessageBox.Show("Endereço não encontrado", "Controle de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Endereço excluído com sucesso", "Controle de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problema ao excluir Endereço " + ex, "Controle de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void mskCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ExcluirEndereço_Load(object sender, EventArgs e)
        {

        }
    }
}
