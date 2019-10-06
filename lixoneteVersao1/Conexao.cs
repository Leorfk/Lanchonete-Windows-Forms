using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lixoneteVersao1
{
    class Conexao
    {
        //Configuração da conexão com o banco de dados
        private static string serverName = "localhost";
        private static string porta = "5432";
        private static string userName = "postgres";
        private static string password = "";
        private static string databaseName = "lanchonete";

        public static NpgsqlConnection getConexao()
        {
            try
            {
                string con = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4}",
                    serverName, porta, userName, password, databaseName);
                NpgsqlConnection OscarAlho = new NpgsqlConnection(con);

                OscarAlho.Open();

                return OscarAlho;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}
