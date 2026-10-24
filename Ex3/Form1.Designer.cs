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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.chkNovo.Location = new System.Drawing.Point(121, 315);
            this.chkNovo.Name = "chkNovo";
            this.chkNovo.Size = new System.Drawing.Size(110, 20);
            this.chkNovo.TabIndex = 4;
            this.chkNovo.Text = "Véiculo Novo";
            this.chkNovo.UseVisualStyleBackColor = true;
            // 
            // btnCriarExibir
            // 
            this.btnCriarExibir.Location = new System.Drawing.Point(121, 375);
            this.btnCriarExibir.Name = "btnCriarExibir";
            this.btnCriarExibir.Size = new System.Drawing.Size(598, 42);
            this.btnCriarExibir.TabIndex = 5;
            this.btnCriarExibir.Text = "Criar e exibir veiculo";
            this.btnCriarExibir.UseVisualStyleBackColor = true;
            this.btnCriarExibir.Click += new System.EventHandler(this.btnCriarExibir_Click);
            // 
            // pictureBoxCarro
            // 
            this.pictureBoxCarro.Location = new System.Drawing.Point(334, 94);
            this.pictureBoxCarro.Name = "pictureBoxCarro";
            this.pictureBoxCarro.Size = new System.Drawing.Size(173, 179);
            this.pictureBoxCarro.TabIndex = 6;
            this.pictureBoxCarro.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(566, 94);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(44, 16);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "label1";
            this.lblResultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.pictureBoxCarro);
            this.Controls.Add(this.btnCriarExibir);
            this.Controls.Add(this.chkNovo);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Name = "Form1";
            this.Text = "Dados do veiculo";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

