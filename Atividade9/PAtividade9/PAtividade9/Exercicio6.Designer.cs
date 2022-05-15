namespace PAtividade9
{
    partial class frmExercicio6
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
            this.ltbNomes = new System.Windows.Forms.ListBox();
            this.btnExercutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltbNomes
            // 
            this.ltbNomes.FormattingEnabled = true;
            this.ltbNomes.Location = new System.Drawing.Point(25, 26);
            this.ltbNomes.Name = "ltbNomes";
            this.ltbNomes.Size = new System.Drawing.Size(370, 303);
            this.ltbNomes.TabIndex = 0;
            // 
            // btnExercutar
            // 
            this.btnExercutar.Location = new System.Drawing.Point(420, 26);
            this.btnExercutar.Name = "btnExercutar";
            this.btnExercutar.Size = new System.Drawing.Size(140, 108);
            this.btnExercutar.TabIndex = 1;
            this.btnExercutar.Text = "Executar";
            this.btnExercutar.UseVisualStyleBackColor = true;
            this.btnExercutar.Click += new System.EventHandler(this.btnExercutar_Click);
            // 
            // frmExercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExercutar);
            this.Controls.Add(this.ltbNomes);
            this.Name = "frmExercicio6";
            this.Text = "Exercicio6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltbNomes;
        private System.Windows.Forms.Button btnExercutar;
    }
}