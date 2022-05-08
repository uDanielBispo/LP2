namespace PAtividade8
{
    partial class frmExercicio2
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
            this.btnCompara = new System.Windows.Forms.Button();
            this.txtbEntrada = new System.Windows.Forms.TextBox();
            this.lblInsiraNum = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCompara
            // 
            this.btnCompara.Location = new System.Drawing.Point(27, 114);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(331, 32);
            this.btnCompara.TabIndex = 1;
            this.btnCompara.Text = "Valor da soma";
            this.btnCompara.UseVisualStyleBackColor = true;
            this.btnCompara.Click += new System.EventHandler(this.btnCompara_Click);
            // 
            // txtbEntrada
            // 
            this.txtbEntrada.Location = new System.Drawing.Point(27, 56);
            this.txtbEntrada.Name = "txtbEntrada";
            this.txtbEntrada.Size = new System.Drawing.Size(331, 20);
            this.txtbEntrada.TabIndex = 2;
            // 
            // lblInsiraNum
            // 
            this.lblInsiraNum.AutoSize = true;
            this.lblInsiraNum.Location = new System.Drawing.Point(24, 40);
            this.lblInsiraNum.Name = "lblInsiraNum";
            this.lblInsiraNum.Size = new System.Drawing.Size(90, 13);
            this.lblInsiraNum.TabIndex = 0;
            this.lblInsiraNum.Text = "Insira um numero:";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(24, 90);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(52, 13);
            this.lblResposta.TabIndex = 3;
            this.lblResposta.Text = "Resposta";
            this.lblResposta.Visible = false;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txtbEntrada);
            this.Controls.Add(this.btnCompara);
            this.Controls.Add(this.lblInsiraNum);
            this.Name = "frmExercicio2";
            this.Text = "Exercicio 2";
            this.Load += new System.EventHandler(this.frmExercicio2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCompara;
        private System.Windows.Forms.TextBox txtbEntrada;
        private System.Windows.Forms.Label lblInsiraNum;
        private System.Windows.Forms.Label lblResposta;
    }
}