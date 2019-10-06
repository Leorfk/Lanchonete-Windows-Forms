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
    public partial class FrmExclusao : Form
    {
        public FrmExclusao()
        {
            InitializeComponent();
            //Desativa os campos de entrada de dados
        }

        private void btnExcluirCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpcaoDeExclusao_CheckedChanged(object sender, EventArgs e)
        {
            //Procedimento para exibir e ocultar os groupBox
            if(sender == rbExcluirCliente)
            {
                pctExcluirFuncionario.Visible = false;
                pctExcluirFornecedor.Visible = false;
                pctExcluirCliente.Visible = true;
                txtExcluirCliente.Enabled = true;
                txtExcluirFornecedor.Enabled = false;
                txtExcluirFuncionario.Enabled = false;
                txtExcluirFornecedor.Clear();//Limpa a caixa de texto para evitar multiplas exclusões
                txtExcluirFuncionario.Clear();
            }
            else if(sender == rbExcluirFornecedor)
            {
                pctExcluirCliente.Visible = false;
                pctExcluirFuncionario.Visible = false;
                pctExcluirFornecedor.Visible = true;
                txtExcluirCliente.Enabled = false;
                txtExcluirFornecedor.Enabled = true;
                txtExcluirFuncionario.Enabled = false;
                txtExcluirCliente.Clear();
                txtExcluirFuncionario.Clear();
            }
            else if(sender == rbExcluirFuncionario)
            {
                pctExcluirCliente.Visible = false;
                pctExcluirFornecedor.Visible = false;
                pctExcluirFuncionario.Visible = true;
                txtExcluirCliente.Enabled = false;
                txtExcluirFornecedor.Enabled = false;
                txtExcluirFuncionario.Enabled = true;
                txtExcluirFornecedor.Clear();
                txtExcluirCliente.Clear();
            }
        }
    }
}
