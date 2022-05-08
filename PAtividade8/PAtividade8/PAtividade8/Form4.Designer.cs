namespace PAtividade8
{
    partial class frmExercicio3
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
            this.txtbEntrada = new System.Windows.Forms.Button();
            this.lblTxtBoxPalindromo = new System.Windows.Forms.Label();
            this.txtbEntradaTexto = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbEntrada
            // 
            this.txtbEntrada.Location = new System.Drawing.Point(50, 132);
            this.txtbEntrada.Name = "txtbEntrada";
            this.txtbEntrada.Size = new System.Drawing.Size(315, 23);
            this.txtbEntrada.TabIndex = 0;
            this.txtbEntrada.Text = "Verificar se é palindromo";
            this.txtbEntrada.UseVisualStyleBackColor = true;
            this.txtbEntrada.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTxtBoxPalindromo
            // 
            this.lblTxtBoxPalindromo.AutoSize = true;
            this.lblTxtBoxPalindromo.Location = new System.Drawing.Point(47, 56);
            this.lblTxtBoxPalindromo.Name = "lblTxtBoxPalindromo";
            this.lblTxtBoxPalindromo.Size = new System.Drawing.Size(84, 13);
            this.lblTxtBoxPalindromo.TabIndex = 1;
            this.lblTxtBoxPalindromo.Text = "digite uma frase:";
            // 
            // txtbEntradaTexto
            // 
            this.txtbEntradaTexto.Location = new System.Drawing.Point(50, 72);
            this.txtbEntradaTexto.Name = "txtbEntradaTexto";
            this.txtbEntradaTexto.Size = new System.Drawing.Size(315, 20);
            this.txtbEntradaTexto.TabIndex = 2;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(47, 105);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(52, 13);
            this.lblResposta.TabIndex = 3;
            this.lblResposta.Text = "Resposta";
            this.lblResposta.Visible = false;
            this.lblResposta.Click += new System.EventHandler(this.lblResposta_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txtbEntradaTexto);
            this.Controls.Add(this.lblTxtBoxPalindromo);
            this.Controls.Add(this.txtbEntrada);
            this.Name = "frmExercicio3";
            this.Text = "Exercicio 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtbEntrada;
        private System.Windows.Forms.Label lblTxtBoxPalindromo;
        private System.Windows.Forms.TextBox txtbEntradaTexto;
        private System.Windows.Forms.Label lblResposta;
    }
}