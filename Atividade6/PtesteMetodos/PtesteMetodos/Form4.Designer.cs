
namespace PtesteMetodos
{
    partial class formExercicio4
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
            this.rctxtbExercicio4 = new System.Windows.Forms.RichTextBox();
            this.btnQtdNumericos = new System.Windows.Forms.Button();
            this.btnCaractereBranco = new System.Windows.Forms.Button();
            this.btnAlfabetico = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rctxtbExercicio4
            // 
            this.rctxtbExercicio4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rctxtbExercicio4.Location = new System.Drawing.Point(42, 36);
            this.rctxtbExercicio4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rctxtbExercicio4.Name = "rctxtbExercicio4";
            this.rctxtbExercicio4.Size = new System.Drawing.Size(391, 163);
            this.rctxtbExercicio4.TabIndex = 0;
            this.rctxtbExercicio4.Text = "";
            // 
            // btnQtdNumericos
            // 
            this.btnQtdNumericos.Location = new System.Drawing.Point(18, 300);
            this.btnQtdNumericos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQtdNumericos.Name = "btnQtdNumericos";
            this.btnQtdNumericos.Size = new System.Drawing.Size(141, 48);
            this.btnQtdNumericos.TabIndex = 1;
            this.btnQtdNumericos.Text = "quantidade de numeros";
            this.btnQtdNumericos.UseVisualStyleBackColor = true;
            this.btnQtdNumericos.Click += new System.EventHandler(this.btnQtdNumericos_Click);
            // 
            // btnCaractereBranco
            // 
            this.btnCaractereBranco.Location = new System.Drawing.Point(167, 300);
            this.btnCaractereBranco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCaractereBranco.Name = "btnCaractereBranco";
            this.btnCaractereBranco.Size = new System.Drawing.Size(141, 48);
            this.btnCaractereBranco.TabIndex = 2;
            this.btnCaractereBranco.Text = "Primeiro caractere branco";
            this.btnCaractereBranco.UseVisualStyleBackColor = true;
            this.btnCaractereBranco.Click += new System.EventHandler(this.btnCaractereBranco_Click);
            // 
            // btnAlfabetico
            // 
            this.btnAlfabetico.Location = new System.Drawing.Point(316, 300);
            this.btnAlfabetico.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlfabetico.Name = "btnAlfabetico";
            this.btnAlfabetico.Size = new System.Drawing.Size(141, 48);
            this.btnAlfabetico.TabIndex = 4;
            this.btnAlfabetico.Text = "Caracteres alfabéticos";
            this.btnAlfabetico.UseVisualStyleBackColor = true;
            this.btnAlfabetico.Click += new System.EventHandler(this.btnAlfabetico_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(42, 242);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(50, 18);
            this.lblResposta.TabIndex = 5;
            this.lblResposta.Text = "label1";
            this.lblResposta.Visible = false;
            // 
            // formExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnAlfabetico);
            this.Controls.Add(this.btnCaractereBranco);
            this.Controls.Add(this.btnQtdNumericos);
            this.Controls.Add(this.rctxtbExercicio4);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formExercicio4";
            this.Text = "formExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rctxtbExercicio4;
        private System.Windows.Forms.Button btnQtdNumericos;
        private System.Windows.Forms.Button btnCaractereBranco;
        private System.Windows.Forms.Button btnAlfabetico;
        private System.Windows.Forms.Label lblResposta;
    }
}