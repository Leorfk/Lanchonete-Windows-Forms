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
    public partial class FrmExibirFornecedores : Form
    {
        public FrmExibirFornecedores()
        {
            InitializeComponent();
        }

        private void FrmExibirFornecedores_Load(object sender, EventArgs e)
        {
            Fornecedor objFornecedor = new Fornecedor();
            dgvFornecedor.DataSource = objFornecedor.ListarFornecedores();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
