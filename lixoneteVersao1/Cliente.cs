using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace lixoneteVersao1
{
    public class Cliente
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string apelido { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public int id { get; set; }

        public Cliente()
        {

        }
        public Cliente(string nome, string email, string apelido, string cpf, string telefone)
        {
            this.nome = nome;
            this.email = email;
            this.apelido = apelido;
            this.cpf = cpf;
            this.telefone = telefone;
        }
        public void CadastrarCliente()
        {
            NpgsqlConnection conexao = null;
            try
            {
                //usando um método estático do objeto conexao
                conexao = Conexao.getConexao();
                //Comando sql
                string sql = "INSERT INTO CLIENTE (NOME, EMAIL, APELIDO, TELEFONE, CPF)" +
                    "VALUES (@nome, @email, @apelido, @telefone, @cpf);";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                //especificação dos parâmetros
                cmd.Parameters.Add(new NpgsqlParameter("@nome", this.nome));
                cmd.Parameters.Add(new NpgsqlParameter("@email", this.email));
                cmd.Parameters.Add(new NpgsqlParameter("@apelido", this.apelido));
                cmd.Parameters.Add(new NpgsqlParameter("@telefone", this.telefone));
                cmd.Parameters.Add(new NpgsqlParameter("@cpf", this.cpf));
                cmd.ExecuteNonQuery();//Executa o comando sql
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                if(conexao != null)
                {
                    conexao.Close();
                }
            }
        }
        public List<Cliente> ListarClientes()
        {
            List<Cliente> arrCliente = new List<Cliente>();//Criação do objeto da classe list com objetos da classe cliente

            NpgsqlConnection con = null;
            try
            {
                con = Conexao.getConexao();

                string sql = "select nome, apelido, email, cpf, telefone from cliente";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cliente objCliente = new Cliente();
                    //objCliente.id = Convert.ToInt32(dr["idcliente"]);
                    objCliente.nome = dr["nome"].ToString();
                    objCliente.apelido = dr["apelido"].ToString();
                    objCliente.email = dr["email"].ToString();
                    objCliente.cpf = dr["cpf"].ToString();
                    objCliente.telefone = dr["telefone"].ToString();

                    arrCliente.Add(objCliente);
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                if(con != null)
                {
                    con.Close();
                }
            }
            return arrCliente;
        }
    }
}
