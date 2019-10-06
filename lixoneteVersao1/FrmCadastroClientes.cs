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
    public partial class FrmCadastroClientes : Form
    {
        public FrmCadastroClientes()
        {
            InitializeComponent();
        }

        private void btnCancelarCadastroCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarCadastroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //recupera os dados dos campos de texto
                string nome = txtNomeCliente.Text;
                string email = txtEmailCLiente.Text;
                string apelido = txtApelido.Text;
                string telefone = mtxtClienteTelefone.Text;
                string cpf = mtxtCPF.Text;

                //Criação do objeto cliente
                Cliente objCliente = new Cliente();
                //Passagem das variáveis para os objetos
                objCliente.nome = nome;
                objCliente.email = email;
                objCliente.apelido = apelido;
                objCliente.telefone = telefone;
                objCliente.cpf = cpf;

                //Chamada do método de cadastro
                objCliente.CadastrarCliente();
                MessageBox.Show("Cadastro realizado com sucesso");
                this.Close();
            }catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar o cliente. " + erro.Message,
                    "Falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
