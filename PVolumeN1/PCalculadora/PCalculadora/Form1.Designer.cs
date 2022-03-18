namespace PCalculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Limpar = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.Divisao = new System.Windows.Forms.Button();
            this.Soma = new System.Windows.Forms.Button();
            this.Subtracao = new System.Windows.Forms.Button();
            this.Multiplicacao = new System.Windows.Forms.Button();
            this.EntradaN1 = new System.Windows.Forms.TextBox();
            this.EntradaN2 = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "1º Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "2º Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado :";
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(305, 44);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(75, 33);
            this.Limpar.TabIndex = 7;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(305, 83);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(75, 30);
            this.Sair.TabIndex = 8;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Divisao
            // 
            this.Divisao.Location = new System.Drawing.Point(255, 135);
            this.Divisao.Name = "Divisao";
            this.Divisao.Size = new System.Drawing.Size(44, 23);
            this.Divisao.TabIndex = 6;
            this.Divisao.Text = "/";
            this.Divisao.UseVisualStyleBackColor = true;
            this.Divisao.Click += new System.EventHandler(this.Divisao_Click);
            // 
            // Soma
            // 
            this.Soma.Location = new System.Drawing.Point(105, 135);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(44, 23);
            this.Soma.TabIndex = 3;
            this.Soma.Text = "+";
            this.Soma.UseVisualStyleBackColor = true;
            this.Soma.Click += new System.EventHandler(this.Soma_Click);
            // 
            // Subtracao
            // 
            this.Subtracao.Location = new System.Drawing.Point(155, 135);
            this.Subtracao.Name = "Subtracao";
            this.Subtracao.Size = new System.Drawing.Size(44, 23);
            this.Subtracao.TabIndex = 4;
            this.Subtracao.Text = "-";
            this.Subtracao.UseVisualStyleBackColor = true;
            this.Subtracao.Click += new System.EventHandler(this.Subtracao_Click);
            // 
            // Multiplicacao
            // 
            this.Multiplicacao.Location = new System.Drawing.Point(205, 135);
            this.Multiplicacao.Name = "Multiplicacao";
            this.Multiplicacao.Size = new System.Drawing.Size(44, 23);
            this.Multiplicacao.TabIndex = 5;
            this.Multiplicacao.Text = "*";
            this.Multiplicacao.UseVisualStyleBackColor = true;
            this.Multiplicacao.Click += new System.EventHandler(this.Multiplicacao_Click);
            // 
            // EntradaN1
            // 
            this.EntradaN1.Location = new System.Drawing.Point(105, 32);
            this.EntradaN1.Name = "EntradaN1";
            this.EntradaN1.Size = new System.Drawing.Size(194, 26);
            this.EntradaN1.TabIndex = 1;
            this.EntradaN1.Validated += new System.EventHandler(this.EntradaN1_Validated);
            // 
            // EntradaN2
            // 
            this.EntradaN2.Location = new System.Drawing.Point(105, 69);
            this.EntradaN2.Name = "EntradaN2";
            this.EntradaN2.Size = new System.Drawing.Size(194, 26);
            this.EntradaN2.TabIndex = 2;
            this.EntradaN2.Validated += new System.EventHandler(this.EntradaN2_Validated);
            // 
            // Resultado
            // 
            this.Resultado.Enabled = false;
            this.Resultado.Location = new System.Drawing.Point(105, 103);
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Size = new System.Drawing.Size(194, 26);
            this.Resultado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 188);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.EntradaN2);
            this.Controls.Add(this.EntradaN1);
            this.Controls.Add(this.Multiplicacao);
            this.Controls.Add(this.Subtracao);
            this.Controls.Add(this.Soma);
            this.Controls.Add(this.Divisao);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "PCalculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button Divisao;
        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button Subtracao;
        private System.Windows.Forms.Button Multiplicacao;
        private System.Windows.Forms.TextBox EntradaN1;
        private System.Windows.Forms.TextBox EntradaN2;
        private System.Windows.Forms.TextBox Resultado;
    }
}

