using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace lixoneteVersao1
{
    public partial class FrmCadastroEstoqueProdutos : Form
    {
        public FrmCadastroEstoqueProdutos()
        {
            InitializeComponent();
        }
        private char RadioButton_Checked()
        {
            if(rbBebida.Checked == true)//Validação do tipo de item do radio button
            {
                return 'B';
            }
            else
            {
                return 'C';
            }
        }
        private void btnCadastroProdutoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtCadastroProdutoNotaFiscal_TextChanged(object sender, EventArgs e)
        {//Insere automaticamente o resultado na textbox
            double tot, unid;
            int quant = Convert.ToInt16(nudCadastroProdutoQuantidade.Value);
            unid = Convert.ToDouble(txtEstoqueValorUnitario.Text);
            tot = unid * quant;
            txtCadastroProdutoNotaFiscal.Text = tot.ToString();
        }     
        private void btnCadastroProdutoConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                //pega os dados das text box
                string nomeProduto = txtCadastroProdutoNome.Text;
                string descricaoProduto = txtCadastroProdutoDescricao.Text;
                int quantidadeProduto = Convert.ToInt16(nudCadastroProdutoQuantidade.Value);
                double valorUnitario = Convert.ToDouble(txtEstoqueValorUnitario.Text);
                char tipoProduto = Convert.ToChar(RadioButton_Checked());
                double valorNotaFiscal = Convert.ToDouble(txtCadastroProdutoNotaFiscal.Text);
                //Criação do objeto cliente
                Estoque objEstoque = new Estoque();
                //passagem das variáveis para os atributos
                objEstoque.nomeProduto = nomeProduto;
                objEstoque.descricao = descricaoProduto;
                objEstoque.quantidadeProduto = quantidadeProduto;
                objEstoque.valorUnitario = valorUnitario;
                objEstoque.tipoProduto = tipoProduto;
                objEstoque.valorNotaFiscal = valorNotaFiscal;

                objEstoque.cadastrarMercadorias();
                MessageBox.Show("Cadastro de produto realizado com sucesso !!!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar o cliente. " + erro.Message,
                "Falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
