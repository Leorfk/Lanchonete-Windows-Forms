namespace lixoneteVersao1
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pctIcone = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbLoginFuncionario = new System.Windows.Forms.GroupBox();
            this.txtSenhaFuncionario = new System.Windows.Forms.TextBox();
            this.txtLoginFuncionario = new System.Windows.Forms.TextBox();
            this.lblSenhaFuncionario = new System.Windows.Forms.Label();
            this.lblLoginFuncionario = new System.Windows.Forms.Label();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).BeginInit();
            this.gbLoginFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctIcone
            // 
            this.pctIcone.Image = ((System.Drawing.Image)(resources.GetObject("pctIcone.Image")));
            this.pctIcone.Location = new System.Drawing.Point(12, 12);
            this.pctIcone.Name = "pctIcone";
            this.pctIcone.Size = new System.Drawing.Size(100, 100);
            this.pctIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctIcone.TabIndex = 0;
            this.pctIcone.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitulo.Location = new System.Drawing.Point(119, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 26);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Larika Lanches";
            // 
            // gbLoginFuncionario
            // 
            this.gbLoginFuncionario.Controls.Add(this.txtSenhaFuncionario);
            this.gbLoginFuncionario.Controls.Add(this.txtLoginFuncionario);
            this.gbLoginFuncionario.Controls.Add(this.lblSenhaFuncionario);
            this.gbLoginFuncionario.Controls.Add(this.lblLoginFuncionario);
            this.gbLoginFuncionario.Location = new System.Drawing.Point(12, 118);
            this.gbLoginFuncionario.Name = "gbLoginFuncionario";
            this.gbLoginFuncionario.Size = new System.Drawing.Size(266, 151);
            this.gbLoginFuncionario.TabIndex = 2;
            this.gbLoginFuncionario.TabStop = false;
            this.gbLoginFuncionario.Text = "Login Funcionário";
            // 
            // txtSenhaFuncionario
            // 
            this.txtSenhaFuncionario.Location = new System.Drawing.Point(10, 103);
            this.txtSenhaFuncionario.Name = "txtSenhaFuncionario";
            this.txtSenhaFuncionario.Size = new System.Drawing.Size(228, 20);
            this.txtSenhaFuncionario.TabIndex = 3;
            this.txtSenhaFuncionario.UseSystemPasswordChar = true;
            // 
            // txtLoginFuncionario
            // 
            this.txtLoginFuncionario.Location = new System.Drawing.Point(10, 47);
            this.txtLoginFuncionario.Name = "txtLoginFuncionario";
            this.txtLoginFuncionario.Size = new System.Drawing.Size(228, 20);
            this.txtLoginFuncionario.TabIndex = 2;
            // 
            // lblSenhaFuncionario
            // 
            this.lblSenhaFuncionario.AutoSize = true;
            this.lblSenhaFuncionario.Location = new System.Drawing.Point(7, 87);
            this.lblSenhaFuncionario.Name = "lblSenhaFuncionario";
            this.lblSenhaFuncionario.Size = new System.Drawing.Size(44, 13);
            this.lblSenhaFuncionario.TabIndex = 1;
            this.lblSenhaFuncionario.Text = "Senha: ";
            // 
            // lblLoginFuncionario
            // 
            this.lblLoginFuncionario.AutoSize = true;
            this.lblLoginFuncionario.Location = new System.Drawing.Point(7, 31);
            this.lblLoginFuncionario.Name = "lblLoginFuncionario";
            this.lblLoginFuncionario.Size = new System.Drawing.Size(39, 13);
            this.lblLoginFuncionario.TabIndex = 0;
            this.lblLoginFuncionario.Text = "Login: ";
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAcessar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAcessar.Location = new System.Drawing.Point(198, 275);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(80, 40);
            this.btnAcessar.TabIndex = 4;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.Location = new System.Drawing.Point(12, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 40);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(294, 326);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.gbLoginFuncionario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pctIcone);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).EndInit();
            this.gbLoginFuncionario.ResumeLayout(false);
            this.gbLoginFuncionario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctIcone;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbLoginFuncionario;
        private System.Windows.Forms.TextBox txtSenhaFuncionario;
        private System.Windows.Forms.TextBox txtLoginFuncionario;
        private System.Windows.Forms.Label lblSenhaFuncionario;
        private System.Windows.Forms.Label lblLoginFuncionario;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Button btnCancelar;
    }
}