namespace PVolume
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EntradaRaio = new System.Windows.Forms.TextBox();
            this.EntradaAltura = new System.Windows.Forms.TextBox();
            this.InputVolume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EntradaRaio
            // 
            this.EntradaRaio.Location = new System.Drawing.Point(70, 12);
            this.EntradaRaio.Name = "EntradaRaio";
            this.EntradaRaio.Size = new System.Drawing.Size(115, 20);
            this.EntradaRaio.TabIndex = 2;
            this.EntradaRaio.Validated += new System.EventHandler(this.EntradaRaio_Validated);
            // 
            // EntradaAltura
            // 
            this.EntradaAltura.Location = new System.Drawing.Point(70, 42);
            this.EntradaAltura.Name = "EntradaAltura";
            this.EntradaAltura.Size = new System.Drawing.Size(115, 20);
            this.EntradaAltura.TabIndex = 3;
            this.EntradaAltura.Validated += new System.EventHandler(this.EntradaAltura_Validated);
            // 
            // InputVolume
            // 
            this.InputVolume.Location = new System.Drawing.Point(70, 72);
            this.InputVolume.Name = "InputVolume";
            this.InputVolume.ReadOnly = true;
            this.InputVolume.Size = new System.Drawing.Size(115, 20);
            this.InputVolume.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Raio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Altura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Volume:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 145);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputVolume);
            this.Controls.Add(this.EntradaAltura);
            this.Controls.Add(this.EntradaRaio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "PVolume";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox EntradaRaio;
        private System.Windows.Forms.TextBox EntradaAltura;
        private System.Windows.Forms.TextBox InputVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

