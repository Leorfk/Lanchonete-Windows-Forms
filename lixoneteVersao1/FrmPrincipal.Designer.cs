namespace lixoneteVersao1
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.msNavegacao = new System.Windows.Forms.MenuStrip();
            this.ItemMenuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuAcessar = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuCadastrarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuCadastrarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuCadastrarFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuCadastrarFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuEstoqueCadastrarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirInformaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuExibirClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuExibirFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuExibirFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.msNavegacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // msNavegacao
            // 
            this.msNavegacao.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.msNavegacao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMenuLogin,
            this.ItemMenuPedidos,
            this.ItemMenuCadastros,
            this.ItemMenuEstoque,
            this.ItemMenuExcluir,
            this.ItemMenuSair});
            this.msNavegacao.Location = new System.Drawing.Point(0, 0);
            this.msNavegacao.Name = "msNavegacao";
            this.msNavegacao.Size = new System.Drawing.Size(1370, 24);
            this.msNavegacao.TabIndex = 0;
            this.msNavegacao.Text = "menuStrip1";
            // 
            // ItemMenuLogin
            // 
            this.ItemMenuLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMenuAcessar});
            this.ItemMenuLogin.Name = "ItemMenuLogin";
            this.ItemMenuLogin.Size = new System.Drawing.Size(49, 20);
            this.ItemMenuLogin.Text = "Login";
            // 
            // ItemMenuAcessar
            // 
            this.ItemMenuAcessar.Name = "ItemMenuAcessar";
            this.ItemMenuAcessar.Size = new System.Drawing.Size(180, 22);
            this.ItemMenuAcessar.Text = "Acessar";
            this.ItemMenuAcessar.Click += new System.EventHandler(this.ItemMenuAcessar_Click);
            // 
            // ItemMenuPedidos
            // 
            this.ItemMenuPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMenuCadastrarPedido});
            this.ItemMenuPedidos.Name = "ItemMenuPedidos";
            this.ItemMenuPedidos.Size = new System.Drawing.Size(61, 20);
            this.ItemMenuPedidos.Text = "Pedidos";
            // 
            // ItemMenuCadastrarPedido
            // 
            this.ItemMenuCadastrarPedido.Name = "ItemMenuCadastrarPedido";
            this.ItemMenuCadastrarPedido.Size = new System.Drawing.Size(180, 22);
            this.ItemMenuCadastrarPedido.Text = "Anotar Pedido";
            this.ItemMenuCadastrarPedido.Click += new System.EventHandler(this.ItemMenuCadastrarPedido_Click);
            // 
            // ItemMenuCadastros
            // 
            this.ItemMenuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMenuCadastrarClientes,
            this.ItemMenuCadastrarFuncionarios,
            this.ItemMenuCadastrarFornecedores,
            this.exibirInformaçõesToolStripMenuItem});
            this.ItemMenuCadastros.Name = "ItemMenuCadastros";
            this.ItemMenuCadastros.Size = new System.Drawing.Size(71, 20);
            this.ItemMenuCadastros.Text = "Cadastros";
            // 
            // ItemMenuCadastrarClientes
            // 
            this.ItemMenuCadastrarClientes.Name = "ItemMenuCadastrarClientes";
            this.ItemMenuCadastrarClientes.Size = new System.Drawing.Size(180, 22);
            this.ItemMenuCadastrarClientes.Text = "Clientes";
            this.ItemMenuCadastrarClientes.Click += new System.EventHandler(this.ItemMenuCadastrarClientes_Click);
            // 
            // ItemMenuCadastrarFuncionarios
            // 
            this.ItemMenuCadastrarFuncionarios.Name = "ItemMenuCadastrarFuncionarios";
            this.ItemMenuCadastrarFuncionarios.Size = new System.Drawing.Size(180, 22);
            this.ItemMenuCadastrarFuncionarios.Text = "Funcionários";
            this.ItemMenuCadastrarFuncionarios.Click += new System.EventHandler(this.ItemMenuCadastrarFuncionarios_Click);
            // 
            // ItemMenuCadastrarFornecedores
            // 
            this.ItemMenuCadastrarFornecedores.Name = "ItemMenuCadastrarFornecedores";
            this.ItemMenuCadastrarFornecedores.Size = new System.Drawing.Size(180, 22);
            this.ItemMenuCadastrarFornecedores.Text = "Fornecedores";
            this.ItemMenuCadastrarFornecedores.Click += new System.EventHandler(this.ItemMenuCadastrarFornecedores_Click);
            // 
            // ItemMenuEstoque
            // 
            this.ItemMenuEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuEstoqueCadastrarProdutos,
            this.ItemMenu});
            this.ItemMenuEstoque.Name = "ItemMenuEstoque";
            this.ItemMenuEstoque.Size = new System.Drawing.Size(61, 20);
            this.ItemMenuEstoque.Text = "Estoque";
            // 
            // itemMenuEstoqueCadastrarProdutos
            // 
            this.itemMenuEstoqueCadastrarProdutos.Name = "itemMenuEstoqueCadastrarProdutos";
            this.itemMenuEstoqueCadastrarProdutos.Size = new System.Drawing.Size(180, 22);
            this.itemMenuEstoqueCadastrarProdutos.Text = "Cadastrar produtos";
            this.itemMenuEstoqueCadastrarProdutos.Click += new System.EventHandler(this.itemMenuEstoqueCadastrarProdutos_Click);
            // 
            // ItemMenu
            // 
            this.ItemMenu.Name = "ItemMenu";
            this.ItemMenu.Size = new System.Drawing.Size(180, 22);
            this.ItemMenu.Text = "Exibir produtos";
            // 
            // ItemMenuExcluir
            // 
            this.ItemMenuExcluir.BackColor = System.Drawing.Color.Red;
            this.ItemMenuExcluir.ForeColor = System.Drawing.Color.Silver;
            this.ItemMenuExcluir.Name = "ItemMenuExcluir";
            this.ItemMenuExcluir.Size = new System.Drawing.Size(53, 20);
            this.ItemMenuExcluir.Text = "Excluir";
            this.ItemMenuExcluir.Click += new System.EventHandler(this.ItemMenuExcluir_Click);
            // 
            // ItemMenuSair
            // 
            this.ItemMenuSair.Name = "ItemMenuSair";
            this.ItemMenuSair.Size = new System.Drawing.Size(38, 20);
            this.ItemMenuSair.Text = "Sair";
            this.ItemMenuSair.Click += new System.EventHandler(this.ItemMenuSair_Click_1);
            // 
            // exibirInformaçõesToolStripMenuItem
            // 
            this.exibirInformaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMenuExibirClientes,
            this.ItemMenuExibirFuncionarios,
            this.ItemMenuExibirFornecedores});
            this.exibirInformaçõesToolStripMenuItem.Name = "exibirInformaçõesToolStripMenuItem";
            this.exibirInformaçõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exibirInformaçõesToolStripMenuItem.Text = "Exibir informações";
            // 
            // ItemMenuExibirClientes
            // 
            this.ItemMenuExibirClientes.Name = "ItemMenuExibirClientes";
            this.ItemMenuExibirClientes.Size = new System.Drawing.Size(180, 22);
            this.ItemMenuExibirClientes.Text = "Clientes";
            this.ItemMenuExibirClientes.Click += new System.EventHandler(this.ItemMenuExibirClientes_Click);
            // 
            // ItemMenuExibirFuncionarios
            // 
            this.ItemMenuExibirFuncionarios.Name = "ItemMenuExibirFuncionarios";
            this.ItemMenuExibirFuncionarios.Size = new System.Drawing.Size(180, 22);
            this.ItemMenuExibirFuncionarios.Text = "Funcionarios";
            this.ItemMenuExibirFuncionarios.Click += new System.EventHandler(this.ItemMenuExibirFuncionarios_Click);
            // 
            // ItemMenuExibirFornecedores
            // 
            this.ItemMenuExibirFornecedores.Name = "ItemMenuExibirFornecedores";
            this.ItemMenuExibirFornecedores.Size = new System.Drawing.Size(180, 22);
            this.ItemMenuExibirFornecedores.Text = "Fornecedores";
            this.ItemMenuExibirFornecedores.Click += new System.EventHandler(this.ItemMenuExibirFornecedores_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.msNavegacao);
            this.MainMenuStrip = this.msNavegacao;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1080, 640);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Larika Lanches";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.msNavegacao.ResumeLayout(false);
            this.msNavegacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msNavegacao;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuPedidos;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuLogin;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuCadastrarPedido;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuAcessar;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuCadastrarClientes;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuCadastrarFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuCadastrarFornecedores;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem itemMenuEstoqueCadastrarProdutos;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuExcluir;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuSair;
        private System.Windows.Forms.ToolStripMenuItem ItemMenu;
        private System.Windows.Forms.ToolStripMenuItem exibirInformaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuExibirClientes;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuExibirFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuExibirFornecedores;
    }
}