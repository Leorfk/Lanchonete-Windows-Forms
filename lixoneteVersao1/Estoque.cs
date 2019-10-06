using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lixoneteVersao1
{
    class Estoque
    {
        private int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public string descricao { get; set; }
        public int quantidadeProduto { get; set; }
        public double valorUnitario { get; set; }
        public double valorNotaFiscal { get; set; }
        public char tipoProduto { get; set; }

        public Estoque()
        {

        }
        public Estoque(string nomeProduto, string descricao, int quantidadeProduto, double valorUnitario, double valorNotaFiscal)
        {
            this.nomeProduto = nomeProduto;
            this.descricao = descricao;
            this.quantidadeProduto = quantidadeProduto;
            this.valorUnitario = valorUnitario;
            this.valorNotaFiscal = valorNotaFiscal;
            this.tipoProduto = tipoProduto;
        }
        public void cadastrarMercadorias()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = Conexao.getConexao();

                string sql = "INSERT INTO ESTOQUE(nome, descricao, quantidade, tipo, valor_unitario, valor_nota)" +
                    "values(@nome, @descricao, @quantidade, @tipoProduto, @valorUnitario, @valorNota)";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);//cmd recebe todos os parâmteros tanto da query qunato da conexao
                //passagem dos parâmetros
                cmd.Parameters.Add(new NpgsqlParameter("@nome", this.nomeProduto));
                cmd.Parameters.Add(new NpgsqlParameter("@descricao", this.descricao));
                cmd.Parameters.Add(new NpgsqlParameter("@quantidade",this.quantidadeProduto));
                cmd.Parameters.Add(new NpgsqlParameter("@valorUnitario",this.valorUnitario));
                cmd.Parameters.Add(new NpgsqlParameter("@valorNota",this.valorNotaFiscal));
                cmd.Parameters.Add(new NpgsqlParameter("@tipoProduto", this.tipoProduto));
                cmd.ExecuteNonQuery();//roda a query para armazenar os registros
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
    }
}
