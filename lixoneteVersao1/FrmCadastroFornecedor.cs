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
    public partial class FrmCadastroFornecedor : Form
    {
        public FrmCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void FrmCadastroEstoque_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarCadastroFornecedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarCadastroFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                //entrada de dados
                string razaoSocial = txtRazaoSocialFornecedor.Text;
                string nome = txtNomeFornecedor.Text;
                string cnpj = mtxtCNPJ.Text;
                string email = txtEmailForncedor.Text;
                string telefoneFixo = mtxtTelefoneFornecedorFixo.Text;
                string telefoneCel = mtxtCelularFornecedor.Text;

                //objeto do fornecedor
                Fornecedor objFornecedor = new Fornecedor();
                objFornecedor.razaoSocial = razaoSocial;
                objFornecedor.nome = nome;
                objFornecedor.cnpj = cnpj;
                objFornecedor.email = email;
                objFornecedor.telefoneFixo = telefoneFixo;
                objFornecedor.telefoneCelular = telefoneCel;

                //executa o métdo cadatrar
                objFornecedor.CadastrarFornecedor();

                MessageBox.Show("Fornecedor cadastrado com sucesso!!!");
                this.Close();
            }catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar o fornecedor." + erro.Message,
                                "Falha na operação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
