using System;
using System.Data.SqlClient; // Include this for SqlConnection
using System.Windows.Forms;

namespace ProjetoCrud
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GetConnection();

            Application.Run(new Form1());
        }

        static void GetConnection()
        {
            string connectionString = @"Data Source=(localdb)\MSSqlLocalDB;Initial Catalog=DB_CONTROLE;Integrated Security=True";

            // Criando a conexão
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrindo a conexão
                    connection.Open();
                    Console.WriteLine("Conexão aberta com sucesso!");

                    // Executando um comando SQL
                    string query = "SELECT COUNT(*) FROM CADASTRO"; // Exemplo de query
                    SqlCommand command = new SqlCommand(query, connection);
                    int count = (int)command.ExecuteScalar();

                    Console.WriteLine($"Número de registros na tabela: {count}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao abrir a conexão: " + ex.Message);
                }
            }

            Console.WriteLine("Conexão fechada.");
        }
    }
}
