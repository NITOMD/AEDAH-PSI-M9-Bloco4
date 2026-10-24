namespace Ex3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.chkNovo = new System.Windows.Forms.CheckBox();
            this.btnCriarExibir = new System.Windows.Forms.Button();
            this.pictureBoxCarro = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(121, 94);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 22);
            this.txtMarca.TabIndex = 0;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(121, 142);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 22);
            this.txtModelo.TabIndex = 1;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(121, 189);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 22);
            this.txtAno.TabIndex = 2;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(121, 239);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 22);
            this.txtCor.TabIndex = 3;
            // 
            // chkNovo
            // 
            this.chkNovo.AutoSize = true;
            this.chkNovo.Location = new System.Drawing.Point(121, 342);
            this.chkNovo.Name = "chkNovo";
            this.chkNovo.Size = new System.Drawing.Size(95, 20);
            this.chkNovo.TabIndex = 4;
            this.chkNovo.Text = "checkBox1";
            this.chkNovo.UseVisualStyleBackColor = true;
            // 
            // btnCriarExibir
            // 
            this.btnCriarExibir.Location = new System.Drawing.Point(257, 375);
            this.btnCriarExibir.Name = "btnCriarExibir";
            this.btnCriarExibir.Size = new System.Drawing.Size(237, 42);
            this.btnCriarExibir.TabIndex = 5;
            this.btnCriarExibir.Text = "button1";
            this.btnCriarExibir.UseVisualStyleBackColor = true;
            this.btnCriarExibir.Click += new System.EventHandler(this.btnCriarExibir_Click);
            // 
            // pictureBoxCarro
            // 
            this.pictureBoxCarro.Location = new System.Drawing.Point(273, 94);
            this.pictureBoxCarro.Name = "pictureBoxCarro";
            this.pictureBoxCarro.Size = new System.Drawing.Size(173, 179);
            this.pictureBoxCarro.TabIndex = 6;
            this.pictureBoxCarro.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(497, 95);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(44, 16);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "label1";
            this.lblResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.pictureBoxCarro);
            this.Controls.Add(this.btnCriarExibir);
            this.Controls.Add(this.chkNovo);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.CheckBox chkNovo;
        private System.Windows.Forms.Button btnCriarExibir;
        private System.Windows.Forms.PictureBox pictureBoxCarro;
        private System.Windows.Forms.Label lblResultado;
    }
}

