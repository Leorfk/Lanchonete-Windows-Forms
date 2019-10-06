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
    public partial class FrmExibirFuncionarios : Form
    {
        public FrmExibirFuncionarios()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmExibirFuncionarios_Load(object sender, EventArgs e)
        {
            Funcionario objFuncionario = new Funcionario();
            dgvFuncionarios.DataSource = objFuncionario.ListarFuncionario();
        }
    }
}
