using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace lixoneteVersao1
{
    class Fornecedor
    {
        private int id { get; set; }
        public string razaoSocial { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public string email { get; set; }
        public string telefoneFixo { get; set; }
        public string telefoneCelular { get; set; }

        public Fornecedor()
        {

        }
        public Fornecedor(string RazaoSocial, string nome, string cnpj, string email, string telefoneFixo, string telefoneCelular)
        {
            this.razaoSocial = razaoSocial;
            this.nome = nome;
            this.cnpj = cnpj;
            this.email = email;
            this.telefoneCelular = telefoneCelular;
            this.telefoneFixo = telefoneFixo;
        }
        public void CadastrarFornecedor()
        {
            NpgsqlConnection conexao = null;
            try
            {
                //usando um método estático do objeto conexao
                conexao = Conexao.getConexao();
                //Comando sql
                string sql = "INSERT INTO FORNECEDOR (razao_social, nome, telefone_fixo, cnpj, email, telefone_cel)" +
                    "VALUES (@razaoSocial, @nome, @telefoneFixo, @cnpj, @email, @telefoneCel);";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                //especificação dos parâmetros
                cmd.Parameters.Add(new NpgsqlParameter("@razaoSocial", this.razaoSocial));
                cmd.Parameters.Add(new NpgsqlParameter("@nome", this.nome));
                cmd.Parameters.Add(new NpgsqlParameter("@telefoneFixo", this.telefoneFixo));
                cmd.Parameters.Add(new NpgsqlParameter("@cnpj", this.cnpj));
                cmd.Parameters.Add(new NpgsqlParameter("@email", this.email));
                cmd.Parameters.Add(new NpgsqlParameter("@telefoneCel", this.telefoneCelular));
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
        public List<Fornecedor> ListarFornecedores()
        {
            List<Fornecedor> arrFornecedor = new List<Fornecedor>();//Criação do objeto da classe list com objetos da classe cliente

            NpgsqlConnection con = null;
            try
            {
                con = Conexao.getConexao();

                string sql = "select razao_social, nome, telefone_fixo, telefone_cel, email, cnpj from fornecedor";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Fornecedor objFornecedor = new Fornecedor();

                    //objFornecedor.id = Convert.ToInt32(dr["idfornecedor"]);
                    objFornecedor.razaoSocial = dr["razao_social"].ToString();
                    objFornecedor.nome = dr["nome"].ToString();
                    objFornecedor.telefoneFixo = dr["telefone_fixo"].ToString();
                    objFornecedor.telefoneCelular = dr["telefone_cel"].ToString();
                    objFornecedor.email= dr["email"].ToString();
                    objFornecedor.cnpj = dr["cnpj"].ToString();

                    arrFornecedor.Add(objFornecedor);
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
            return arrFornecedor;
        }
    }
}
