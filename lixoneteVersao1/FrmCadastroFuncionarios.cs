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
    public partial class FrmCadastroFuncionarios : Form
    {
        public FrmCadastroFuncionarios()
        {
            InitializeComponent();
        }

        private void btnCancelarCadastroFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarCadastroFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                //pega os dados das caixas de texto
                string nome = txtNomeFuncionario.Text;
                string email = txtEmailFuncionario.Text;
                string login = txtLoginDeAcesso.Text;
                string senha = txtSenhaFuncionario.Text;
                string cpf = mtxtCPFFuncionario.Text;
                string telefone = mtxtTelefoneFuncionario.Text;

                //objeto funcionario
                Funcionario objFuncionario = new Funcionario();

                objFuncionario.nome = nome;
                objFuncionario.email = email;
                objFuncionario.login = login;
                objFuncionario.senha = senha;
                objFuncionario.cpf = cpf;
                objFuncionario.telefone = telefone;
                //método de cadastro
                objFuncionario.CadastrarFuncionario();

                MessageBox.Show("Funcionário cadastrado");
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar o empregado." + erro.Message,
                    "Falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
