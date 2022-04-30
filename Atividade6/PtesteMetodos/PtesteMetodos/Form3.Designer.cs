
namespace PtesteMetodos
{
    partial class formExercicio3
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
            this.btnRemove1 = new System.Windows.Forms.Button();
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.btnInverte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRemove1
            // 
            this.btnRemove1.Location = new System.Drawing.Point(47, 127);
            this.btnRemove1.Name = "btnRemove1";
            this.btnRemove1.Size = new System.Drawing.Size(103, 51);
            this.btnRemove1.TabIndex = 0;
            this.btnRemove1.Text = "Remove Ocorrencias";
            this.btnRemove1.UseVisualStyleBackColor = true;
            this.btnRemove1.Click += new System.EventHandler(this.btnRemove1_Click);
            // 
            // btnRemove2
            // 
            this.btnRemove2.Location = new System.Drawing.Point(156, 127);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(104, 51);
            this.btnRemove2.TabIndex = 1;
            this.btnRemove2.Text = "remove ocorrencias (replace)";
            this.btnRemove2.UseVisualStyleBackColor = true;
            this.btnRemove2.Click += new System.EventHandler(this.btnRemove2_Click);
            // 
            // btnInverte
            // 
            this.btnInverte.Location = new System.Drawing.Point(266, 127);
            this.btnInverte.Name = "btnInverte";
            this.btnInverte.Size = new System.Drawing.Size(103, 51);
            this.btnInverte.TabIndex = 2;
            this.btnInverte.Text = "Inverte";
            this.btnInverte.UseVisualStyleBackColor = true;
            this.btnInverte.Click += new System.EventHandler(this.btnInverte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "palavra 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "palavra 2";
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(49, 42);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(320, 20);
            this.txtPalavra1.TabIndex = 7;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(49, 86);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(320, 20);
            this.txtPalavra2.TabIndex = 8;
            // 
            // formExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 345);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInverte);
            this.Controls.Add(this.btnRemove2);
            this.Controls.Add(this.btnRemove1);
            this.Name = "formExercicio3";
            this.Text = "formExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove1;
        private System.Windows.Forms.Button btnRemove2;
        private System.Windows.Forms.Button btnInverte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
    }
}