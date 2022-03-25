namespace PVolumeN1
{
    partial class PVolume
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
            this.InputRaio = new System.Windows.Forms.TextBox();
            this.InputAltura = new System.Windows.Forms.TextBox();
            this.InputVolume = new System.Windows.Forms.TextBox();
            this.LabelRaio = new System.Windows.Forms.Label();
            this.LabelAltura = new System.Windows.Forms.Label();
            this.LabelVolume = new System.Windows.Forms.Label();
            this.Fechar = new System.Windows.Forms.Button();
            this.Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputRaio
            // 
            this.InputRaio.Location = new System.Drawing.Point(106, 35);
            this.InputRaio.Name = "InputRaio";
            this.InputRaio.Size = new System.Drawing.Size(100, 20);
            this.InputRaio.TabIndex = 0;
            this.InputRaio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.InputRaio.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // InputAltura
            // 
            this.InputAltura.Location = new System.Drawing.Point(106, 71);
            this.InputAltura.Name = "InputAltura";
            this.InputAltura.Size = new System.Drawing.Size(100, 20);
            this.InputAltura.TabIndex = 1;
            this.InputAltura.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.InputAltura.Validated += new System.EventHandler(this.InputAltura_Validated);
            // 
            // InputVolume
            // 
            this.InputVolume.Location = new System.Drawing.Point(106, 107);
            this.InputVolume.Name = "InputVolume";
            this.InputVolume.ReadOnly = true;
            this.InputVolume.Size = new System.Drawing.Size(100, 20);
            this.InputVolume.TabIndex = 2;
            this.InputVolume.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.InputVolume.Validated += new System.EventHandler(this.InputVolume_Validated);
            // 
            // LabelRaio
            // 
            this.LabelRaio.AutoSize = true;
            this.LabelRaio.Location = new System.Drawing.Point(36, 42);
            this.LabelRaio.Name = "LabelRaio";
            this.LabelRaio.Size = new System.Drawing.Size(32, 13);
            this.LabelRaio.TabIndex = 3;
            this.LabelRaio.Text = "Raio:";
            // 
            // LabelAltura
            // 
            this.LabelAltura.AutoSize = true;
            this.LabelAltura.Location = new System.Drawing.Point(36, 78);
            this.LabelAltura.Name = "LabelAltura";
            this.LabelAltura.Size = new System.Drawing.Size(37, 13);
            this.LabelAltura.TabIndex = 4;
            this.LabelAltura.Text = "Altura:";
            this.LabelAltura.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelVolume
            // 
            this.LabelVolume.AutoSize = true;
            this.LabelVolume.Location = new System.Drawing.Point(36, 114);
            this.LabelVolume.Name = "LabelVolume";
            this.LabelVolume.Size = new System.Drawing.Size(45, 13);
            this.LabelVolume.TabIndex = 5;
            this.LabelVolume.Text = "Volume:";
            this.LabelVolume.Click += new System.EventHandler(this.label3_Click);
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(39, 152);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(75, 23);
            this.Fechar.TabIndex = 6;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(131, 152);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 7;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            // 
            // PVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 205);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.LabelVolume);
            this.Controls.Add(this.LabelAltura);
            this.Controls.Add(this.LabelRaio);
            this.Controls.Add(this.InputVolume);
            this.Controls.Add(this.InputAltura);
            this.Controls.Add(this.InputRaio);
            this.Name = "PVolume";
            this.Text = "PVolume";
            this.Load += new System.EventHandler(this.PVolume_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputRaio;
        private System.Windows.Forms.TextBox InputAltura;
        private System.Windows.Forms.TextBox InputVolume;
        private System.Windows.Forms.Label LabelRaio;
        private System.Windows.Forms.Label LabelAltura;
        private System.Windows.Forms.Label LabelVolume;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Button Calcular;
    }
}

