namespace PAtividade8
{
    partial class frmExercicio1
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
            this.btnQtdEspacos = new System.Windows.Forms.Button();
            this.QtdLetraR = new System.Windows.Forms.Button();
            this.QtdDePares = new System.Windows.Forms.Button();
            this.rchtxtEntrada = new System.Windows.Forms.RichTextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQtdEspacos
            // 
            this.btnQtdEspacos.Location = new System.Drawing.Point(26, 208);
            this.btnQtdEspacos.Name = "btnQtdEspacos";
            this.btnQtdEspacos.Size = new System.Drawing.Size(128, 41);
            this.btnQtdEspacos.TabIndex = 0;
            this.btnQtdEspacos.Text = "Espaços em branco";
            this.btnQtdEspacos.UseVisualStyleBackColor = true;
            this.btnQtdEspacos.Click += new System.EventHandler(this.btnQtdEspacos_Click);
            // 
            // QtdLetraR
            // 
            this.QtdLetraR.Location = new System.Drawing.Point(160, 208);
            this.QtdLetraR.Name = "QtdLetraR";
            this.QtdLetraR.Size = new System.Drawing.Size(128, 41);
            this.QtdLetraR.TabIndex = 1;
            this.QtdLetraR.Text = "Quantidade de letras \'R\'";
            this.QtdLetraR.UseVisualStyleBackColor = true;
            this.QtdLetraR.Click += new System.EventHandler(this.QtdLetraR_Click);
            // 
            // QtdDePares
            // 
            this.QtdDePares.Location = new System.Drawing.Point(294, 208);
            this.QtdDePares.Name = "QtdDePares";
            this.QtdDePares.Size = new System.Drawing.Size(128, 41);
            this.QtdDePares.TabIndex = 2;
            this.QtdDePares.Text = "Quantidade de Pares";
            this.QtdDePares.UseVisualStyleBackColor = true;
            this.QtdDePares.Click += new System.EventHandler(this.QtdDePares_Click);
            // 
            // rchtxtEntrada
            // 
            this.rchtxtEntrada.Location = new System.Drawing.Point(26, 12);
            this.rchtxtEntrada.MaxLength = 255;
            this.rchtxtEntrada.Name = "rchtxtEntrada";
            this.rchtxtEntrada.Size = new System.Drawing.Size(396, 162);
            this.rchtxtEntrada.TabIndex = 3;
            this.rchtxtEntrada.Text = "";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(23, 184);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(52, 13);
            this.lblResposta.TabIndex = 4;
            this.lblResposta.Text = "Resposta";
            this.lblResposta.Visible = false;
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 261);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.rchtxtEntrada);
            this.Controls.Add(this.QtdDePares);
            this.Controls.Add(this.QtdLetraR);
            this.Controls.Add(this.btnQtdEspacos);
            this.Name = "frmExercicio1";
            this.Text = "Exercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQtdEspacos;
        private System.Windows.Forms.Button QtdLetraR;
        private System.Windows.Forms.Button QtdDePares;
        private System.Windows.Forms.RichTextBox rchtxtEntrada;
        private System.Windows.Forms.Label lblResposta;
    }
}