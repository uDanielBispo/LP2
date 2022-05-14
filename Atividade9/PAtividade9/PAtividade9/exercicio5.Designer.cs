namespace PAtividade9
{
    partial class frmExercicio5
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblMatriz = new System.Windows.Forms.Label();
            this.lblMedias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(597, 45);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(141, 55);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblMatriz
            // 
            this.lblMatriz.AutoSize = true;
            this.lblMatriz.Location = new System.Drawing.Point(39, 45);
            this.lblMatriz.Name = "lblMatriz";
            this.lblMatriz.Size = new System.Drawing.Size(35, 13);
            this.lblMatriz.TabIndex = 1;
            this.lblMatriz.Text = "Notas";
            // 
            // lblMedias
            // 
            this.lblMedias.AutoSize = true;
            this.lblMedias.Location = new System.Drawing.Point(279, 45);
            this.lblMedias.Name = "lblMedias";
            this.lblMedias.Size = new System.Drawing.Size(41, 13);
            this.lblMedias.TabIndex = 2;
            this.lblMedias.Text = "Medias";
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 439);
            this.Controls.Add(this.lblMedias);
            this.Controls.Add(this.lblMatriz);
            this.Controls.Add(this.btnVerificar);
            this.Name = "frmExercicio5";
            this.Text = "exercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblMatriz;
        private System.Windows.Forms.Label lblMedias;
    }
}