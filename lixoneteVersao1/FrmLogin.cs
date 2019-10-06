using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lixoneteVersao1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            Funcionario objFuncionario = new Funcionario();
            objFuncionario.login = txtLoginFuncionario.Text;
            objFuncionario.senha = txtSenhaFuncionario.Text;

            if (objFuncionario.Logar())
            {
                this.Close();
                MessageBox.Show("Bem vindo " + txtLoginFuncionario.Text);
            }
            else
            {
                MessageBox.Show("Usuário inválido");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não consegue né ?");
            Application.Exit();
        }
    }
}