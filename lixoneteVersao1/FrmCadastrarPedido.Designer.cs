namespace lixoneteVersao1
{
    partial class FrmCadastrarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarPedido));
            this.pctPedido = new System.Windows.Forms.PictureBox();
            this.lblTituloPedido = new System.Windows.Forms.Label();
            this.gbPedidoComida = new System.Windows.Forms.GroupBox();
            this.clbMenuPedido = new System.Windows.Forms.CheckedListBox();
            this.gbPedidoBebida = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnConfirmarPedido = new System.Windows.Forms.Button();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.lblValortotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPedido)).BeginInit();
            this.gbPedidoComida.SuspendLayout();
            this.gbPedidoBebida.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctPedido
            // 
            this.pctPedido.Image = ((System.Drawing.Image)(resources.GetObject("pctPedido.Image")));
            this.pctPedido.Location = new System.Drawing.Point(12, 12);
            this.pctPedido.Name = "pctPedido";
            this.pctPedido.Size = new System.Drawing.Size(80, 80);
            this.pctPedido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPedido.TabIndex = 0;
            this.pctPedido.TabStop = false;
            // 
            // lblTituloPedido
            // 
            this.lblTituloPedido.AutoSize = true;
            this.lblTituloPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTituloPedido.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTituloPedido.Location = new System.Drawing.Point(98, 51);
            this.lblTituloPedido.Name = "lblTituloPedido";
            this.lblTituloPedido.Size = new System.Drawing.Size(182, 20);
            this.lblTituloPedido.TabIndex = 1;
            this.lblTituloPedido.Text = "Anotar Pedido do cliente";
            // 
            // gbPedidoComida
            // 
            this.gbPedidoComida.Controls.Add(this.clbMenuPedido);
            this.gbPedidoComida.Location = new System.Drawing.Point(12, 98);
            this.gbPedidoComida.Name = "gbPedidoComida";
            this.gbPedidoComida.Size = new System.Drawing.Size(220, 187);
            this.gbPedidoComida.TabIndex = 2;
            this.gbPedidoComida.TabStop = false;
            this.gbPedidoComida.Text = "Menu de comidas";
            // 
            // clbMenuPedido
            // 
            this.clbMenuPedido.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.clbMenuPedido.FormattingEnabled = true;
            this.clbMenuPedido.Location = new System.Drawing.Point(6, 19);
            this.clbMenuPedido.Name = "clbMenuPedido";
            this.clbMenuPedido.Size = new System.Drawing.Size(208, 139);
            this.clbMenuPedido.TabIndex = 0;
            // 
            // gbPedidoBebida
            // 
            this.gbPedidoBebida.Controls.Add(this.checkedListBox1);
            this.gbPedidoBebida.Location = new System.Drawing.Point(238, 98);
            this.gbPedidoBebida.Name = "gbPedidoBebida";
            this.gbPedidoBebida.Size = new System.Drawing.Size(220, 187);
            this.gbPedidoBebida.TabIndex = 3;
            this.gbPedidoBebida.TabStop = false;
            this.gbPedidoBebida.Text = "Menu de bebidas";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(208, 139);
            this.checkedListBox1.TabIndex = 0;
            // 
            // btnConfirmarPedido
            // 
            this.btnConfirmarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirmarPedido.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConfirmarPedido.Location = new System.Drawing.Point(380, 291);
            this.btnConfirmarPedido.Name = "btnConfirmarPedido";
            this.btnConfirmarPedido.Size = new System.Drawing.Size(80, 40);
            this.btnConfirmarPedido.TabIndex = 1;
            this.btnConfirmarPedido.Text = "Confirmar";
            this.btnConfirmarPedido.UseVisualStyleBackColor = false;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelarPedido.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelarPedido.Location = new System.Drawing.Point(12, 291);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(80, 40);
            this.btnCancelarPedido.TabIndex = 2;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = false;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // lblValortotal
            // 
            this.lblValortotal.AutoSize = true;
            this.lblValortotal.Location = new System.Drawing.Point(235, 295);
            this.lblValortotal.Name = "lblValortotal";
            this.lblValortotal.Size = new System.Drawing.Size(58, 13);
            this.lblValortotal.TabIndex = 4;
            this.lblValortotal.Text = "Valor Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // FrmCadastrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(472, 343);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblValortotal);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.btnConfirmarPedido);
            this.Controls.Add(this.gbPedidoBebida);
            this.Controls.Add(this.gbPedidoComida);
            this.Controls.Add(this.lblTituloPedido);
            this.Controls.Add(this.pctPedido);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarPedido";
            this.Text = "Anotar Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.pctPedido)).EndInit();
            this.gbPedidoComida.ResumeLayout(false);
            this.gbPedidoBebida.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctPedido;
        private System.Windows.Forms.Label lblTituloPedido;
        private System.Windows.Forms.GroupBox gbPedidoComida;
        private System.Windows.Forms.CheckedListBox clbMenuPedido;
        private System.Windows.Forms.GroupBox gbPedidoBebida;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnConfirmarPedido;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Label lblValortotal;
        private System.Windows.Forms.TextBox textBox1;
    }
}