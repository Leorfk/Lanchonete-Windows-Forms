namespace lixoneteVersao1
{
    partial class FrmCadastroFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroFornecedor));
            this.pctEstoque = new System.Windows.Forms.PictureBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.mtxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.txtNomeFantasiaFornecedor = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.gbFornecedor = new System.Windows.Forms.GroupBox();
            this.txtEmailForncedor = new System.Windows.Forms.TextBox();
            this.mtxtCelularFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.lblCelularFornecedor = new System.Windows.Forms.Label();
            this.lblTelefoneFixoFornecedor = new System.Windows.Forms.Label();
            this.mtxtTelefoneFornecedorFixo = new System.Windows.Forms.MaskedTextBox();
            this.lblEmailFornecedor = new System.Windows.Forms.Label();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.txtRazaoSocialFornecedor = new System.Windows.Forms.TextBox();
            this.btnConfirmarCadastroFornecedor = new System.Windows.Forms.Button();
            this.btnCancelarCadastroFornecedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctEstoque)).BeginInit();
            this.gbFornecedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctEstoque
            // 
            this.pctEstoque.Image = ((System.Drawing.Image)(resources.GetObject("pctEstoque.Image")));
            this.pctEstoque.Location = new System.Drawing.Point(96, 12);
            this.pctEstoque.Name = "pctEstoque";
            this.pctEstoque.Size = new System.Drawing.Size(87, 79);
            this.pctEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctEstoque.TabIndex = 0;
            this.pctEstoque.TabStop = false;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFornecedor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFornecedor.Location = new System.Drawing.Point(50, 85);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(199, 20);
            this.lblFornecedor.TabIndex = 1;
            this.lblFornecedor.Text = "Cadastro de Fornecedores";
            // 
            // mtxtCNPJ
            // 
            this.mtxtCNPJ.Location = new System.Drawing.Point(6, 140);
            this.mtxtCNPJ.Mask = "99.999.999/9999-99";
            this.mtxtCNPJ.Name = "mtxtCNPJ";
            this.mtxtCNPJ.Size = new System.Drawing.Size(114, 20);
            this.mtxtCNPJ.TabIndex = 3;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(6, 25);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazaoSocial.TabIndex = 3;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // txtNomeFantasiaFornecedor
            // 
            this.txtNomeFantasiaFornecedor.AutoSize = true;
            this.txtNomeFantasiaFornecedor.Location = new System.Drawing.Point(6, 73);
            this.txtNomeFantasiaFornecedor.Name = "txtNomeFantasiaFornecedor";
            this.txtNomeFantasiaFornecedor.Size = new System.Drawing.Size(81, 13);
            this.txtNomeFantasiaFornecedor.TabIndex = 4;
            this.txtNomeFantasiaFornecedor.Text = "Nome Fantasia:";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(6, 124);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(37, 13);
            this.lblCNPJ.TabIndex = 5;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // gbFornecedor
            // 
            this.gbFornecedor.Controls.Add(this.txtEmailForncedor);
            this.gbFornecedor.Controls.Add(this.mtxtCelularFornecedor);
            this.gbFornecedor.Controls.Add(this.lblCelularFornecedor);
            this.gbFornecedor.Controls.Add(this.lblTelefoneFixoFornecedor);
            this.gbFornecedor.Controls.Add(this.mtxtTelefoneFornecedorFixo);
            this.gbFornecedor.Controls.Add(this.lblEmailFornecedor);
            this.gbFornecedor.Controls.Add(this.txtNomeFornecedor);
            this.gbFornecedor.Controls.Add(this.txtRazaoSocialFornecedor);
            this.gbFornecedor.Controls.Add(this.mtxtCNPJ);
            this.gbFornecedor.Controls.Add(this.lblCNPJ);
            this.gbFornecedor.Controls.Add(this.lblRazaoSocial);
            this.gbFornecedor.Controls.Add(this.txtNomeFantasiaFornecedor);
            this.gbFornecedor.Location = new System.Drawing.Point(12, 108);
            this.gbFornecedor.Name = "gbFornecedor";
            this.gbFornecedor.Size = new System.Drawing.Size(269, 290);
            this.gbFornecedor.TabIndex = 7;
            this.gbFornecedor.TabStop = false;
            this.gbFornecedor.Text = "Informações básicas";
            // 
            // txtEmailForncedor
            // 
            this.txtEmailForncedor.Location = new System.Drawing.Point(12, 193);
            this.txtEmailForncedor.Name = "txtEmailForncedor";
            this.txtEmailForncedor.Size = new System.Drawing.Size(225, 20);
            this.txtEmailForncedor.TabIndex = 4;
            // 
            // mtxtCelularFornecedor
            // 
            this.mtxtCelularFornecedor.Location = new System.Drawing.Point(129, 244);
            this.mtxtCelularFornecedor.Mask = "(99) 99999-9999";
            this.mtxtCelularFornecedor.Name = "mtxtCelularFornecedor";
            this.mtxtCelularFornecedor.Size = new System.Drawing.Size(100, 20);
            this.mtxtCelularFornecedor.TabIndex = 6;
            // 
            // lblCelularFornecedor
            // 
            this.lblCelularFornecedor.AutoSize = true;
            this.lblCelularFornecedor.Location = new System.Drawing.Point(126, 228);
            this.lblCelularFornecedor.Name = "lblCelularFornecedor";
            this.lblCelularFornecedor.Size = new System.Drawing.Size(45, 13);
            this.lblCelularFornecedor.TabIndex = 13;
            this.lblCelularFornecedor.Text = "Celular: ";
            // 
            // lblTelefoneFixoFornecedor
            // 
            this.lblTelefoneFixoFornecedor.AutoSize = true;
            this.lblTelefoneFixoFornecedor.Location = new System.Drawing.Point(9, 228);
            this.lblTelefoneFixoFornecedor.Name = "lblTelefoneFixoFornecedor";
            this.lblTelefoneFixoFornecedor.Size = new System.Drawing.Size(74, 13);
            this.lblTelefoneFixoFornecedor.TabIndex = 12;
            this.lblTelefoneFixoFornecedor.Text = "Telefone Fixo:";
            // 
            // mtxtTelefoneFornecedorFixo
            // 
            this.mtxtTelefoneFornecedorFixo.Location = new System.Drawing.Point(12, 244);
            this.mtxtTelefoneFornecedorFixo.Mask = "(99) 9999-9999";
            this.mtxtTelefoneFornecedorFixo.Name = "mtxtTelefoneFornecedorFixo";
            this.mtxtTelefoneFornecedorFixo.Size = new System.Drawing.Size(100, 20);
            this.mtxtTelefoneFornecedorFixo.TabIndex = 5;
            // 
            // lblEmailFornecedor
            // 
            this.lblEmailFornecedor.AutoSize = true;
            this.lblEmailFornecedor.Location = new System.Drawing.Point(9, 176);
            this.lblEmailFornecedor.Name = "lblEmailFornecedor";
            this.lblEmailFornecedor.Size = new System.Drawing.Size(35, 13);
            this.lblEmailFornecedor.TabIndex = 9;
            this.lblEmailFornecedor.Text = "Email:";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(9, 89);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(228, 20);
            this.txtNomeFornecedor.TabIndex = 2;
            // 
            // txtRazaoSocialFornecedor
            // 
            this.txtRazaoSocialFornecedor.Location = new System.Drawing.Point(9, 41);
            this.txtRazaoSocialFornecedor.Name = "txtRazaoSocialFornecedor";
            this.txtRazaoSocialFornecedor.Size = new System.Drawing.Size(228, 20);
            this.txtRazaoSocialFornecedor.TabIndex = 1;
            // 
            // btnConfirmarCadastroFornecedor
            // 
            this.btnConfirmarCadastroFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmarCadastroFornecedor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConfirmarCadastroFornecedor.Location = new System.Drawing.Point(201, 404);
            this.btnConfirmarCadastroFornecedor.Name = "btnConfirmarCadastroFornecedor";
            this.btnConfirmarCadastroFornecedor.Size = new System.Drawing.Size(80, 40);
            this.btnConfirmarCadastroFornecedor.TabIndex = 13;
            this.btnConfirmarCadastroFornecedor.Text = "Confirmar";
            this.btnConfirmarCadastroFornecedor.UseVisualStyleBackColor = false;
            this.btnConfirmarCadastroFornecedor.Click += new System.EventHandler(this.btnConfirmarCadastroFornecedor_Click);
            // 
            // btnCancelarCadastroFornecedor
            // 
            this.btnCancelarCadastroFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelarCadastroFornecedor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelarCadastroFornecedor.Location = new System.Drawing.Point(11, 404);
            this.btnCancelarCadastroFornecedor.Name = "btnCancelarCadastroFornecedor";
            this.btnCancelarCadastroFornecedor.Size = new System.Drawing.Size(80, 40);
            this.btnCancelarCadastroFornecedor.TabIndex = 14;
            this.btnCancelarCadastroFornecedor.Text = "Cancelar";
            this.btnCancelarCadastroFornecedor.UseVisualStyleBackColor = false;
            this.btnCancelarCadastroFornecedor.Click += new System.EventHandler(this.btnCancelarCadastroFornecedor_Click);
            // 
            // FrmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(296, 451);
            this.Controls.Add(this.btnCancelarCadastroFornecedor);
            this.Controls.Add(this.btnConfirmarCadastroFornecedor);
            this.Controls.Add(this.gbFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.pctEstoque);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroFornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.FrmCadastroEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctEstoque)).EndInit();
            this.gbFornecedor.ResumeLayout(false);
            this.gbFornecedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctEstoque;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.MaskedTextBox mtxtCNPJ;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label txtNomeFantasiaFornecedor;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.GroupBox gbFornecedor;
        private System.Windows.Forms.TextBox txtRazaoSocialFornecedor;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.TextBox txtEmailForncedor;
        private System.Windows.Forms.MaskedTextBox mtxtCelularFornecedor;
        private System.Windows.Forms.Label lblCelularFornecedor;
        private System.Windows.Forms.Label lblTelefoneFixoFornecedor;
        private System.Windows.Forms.MaskedTextBox mtxtTelefoneFornecedorFixo;
        private System.Windows.Forms.Label lblEmailFornecedor;
        private System.Windows.Forms.Button btnConfirmarCadastroFornecedor;
        private System.Windows.Forms.Button btnCancelarCadastroFornecedor;
    }
}