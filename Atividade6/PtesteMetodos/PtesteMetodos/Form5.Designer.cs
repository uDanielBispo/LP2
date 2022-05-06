
namespace PtesteMetodos
{
    partial class formExercicio5
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
            this.txtbN1 = new System.Windows.Forms.TextBox();
            this.txtbN2 = new System.Windows.Forms.TextBox();
            this.btnSorteio = new System.Windows.Forms.Button();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbN1
            // 
            this.txtbN1.Location = new System.Drawing.Point(60, 84);
            this.txtbN1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbN1.Name = "txtbN1";
            this.txtbN1.Size = new System.Drawing.Size(346, 26);
            this.txtbN1.TabIndex = 0;
            // 
            // txtbN2
            // 
            this.txtbN2.Location = new System.Drawing.Point(60, 146);
            this.txtbN2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbN2.Name = "txtbN2";
            this.txtbN2.Size = new System.Drawing.Size(346, 26);
            this.txtbN2.TabIndex = 1;
            // 
            // btnSorteio
            // 
            this.btnSorteio.Location = new System.Drawing.Point(58, 224);
            this.btnSorteio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSorteio.Name = "btnSorteio";
            this.btnSorteio.Size = new System.Drawing.Size(348, 62);
            this.btnSorteio.TabIndex = 2;
            this.btnSorteio.Text = "Sortear";
            this.btnSorteio.UseVisualStyleBackColor = true;
            this.btnSorteio.Click += new System.EventHandler(this.btnSorteio_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(60, 62);
            this.lblNum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(80, 18);
            this.lblNum1.TabIndex = 3;
            this.lblNum1.Text = "Numero 1:";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(60, 124);
            this.lblNum2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(80, 18);
            this.lblNum2.TabIndex = 4;
            this.lblNum2.Text = "Numero 2:";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(57, 192);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(50, 18);
            this.lblResposta.TabIndex = 5;
            this.lblResposta.Text = "label1";
            this.lblResposta.Visible = false;
            // 
            // formExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.btnSorteio);
            this.Controls.Add(this.txtbN2);
            this.Controls.Add(this.txtbN1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formExercicio5";
            this.Text = "formExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbN1;
        private System.Windows.Forms.TextBox txtbN2;
        private System.Windows.Forms.Button btnSorteio;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblResposta;
    }
}