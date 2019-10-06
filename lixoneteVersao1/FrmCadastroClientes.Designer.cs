namespace lixoneteVersao1
{
    partial class FrmCadastroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroClientes));
            this.gbInfoPessoal = new System.Windows.Forms.GroupBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.txtEmailCLiente = new System.Windows.Forms.TextBox();
            this.mtxtClienteTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCFP = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNomeCLiente = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctCliente = new System.Windows.Forms.PictureBox();
            this.btnConfirmarCadastroCliente = new System.Windows.Forms.Button();
            this.btnCancelarCadastroCliente = new System.Windows.Forms.Button();
            this.gbInfoPessoal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfoPessoal
            // 
            this.gbInfoPessoal.Controls.Add(this.txtApelido);
            this.gbInfoPessoal.Controls.Add(this.lblApelido);
            this.gbInfoPessoal.Controls.Add(this.txtEmailCLiente);
            this.gbInfoPessoal.Controls.Add(this.mtxtClienteTelefone);
            this.gbInfoPessoal.Controls.Add(this.mtxtCPF);
            this.gbInfoPessoal.Controls.Add(this.txtNomeCliente);
            this.gbInfoPessoal.Controls.Add(this.lblTelefone);
            this.gbInfoPessoal.Controls.Add(this.lblCFP);
            this.gbInfoPessoal.Controls.Add(this.lblEmail);
            this.gbInfoPessoal.Controls.Add(this.lblNomeCLiente);
            this.gbInfoPessoal.Location = new System.Drawing.Point(12, 94);
            this.gbInfoPessoal.Name = "gbInfoPessoal";
            this.gbInfoPessoal.Size = new System.Drawing.Size(320, 215);
            this.gbInfoPessoal.TabIndex = 0;
            this.gbInfoPessoal.TabStop = false;
            this.gbInfoPessoal.Text = "Informações Pessoais";
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(31, 131);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(246, 20);
            this.txtApelido.TabIndex = 3;
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(28, 118);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(45, 13);
            this.lblApelido.TabIndex = 9;
            this.lblApelido.Text = "Apelido:";
            // 
            // txtEmailCLiente
            // 
            this.txtEmailCLiente.Location = new System.Drawing.Point(28, 91);
            this.txtEmailCLiente.Name = "txtEmailCLiente";
            this.txtEmailCLiente.Size = new System.Drawing.Size(249, 20);
            this.txtEmailCLiente.TabIndex = 2;
            // 
            // mtxtClienteTelefone
            // 
            this.mtxtClienteTelefone.Location = new System.Drawing.Point(31, 178);
            this.mtxtClienteTelefone.Mask = "(999) 99999-9999";
            this.mtxtClienteTelefone.Name = "mtxtClienteTelefone";
            this.mtxtClienteTelefone.Size = new System.Drawing.Size(93, 20);
            this.mtxtClienteTelefone.TabIndex = 5;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(182, 178);
            this.mtxtCPF.Mask = "999.999.999-99";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(93, 20);
            this.mtxtCPF.TabIndex = 5;
            this.mtxtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(28, 41);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(249, 20);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(28, 158);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 13);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone: ";
            // 
            // lblCFP
            // 
            this.lblCFP.AutoSize = true;
            this.lblCFP.Location = new System.Drawing.Point(179, 162);
            this.lblCFP.Name = "lblCFP";
            this.lblCFP.Size = new System.Drawing.Size(33, 13);
            this.lblCFP.TabIndex = 2;
            this.lblCFP.Text = "CPF: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 74);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email: ";
            // 
            // lblNomeCLiente
            // 
            this.lblNomeCLiente.AutoSize = true;
            this.lblNomeCLiente.Location = new System.Drawing.Point(25, 25);
            this.lblNomeCLiente.Name = "lblNomeCLiente";
            this.lblNomeCLiente.Size = new System.Drawing.Size(41, 13);
            this.lblNomeCLiente.TabIndex = 0;
            this.lblNomeCLiente.Text = "Nome: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitulo.Location = new System.Drawing.Point(142, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(190, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Cadastro de clientes";
            // 
            // pctCliente
            // 
            this.pctCliente.Image = ((System.Drawing.Image)(resources.GetObject("pctCliente.Image")));
            this.pctCliente.Location = new System.Drawing.Point(40, 12);
            this.pctCliente.Name = "pctCliente";
            this.pctCliente.Size = new System.Drawing.Size(80, 76);
            this.pctCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCliente.TabIndex = 2;
            this.pctCliente.TabStop = false;
            // 
            // btnConfirmarCadastroCliente
            // 
            this.btnConfirmarCadastroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmarCadastroCliente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConfirmarCadastroCliente.Location = new System.Drawing.Point(252, 315);
            this.btnConfirmarCadastroCliente.Name = "btnConfirmarCadastroCliente";
            this.btnConfirmarCadastroCliente.Size = new System.Drawing.Size(80, 40);
            this.btnConfirmarCadastroCliente.TabIndex = 12;
            this.btnConfirmarCadastroCliente.Text = "Confirmar";
            this.btnConfirmarCadastroCliente.UseVisualStyleBackColor = false;
            this.btnConfirmarCadastroCliente.Click += new System.EventHandler(this.btnConfirmarCadastroCliente_Click);
            // 
            // btnCancelarCadastroCliente
            // 
            this.btnCancelarCadastroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelarCadastroCliente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelarCadastroCliente.Location = new System.Drawing.Point(12, 315);
            this.btnCancelarCadastroCliente.Name = "btnCancelarCadastroCliente";
            this.btnCancelarCadastroCliente.Size = new System.Drawing.Size(80, 40);
            this.btnCancelarCadastroCliente.TabIndex = 13;
            this.btnCancelarCadastroCliente.Text = "Cancelar";
            this.btnCancelarCadastroCliente.UseVisualStyleBackColor = false;
            this.btnCancelarCadastroCliente.Click += new System.EventHandler(this.btnCancelarCadastroCliente_Click);
            // 
            // FrmCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(352, 365);
            this.Controls.Add(this.btnCancelarCadastroCliente);
            this.Controls.Add(this.btnConfirmarCadastroCliente);
            this.Controls.Add(this.pctCliente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbInfoPessoal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroClientes";
            this.Text = "CadastroClientes";
            this.gbInfoPessoal.ResumeLayout(false);
            this.gbInfoPessoal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoPessoal;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCFP;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNomeCLiente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pctCliente;
        private System.Windows.Forms.TextBox txtEmailCLiente;
        private System.Windows.Forms.MaskedTextBox mtxtClienteTelefone;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button btnConfirmarCadastroCliente;
        private System.Windows.Forms.Button btnCancelarCadastroCliente;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label lblApelido;
    }
}