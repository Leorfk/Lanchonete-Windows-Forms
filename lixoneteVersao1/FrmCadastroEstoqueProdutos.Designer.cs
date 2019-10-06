namespace lixoneteVersao1
{
    partial class FrmCadastroEstoqueProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroEstoqueProdutos));
            this.pctEstoqueProduto = new System.Windows.Forms.PictureBox();
            this.lblTituloEstoqueCadastro = new System.Windows.Forms.Label();
            this.gbCadastroProdutosInfo = new System.Windows.Forms.GroupBox();
            this.lblTipoProduto = new System.Windows.Forms.Label();
            this.rbBebida = new System.Windows.Forms.RadioButton();
            this.rbComida = new System.Windows.Forms.RadioButton();
            this.txtCadastroProdutoNotaFiscal = new System.Windows.Forms.TextBox();
            this.CadastroProdutoNotaFiscal = new System.Windows.Forms.Label();
            this.lblValorUNitario = new System.Windows.Forms.Label();
            this.txtEstoqueValorUnitario = new System.Windows.Forms.TextBox();
            this.nudCadastroProdutoQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtCadastroProdutoDescricao = new System.Windows.Forms.TextBox();
            this.txtCadastroProdutoNome = new System.Windows.Forms.TextBox();
            this.lblCadastroProdutoQuantidade = new System.Windows.Forms.Label();
            this.lblCadastroProdutoDescricao = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.btnCadastroProdutoConfirmar = new System.Windows.Forms.Button();
            this.btnCadastroProdutoCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctEstoqueProduto)).BeginInit();
            this.gbCadastroProdutosInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCadastroProdutoQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // pctEstoqueProduto
            // 
            this.pctEstoqueProduto.Image = ((System.Drawing.Image)(resources.GetObject("pctEstoqueProduto.Image")));
            this.pctEstoqueProduto.Location = new System.Drawing.Point(12, 12);
            this.pctEstoqueProduto.Name = "pctEstoqueProduto";
            this.pctEstoqueProduto.Size = new System.Drawing.Size(80, 80);
            this.pctEstoqueProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctEstoqueProduto.TabIndex = 0;
            this.pctEstoqueProduto.TabStop = false;
            // 
            // lblTituloEstoqueCadastro
            // 
            this.lblTituloEstoqueCadastro.AutoSize = true;
            this.lblTituloEstoqueCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTituloEstoqueCadastro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTituloEstoqueCadastro.Location = new System.Drawing.Point(93, 47);
            this.lblTituloEstoqueCadastro.Name = "lblTituloEstoqueCadastro";
            this.lblTituloEstoqueCadastro.Size = new System.Drawing.Size(220, 24);
            this.lblTituloEstoqueCadastro.TabIndex = 1;
            this.lblTituloEstoqueCadastro.Text = "Cadastro de Mercadorias";
            // 
            // gbCadastroProdutosInfo
            // 
            this.gbCadastroProdutosInfo.Controls.Add(this.lblTipoProduto);
            this.gbCadastroProdutosInfo.Controls.Add(this.rbBebida);
            this.gbCadastroProdutosInfo.Controls.Add(this.rbComida);
            this.gbCadastroProdutosInfo.Controls.Add(this.txtCadastroProdutoNotaFiscal);
            this.gbCadastroProdutosInfo.Controls.Add(this.CadastroProdutoNotaFiscal);
            this.gbCadastroProdutosInfo.Controls.Add(this.lblValorUNitario);
            this.gbCadastroProdutosInfo.Controls.Add(this.txtEstoqueValorUnitario);
            this.gbCadastroProdutosInfo.Controls.Add(this.nudCadastroProdutoQuantidade);
            this.gbCadastroProdutosInfo.Controls.Add(this.txtCadastroProdutoDescricao);
            this.gbCadastroProdutosInfo.Controls.Add(this.txtCadastroProdutoNome);
            this.gbCadastroProdutosInfo.Controls.Add(this.lblCadastroProdutoQuantidade);
            this.gbCadastroProdutosInfo.Controls.Add(this.lblCadastroProdutoDescricao);
            this.gbCadastroProdutosInfo.Controls.Add(this.lblNomeProduto);
            this.gbCadastroProdutosInfo.Location = new System.Drawing.Point(12, 98);
            this.gbCadastroProdutosInfo.Name = "gbCadastroProdutosInfo";
            this.gbCadastroProdutosInfo.Size = new System.Drawing.Size(326, 303);
            this.gbCadastroProdutosInfo.TabIndex = 2;
            this.gbCadastroProdutosInfo.TabStop = false;
            this.gbCadastroProdutosInfo.Text = "Informações sobre o produto";
            // 
            // lblTipoProduto
            // 
            this.lblTipoProduto.AutoSize = true;
            this.lblTipoProduto.Location = new System.Drawing.Point(174, 177);
            this.lblTipoProduto.Name = "lblTipoProduto";
            this.lblTipoProduto.Size = new System.Drawing.Size(83, 13);
            this.lblTipoProduto.TabIndex = 10;
            this.lblTipoProduto.Text = "Tipo do Produto";
            // 
            // rbBebida
            // 
            this.rbBebida.AutoSize = true;
            this.rbBebida.Location = new System.Drawing.Point(177, 218);
            this.rbBebida.Name = "rbBebida";
            this.rbBebida.Size = new System.Drawing.Size(58, 17);
            this.rbBebida.TabIndex = 6;
            this.rbBebida.TabStop = true;
            this.rbBebida.Text = "Bebida";
            this.rbBebida.UseVisualStyleBackColor = true;
            // 
            // rbComida
            // 
            this.rbComida.AutoSize = true;
            this.rbComida.Location = new System.Drawing.Point(177, 197);
            this.rbComida.Name = "rbComida";
            this.rbComida.Size = new System.Drawing.Size(60, 17);
            this.rbComida.TabIndex = 5;
            this.rbComida.TabStop = true;
            this.rbComida.Text = "Comida";
            this.rbComida.UseVisualStyleBackColor = true;
            // 
            // txtCadastroProdutoNotaFiscal
            // 
            this.txtCadastroProdutoNotaFiscal.Location = new System.Drawing.Point(10, 272);
            this.txtCadastroProdutoNotaFiscal.Name = "txtCadastroProdutoNotaFiscal";
            this.txtCadastroProdutoNotaFiscal.Size = new System.Drawing.Size(100, 20);
            this.txtCadastroProdutoNotaFiscal.TabIndex = 8;
            this.txtCadastroProdutoNotaFiscal.TextChanged += new System.EventHandler(this.txtCadastroProdutoNotaFiscal_TextChanged);
            // 
            // CadastroProdutoNotaFiscal
            // 
            this.CadastroProdutoNotaFiscal.AutoSize = true;
            this.CadastroProdutoNotaFiscal.Location = new System.Drawing.Point(10, 256);
            this.CadastroProdutoNotaFiscal.Name = "CadastroProdutoNotaFiscal";
            this.CadastroProdutoNotaFiscal.Size = new System.Drawing.Size(103, 13);
            this.CadastroProdutoNotaFiscal.TabIndex = 2;
            this.CadastroProdutoNotaFiscal.Text = "Valor da nota fiscal: ";
            // 
            // lblValorUNitario
            // 
            this.lblValorUNitario.AutoSize = true;
            this.lblValorUNitario.Location = new System.Drawing.Point(6, 201);
            this.lblValorUNitario.Name = "lblValorUNitario";
            this.lblValorUNitario.Size = new System.Drawing.Size(74, 13);
            this.lblValorUNitario.TabIndex = 5;
            this.lblValorUNitario.Text = "Valor unitário: ";
            // 
            // txtEstoqueValorUnitario
            // 
            this.txtEstoqueValorUnitario.Location = new System.Drawing.Point(9, 217);
            this.txtEstoqueValorUnitario.Name = "txtEstoqueValorUnitario";
            this.txtEstoqueValorUnitario.Size = new System.Drawing.Size(82, 20);
            this.txtEstoqueValorUnitario.TabIndex = 4;
            // 
            // nudCadastroProdutoQuantidade
            // 
            this.nudCadastroProdutoQuantidade.Location = new System.Drawing.Point(7, 177);
            this.nudCadastroProdutoQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCadastroProdutoQuantidade.Name = "nudCadastroProdutoQuantidade";
            this.nudCadastroProdutoQuantidade.Size = new System.Drawing.Size(84, 20);
            this.nudCadastroProdutoQuantidade.TabIndex = 3;
            this.nudCadastroProdutoQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCadastroProdutoQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCadastroProdutoDescricao
            // 
            this.txtCadastroProdutoDescricao.Location = new System.Drawing.Point(7, 102);
            this.txtCadastroProdutoDescricao.Multiline = true;
            this.txtCadastroProdutoDescricao.Name = "txtCadastroProdutoDescricao";
            this.txtCadastroProdutoDescricao.Size = new System.Drawing.Size(299, 50);
            this.txtCadastroProdutoDescricao.TabIndex = 2;
            // 
            // txtCadastroProdutoNome
            // 
            this.txtCadastroProdutoNome.Location = new System.Drawing.Point(7, 48);
            this.txtCadastroProdutoNome.Name = "txtCadastroProdutoNome";
            this.txtCadastroProdutoNome.Size = new System.Drawing.Size(210, 20);
            this.txtCadastroProdutoNome.TabIndex = 1;
            // 
            // lblCadastroProdutoQuantidade
            // 
            this.lblCadastroProdutoQuantidade.AutoSize = true;
            this.lblCadastroProdutoQuantidade.Location = new System.Drawing.Point(4, 161);
            this.lblCadastroProdutoQuantidade.Name = "lblCadastroProdutoQuantidade";
            this.lblCadastroProdutoQuantidade.Size = new System.Drawing.Size(91, 13);
            this.lblCadastroProdutoQuantidade.TabIndex = 2;
            this.lblCadastroProdutoQuantidade.Text = "Quantidade unid.:";
            // 
            // lblCadastroProdutoDescricao
            // 
            this.lblCadastroProdutoDescricao.AutoSize = true;
            this.lblCadastroProdutoDescricao.Location = new System.Drawing.Point(6, 86);
            this.lblCadastroProdutoDescricao.Name = "lblCadastroProdutoDescricao";
            this.lblCadastroProdutoDescricao.Size = new System.Drawing.Size(61, 13);
            this.lblCadastroProdutoDescricao.TabIndex = 1;
            this.lblCadastroProdutoDescricao.Text = "Descrição: ";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(6, 31);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(95, 13);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome do produto: ";
            // 
            // btnCadastroProdutoConfirmar
            // 
            this.btnCadastroProdutoConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastroProdutoConfirmar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCadastroProdutoConfirmar.Location = new System.Drawing.Point(258, 407);
            this.btnCadastroProdutoConfirmar.Name = "btnCadastroProdutoConfirmar";
            this.btnCadastroProdutoConfirmar.Size = new System.Drawing.Size(80, 40);
            this.btnCadastroProdutoConfirmar.TabIndex = 9;
            this.btnCadastroProdutoConfirmar.Text = "Confirmar";
            this.btnCadastroProdutoConfirmar.UseVisualStyleBackColor = false;
            this.btnCadastroProdutoConfirmar.Click += new System.EventHandler(this.btnCadastroProdutoConfirmar_Click);
            // 
            // btnCadastroProdutoCancelar
            // 
            this.btnCadastroProdutoCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadastroProdutoCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCadastroProdutoCancelar.Location = new System.Drawing.Point(12, 407);
            this.btnCadastroProdutoCancelar.Name = "btnCadastroProdutoCancelar";
            this.btnCadastroProdutoCancelar.Size = new System.Drawing.Size(80, 40);
            this.btnCadastroProdutoCancelar.TabIndex = 10;
            this.btnCadastroProdutoCancelar.Text = "Cancelar";
            this.btnCadastroProdutoCancelar.UseVisualStyleBackColor = false;
            this.btnCadastroProdutoCancelar.Click += new System.EventHandler(this.btnCadastroProdutoCancelar_Click);
            // 
            // FrmCadastroEstoqueProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(352, 452);
            this.Controls.Add(this.btnCadastroProdutoCancelar);
            this.Controls.Add(this.btnCadastroProdutoConfirmar);
            this.Controls.Add(this.gbCadastroProdutosInfo);
            this.Controls.Add(this.lblTituloEstoqueCadastro);
            this.Controls.Add(this.pctEstoqueProduto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroEstoqueProdutos";
            this.Text = "Cadastro de produtos no estoque";
            ((System.ComponentModel.ISupportInitialize)(this.pctEstoqueProduto)).EndInit();
            this.gbCadastroProdutosInfo.ResumeLayout(false);
            this.gbCadastroProdutosInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCadastroProdutoQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctEstoqueProduto;
        private System.Windows.Forms.Label lblTituloEstoqueCadastro;
        private System.Windows.Forms.GroupBox gbCadastroProdutosInfo;
        private System.Windows.Forms.NumericUpDown nudCadastroProdutoQuantidade;
        private System.Windows.Forms.TextBox txtCadastroProdutoDescricao;
        private System.Windows.Forms.TextBox txtCadastroProdutoNome;
        private System.Windows.Forms.Label lblCadastroProdutoQuantidade;
        private System.Windows.Forms.Label lblCadastroProdutoDescricao;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txtCadastroProdutoNotaFiscal;
        private System.Windows.Forms.Label CadastroProdutoNotaFiscal;
        private System.Windows.Forms.Button btnCadastroProdutoConfirmar;
        private System.Windows.Forms.Button btnCadastroProdutoCancelar;
        private System.Windows.Forms.Label lblValorUNitario;
        private System.Windows.Forms.TextBox txtEstoqueValorUnitario;
        private System.Windows.Forms.Label lblTipoProduto;
        private System.Windows.Forms.RadioButton rbBebida;
        private System.Windows.Forms.RadioButton rbComida;
    }
}