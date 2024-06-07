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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\\MSSqlLocalDB;Initial Catalog=DB_CONTROLE;Integrated Security=True");

        }
        

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frm = new frmCadastroCliente();
            frm.ShowDialog();
        }

        private void endereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEndereço frm = new frmEndereço();
            frm.ShowDialog();
        }

        private void excluirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excluir_Cliente frm = new Excluir_Cliente();
            frm.ShowDialog();
        }

        private void excluirEndereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirEndereço frm = new ExcluirEndereço();
            frm.ShowDialog();
        }
    }
}
