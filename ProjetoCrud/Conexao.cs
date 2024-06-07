using System.Data.SqlClient;

namespace ProjetoCrud
{
    public class Conexao
    {
        public static SqlConnection getconnection()
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSqlLocalDB;Initial Catalog=DB_CONTROLE;Integrated Security=True");
            return cnn;
        }
      
    }
}


