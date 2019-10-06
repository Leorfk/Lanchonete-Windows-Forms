using System;


using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lixoneteVersao1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            ItemMenuEstoque.Visible = false;
            ItemMenuCadastros.Visible = false;
            ItemMenuPedidos.Visible = false;
            ItemMenuExcluir.Visible = false;
            ItemMenuSair.Visible = false;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
        }
        private void ItemMenuAcessar_Click(object sender, EventArgs e)
        {
            FrmLogin Acessar = new FrmLogin();
            Acessar.ShowDialog();
            ItemMenuEstoque.Visible = true;
            ItemMenuCadastros.Visible = true;
            ItemMenuPedidos.Visible = true;
            ItemMenuExcluir.Visible = true;
            ItemMenuSair.Visible = true;
        }

        private void ItemMenuCadastrarProdutos_Click(object sender, EventArgs e)
        {
            FrmCadastroFornecedor Estoque = new FrmCadastroFornecedor();
            Estoque.ShowDialog();
        }
        private void ItemMenuCadastrarClientes_Click(object sender, EventArgs e)
        {
            FrmCadastroClientes Cliente = new FrmCadastroClientes();
            Cliente.ShowDialog();
        }

        private void ItemMenuCadastrarFuncionarios_Click(object sender, EventArgs e)
        {
            FrmCadastroFuncionarios Funcionario = new FrmCadastroFuncionarios();
            Funcionario.ShowDialog();
        }

        private void ItemMenuCadastrarFornecedores_Click(object sender, EventArgs e)
        {
            FrmCadastroFornecedor Fornecedor = new FrmCadastroFornecedor();
            Fornecedor.ShowDialog();
        }

        private void itemMenuEstoqueCadastrarProdutos_Click(object sender, EventArgs e)
        {
            FrmCadastroEstoqueProdutos CadastrarProdutos = new FrmCadastroEstoqueProdutos();
            CadastrarProdutos.ShowDialog();
        }

        private void ItemMenuCadastrarPedido_Click(object sender, EventArgs e)
        {
            FrmCadastrarPedido Pedidos = new FrmCadastrarPedido();
            Pedidos.ShowDialog();
        }

        private void ItemMenuExcluir_Click(object sender, EventArgs e)
        {
            FrmExclusao Excluir = new FrmExclusao();
            Excluir.ShowDialog();
        }
        private void ItemMenuSair_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Até a próxima !!!");
            Application.Exit();
        }
        private void ItemMenuExibirClientes_Click(object sender, EventArgs e)
        {
            FrmExibirClientes ExibirClientes = new FrmExibirClientes();
            ExibirClientes.ShowDialog();
        }
        private void ItemMenuExibirFuncionarios_Click(object sender, EventArgs e)
        {
            FrmExibirFuncionarios exibirFuncionarios = new FrmExibirFuncionarios();
            exibirFuncionarios.ShowDialog();
        }
        private void ItemMenuExibirFornecedores_Click(object sender, EventArgs e)
        {
            FrmExibirFornecedores exibirFornecedores = new FrmExibirFornecedores();
            exibirFornecedores.ShowDialog();
        }
    }
}
