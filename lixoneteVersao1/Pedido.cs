using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lixoneteVersao1
{
    class Pedido
    {
        private int id { get; set; }
        private double valorTotal { get; set; }

        public Pedido()
        {
        }
        public Pedido(double valorTotal)
        {
            this.valorTotal = valorTotal;
        }

        public void cadastrarPedido()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = Conexao.getConexao();

                string sql = "INSERT INTO PEDIDO (PRECOTOTAL) VALUES(@valor)";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.Add(new NpgsqlParameter("@valor", this.valorTotal));
            }catch (Exception erro)
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
