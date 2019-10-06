using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace lixoneteVersao1
{
    public class Funcionario
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public int id { get; set; }
        //OBS: Verificar se é ideal criar um objeto endereço

        public Funcionario()
        {

        }
        public Funcionario(string nome, string email, string login, string senha, string cpf, string telefone)
        {
            this.nome = nome;
            this.email = email;
            this.login = login;
            this.senha = senha;
            this.cpf = cpf;
            this.telefone = telefone;
        }
        public void CadastrarFuncionario()
        {
            NpgsqlConnection conexao = null;
            try
            {
                //usando um método estático do objeto conexao
                conexao = Conexao.getConexao();
                //Comando sql
                string sql = "INSERT INTO FUNCIONARIO (NOME, EMAIL, LOGIN, SENHA, TELEFONE, CPF)" +
                    "VALUES (@nome, @email, @login, @senha, @telefone, @cpf);";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                //especificação dos parâmetros
                cmd.Parameters.Add(new NpgsqlParameter("@nome", this.nome));
                cmd.Parameters.Add(new NpgsqlParameter("@email", this.email));
                cmd.Parameters.Add(new NpgsqlParameter("@login", this.login));
                cmd.Parameters.Add(new NpgsqlParameter("@senha", this.senha));
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
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
        }
        public bool Logar()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = Conexao.getConexao();

                string sql = "SELECT * FROM FUNCIONARIO WHERE LOGIN='"+ this.login+"' AND SENHA='" + this.senha + "' LIMIT 1;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    this.id = Convert.ToInt32(dr["idfuncionario"]);
                    if (this.login == dr["login"].ToString() && this.senha == dr["senha"].ToString())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public List<Funcionario> ListarFuncionario()
        {
            List<Funcionario> arrFuncionario = new List<Funcionario>();//Criação do objeto da classe list com objetos da classe cliente

            NpgsqlConnection con = null;
            try
            {
                con = Conexao.getConexao();

                string sql = "select nome, login, email, cpf, telefone from funcionario";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Funcionario objFuncionario = new Funcionario();
                    //objFuncionario.id = Convert.ToInt32(dr["idfuncionario"]);
                    objFuncionario.nome = dr["nome"].ToString();
                    objFuncionario.login= dr["login"].ToString();
                    objFuncionario.email = dr["email"].ToString();
                    objFuncionario.cpf = dr["cpf"].ToString();
                    objFuncionario.telefone = dr["telefone"].ToString();

                    arrFuncionario.Add(objFuncionario);
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return arrFuncionario;
        }
    }
}
