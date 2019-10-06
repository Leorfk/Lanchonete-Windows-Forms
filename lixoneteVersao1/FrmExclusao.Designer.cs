namespace lixoneteVersao1
{
    partial class FrmExclusao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExclusao));
            this.gbExcluir = new System.Windows.Forms.GroupBox();
            this.txtExcluirCliente = new System.Windows.Forms.TextBox();
            this.lblApelidoCliente = new System.Windows.Forms.Label();
            this.txtExcluirFornecedor = new System.Windows.Forms.TextBox();
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.txtExcluirFuncionario = new System.Windows.Forms.TextBox();
            this.lblLoginFuncionario = new System.Windows.Forms.Label();
            this.lblTituloExcluir = new System.Windows.Forms.Label();
            this.rbExcluirCliente = new System.Windows.Forms.RadioButton();
            this.rbExcluirFornecedor = new System.Windows.Forms.RadioButton();
            this.rbExcluirFuncionario = new System.Windows.Forms.RadioButton();
            this.lblSenhaExclusao = new System.Windows.Forms.Label();
            this.txtSenhaExclusao = new System.Windows.Forms.TextBox();
            this.btnExcluirConfirma = new System.Windows.Forms.Button();
            this.btnExcluirCancelar = new System.Windows.Forms.Button();
            this.pctExcluirCliente = new System.Windows.Forms.PictureBox();
            this.pctExcluirFuncionario = new System.Windows.Forms.PictureBox();
            this.pctExcluirFornecedor = new System.Windows.Forms.PictureBox();
            this.gbExcluir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExcluirCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExcluirFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExcluirFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbExcluir
            // 
            this.gbExcluir.Controls.Add(this.pctExcluirFornecedor);
            this.gbExcluir.Controls.Add(this.pctExcluirFuncionario);
            this.gbExcluir.Controls.Add(this.pctExcluirCliente);
            this.gbExcluir.Controls.Add(this.txtExcluirFornecedor);
            this.gbExcluir.Controls.Add(this.lblNomeFornecedor);
            this.gbExcluir.Controls.Add(this.txtExcluirFuncionario);
            this.gbExcluir.Controls.Add(this.txtExcluirCliente);
            this.gbExcluir.Controls.Add(this.lblLoginFuncionario);
            this.gbExcluir.Controls.Add(this.lblApelidoCliente);
            this.gbExcluir.Location = new System.Drawing.Point(12, 71);
            this.gbExcluir.Name = "gbExcluir";
            this.gbExcluir.Size = new System.Drawing.Size(229, 224);
            this.gbExcluir.TabIndex = 0;
            this.gbExcluir.TabStop = false;
            this.gbExcluir.Text = "Selecione uma das opções acima";
            // 
            // txtExcluirCliente
            // 
            this.txtExcluirCliente.Enabled = false;
            this.txtExcluirCliente.Location = new System.Drawing.Point(10, 49);
            this.txtExcluirCliente.Name = "txtExcluirCliente";
            this.txtExcluirCliente.Size = new System.Drawing.Size(182, 20);
            this.txtExcluirCliente.TabIndex = 1;
            // 
            // lblApelidoCliente
            // 
            this.lblApelidoCliente.AutoSize = true;
            this.lblApelidoCliente.Location = new System.Drawing.Point(7, 33);
            this.lblApelidoCliente.Name = "lblApelidoCliente";
            this.lblApelidoCliente.Size = new System.Drawing.Size(98, 13);
            this.lblApelidoCliente.TabIndex = 0;
            this.lblApelidoCliente.Text = "Apelido do Cliente: ";
            // 
            // txtExcluirFornecedor
            // 
            this.txtExcluirFornecedor.Enabled = false;
            this.txtExcluirFornecedor.Location = new System.Drawing.Point(7, 182);
            this.txtExcluirFornecedor.Name = "txtExcluirFornecedor";
            this.txtExcluirFornecedor.Size = new System.Drawing.Size(185, 20);
            this.txtExcluirFornecedor.TabIndex = 2;
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Location = new System.Drawing.Point(7, 166);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(99, 13);
            this.lblNomeFornecedor.TabIndex = 1;
            this.lblNomeFornecedor.Text = "Nome da empresa: ";
            // 
            // txtExcluirFuncionario
            // 
            this.txtExcluirFuncionario.Enabled = false;
            this.txtExcluirFuncionario.Location = new System.Drawing.Point(7, 113);
            this.txtExcluirFuncionario.Name = "txtExcluirFuncionario";
            this.txtExcluirFuncionario.Size = new System.Drawing.Size(185, 20);
            this.txtExcluirFuncionario.TabIndex = 2;
            // 
            // lblLoginFuncionario
            // 
            this.lblLoginFuncionario.AutoSize = true;
            this.lblLoginFuncionario.Location = new System.Drawing.Point(7, 97);
            this.lblLoginFuncionario.Name = "lblLoginFuncionario";
            this.lblLoginFuncionario.Size = new System.Drawing.Size(112, 13);
            this.lblLoginFuncionario.TabIndex = 1;
            this.lblLoginFuncionario.Text = "Login do Funcionário: ";
            // 
            // lblTituloExcluir
            // 
            this.lblTituloExcluir.AutoSize = true;
            this.lblTituloExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTituloExcluir.ForeColor = System.Drawing.Color.Red;
            this.lblTituloExcluir.Location = new System.Drawing.Point(15, 9);
            this.lblTituloExcluir.Name = "lblTituloExcluir";
            this.lblTituloExcluir.Size = new System.Drawing.Size(220, 26);
            this.lblTituloExcluir.TabIndex = 2;
            this.lblTituloExcluir.Text = "Exclusão de registros";
            // 
            // rbExcluirCliente
            // 
            this.rbExcluirCliente.AutoSize = true;
            this.rbExcluirCliente.Location = new System.Drawing.Point(12, 48);
            this.rbExcluirCliente.Name = "rbExcluirCliente";
            this.rbExcluirCliente.Size = new System.Drawing.Size(57, 17);
            this.rbExcluirCliente.TabIndex = 4;
            this.rbExcluirCliente.TabStop = true;
            this.rbExcluirCliente.Text = "Cliente";
            this.rbExcluirCliente.UseVisualStyleBackColor = true;
            this.rbExcluirCliente.CheckedChanged += new System.EventHandler(this.OpcaoDeExclusao_CheckedChanged);
            // 
            // rbExcluirFornecedor
            // 
            this.rbExcluirFornecedor.AutoSize = true;
            this.rbExcluirFornecedor.Location = new System.Drawing.Point(161, 48);
            this.rbExcluirFornecedor.Name = "rbExcluirFornecedor";
            this.rbExcluirFornecedor.Size = new System.Drawing.Size(79, 17);
            this.rbExcluirFornecedor.TabIndex = 5;
            this.rbExcluirFornecedor.TabStop = true;
            this.rbExcluirFornecedor.Text = "Fornecedor";
            this.rbExcluirFornecedor.UseVisualStyleBackColor = true;
            this.rbExcluirFornecedor.CheckedChanged += new System.EventHandler(this.OpcaoDeExclusao_CheckedChanged);
            // 
            // rbExcluirFuncionario
            // 
            this.rbExcluirFuncionario.AutoSize = true;
            this.rbExcluirFuncionario.Location = new System.Drawing.Point(75, 48);
            this.rbExcluirFuncionario.Name = "rbExcluirFuncionario";
            this.rbExcluirFuncionario.Size = new System.Drawing.Size(80, 17);
            this.rbExcluirFuncionario.TabIndex = 6;
            this.rbExcluirFuncionario.TabStop = true;
            this.rbExcluirFuncionario.Text = "Funcionário";
            this.rbExcluirFuncionario.UseVisualStyleBackColor = true;
            this.rbExcluirFuncionario.CheckedChanged += new System.EventHandler(this.OpcaoDeExclusao_CheckedChanged);
            // 
            // lblSenhaExclusao
            // 
            this.lblSenhaExclusao.AutoSize = true;
            this.lblSenhaExclusao.Location = new System.Drawing.Point(17, 298);
            this.lblSenhaExclusao.Name = "lblSenhaExclusao";
            this.lblSenhaExclusao.Size = new System.Drawing.Size(102, 13);
            this.lblSenhaExclusao.TabIndex = 1;
            this.lblSenhaExclusao.Text = "Senha de Exclusão:";
            // 
            // txtSenhaExclusao
            // 
            this.txtSenhaExclusao.Location = new System.Drawing.Point(18, 314);
            this.txtSenhaExclusao.Name = "txtSenhaExclusao";
            this.txtSenhaExclusao.Size = new System.Drawing.Size(187, 20);
            this.txtSenhaExclusao.TabIndex = 0;
            // 
            // btnExcluirConfirma
            // 
            this.btnExcluirConfirma.BackColor = System.Drawing.Color.Red;
            this.btnExcluirConfirma.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcluirConfirma.Location = new System.Drawing.Point(161, 349);
            this.btnExcluirConfirma.Name = "btnExcluirConfirma";
            this.btnExcluirConfirma.Size = new System.Drawing.Size(80, 40);
            this.btnExcluirConfirma.TabIndex = 8;
            this.btnExcluirConfirma.Text = "Excluir";
            this.btnExcluirConfirma.UseVisualStyleBackColor = false;
            // 
            // btnExcluirCancelar
            // 
            this.btnExcluirCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExcluirCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcluirCancelar.Location = new System.Drawing.Point(12, 349);
            this.btnExcluirCancelar.Name = "btnExcluirCancelar";
            this.btnExcluirCancelar.Size = new System.Drawing.Size(80, 40);
            this.btnExcluirCancelar.TabIndex = 9;
            this.btnExcluirCancelar.Text = "Cancelar";
            this.btnExcluirCancelar.UseVisualStyleBackColor = false;
            this.btnExcluirCancelar.Click += new System.EventHandler(this.btnExcluirCancelar_Click);
            // 
            // pctExcluirCliente
            // 
            this.pctExcluirCliente.Image = ((System.Drawing.Image)(resources.GetObject("pctExcluirCliente.Image")));
            this.pctExcluirCliente.Location = new System.Drawing.Point(198, 49);
            this.pctExcluirCliente.Name = "pctExcluirCliente";
            this.pctExcluirCliente.Size = new System.Drawing.Size(20, 20);
            this.pctExcluirCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctExcluirCliente.TabIndex = 3;
            this.pctExcluirCliente.TabStop = false;
            this.pctExcluirCliente.Visible = false;
            // 
            // pctExcluirFuncionario
            // 
            this.pctExcluirFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("pctExcluirFuncionario.Image")));
            this.pctExcluirFuncionario.Location = new System.Drawing.Point(198, 113);
            this.pctExcluirFuncionario.Name = "pctExcluirFuncionario";
            this.pctExcluirFuncionario.Size = new System.Drawing.Size(20, 20);
            this.pctExcluirFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctExcluirFuncionario.TabIndex = 4;
            this.pctExcluirFuncionario.TabStop = false;
            this.pctExcluirFuncionario.Visible = false;
            // 
            // pctExcluirFornecedor
            // 
            this.pctExcluirFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("pctExcluirFornecedor.Image")));
            this.pctExcluirFornecedor.Location = new System.Drawing.Point(198, 182);
            this.pctExcluirFornecedor.Name = "pctExcluirFornecedor";
            this.pctExcluirFornecedor.Size = new System.Drawing.Size(20, 20);
            this.pctExcluirFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctExcluirFornecedor.TabIndex = 5;
            this.pctExcluirFornecedor.TabStop = false;
            this.pctExcluirFornecedor.Visible = false;
            // 
            // FrmExclusao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(255, 401);
            this.Controls.Add(this.btnExcluirCancelar);
            this.Controls.Add(this.btnExcluirConfirma);
            this.Controls.Add(this.rbExcluirFuncionario);
            this.Controls.Add(this.lblSenhaExclusao);
            this.Controls.Add(this.rbExcluirFornecedor);
            this.Controls.Add(this.txtSenhaExclusao);
            this.Controls.Add(this.rbExcluirCliente);
            this.Controls.Add(this.lblTituloExcluir);
            this.Controls.Add(this.gbExcluir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExclusao";
            this.Text = "Excluir registro";
            this.gbExcluir.ResumeLayout(false);
            this.gbExcluir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExcluirCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExcluirFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExcluirFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbExcluir;
        private System.Windows.Forms.Label lblApelidoCliente;
        private System.Windows.Forms.Label lblNomeFornecedor;
        private System.Windows.Forms.Label lblLoginFuncionario;
        private System.Windows.Forms.Label lblTituloExcluir;
        private System.Windows.Forms.RadioButton rbExcluirCliente;
        private System.Windows.Forms.RadioButton rbExcluirFornecedor;
        private System.Windows.Forms.RadioButton rbExcluirFuncionario;
        private System.Windows.Forms.TextBox txtExcluirCliente;
        private System.Windows.Forms.TextBox txtExcluirFornecedor;
        private System.Windows.Forms.TextBox txtExcluirFuncionario;
        private System.Windows.Forms.Label lblSenhaExclusao;
        private System.Windows.Forms.TextBox txtSenhaExclusao;
        private System.Windows.Forms.Button btnExcluirConfirma;
        private System.Windows.Forms.Button btnExcluirCancelar;
        private System.Windows.Forms.PictureBox pctExcluirFornecedor;
        private System.Windows.Forms.PictureBox pctExcluirFuncionario;
        private System.Windows.Forms.PictureBox pctExcluirCliente;
    }
}