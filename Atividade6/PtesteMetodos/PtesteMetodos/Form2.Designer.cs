
namespace PtesteMetodos
{
    partial class formExercicio2
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
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.btnTeste = new System.Windows.Forms.Button();
            this.btnMesclar = new System.Windows.Forms.Button();
            this.btnInserirAsterisco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(19, 55);
            this.lblPalavra1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(78, 18);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra 1:";
            this.lblPalavra1.Click += new System.EventHandler(this.lblPalavra1_Click);
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(24, 79);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(433, 26);
            this.txtPalavra1.TabIndex = 1;
            this.txtPalavra1.TextChanged += new System.EventHandler(this.txtPalavra1_TextChanged);
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(24, 154);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(433, 26);
            this.txtPalavra2.TabIndex = 3;
            this.txtPalavra2.TextChanged += new System.EventHandler(this.txtPalavra2_TextChanged);
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(19, 132);
            this.lblPalavra2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(78, 18);
            this.lblPalavra2.TabIndex = 2;
            this.lblPalavra2.Text = "Palavra 2:";
            this.lblPalavra2.Click += new System.EventHandler(this.lblPalavra2_Click);
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(24, 201);
            this.btnTeste.Margin = new System.Windows.Forms.Padding(4);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(128, 79);
            this.btnTeste.TabIndex = 4;
            this.btnTeste.Text = "Testar Iguais";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // btnMesclar
            // 
            this.btnMesclar.Location = new System.Drawing.Point(172, 201);
            this.btnMesclar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMesclar.Name = "btnMesclar";
            this.btnMesclar.Size = new System.Drawing.Size(134, 80);
            this.btnMesclar.TabIndex = 5;
            this.btnMesclar.Text = "Inserir texto 1 na palavra 2";
            this.btnMesclar.UseVisualStyleBackColor = true;
            this.btnMesclar.Click += new System.EventHandler(this.btnMesclar_Click);
            // 
            // btnInserirAsterisco
            // 
            this.btnInserirAsterisco.Location = new System.Drawing.Point(326, 201);
            this.btnInserirAsterisco.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserirAsterisco.Name = "btnInserirAsterisco";
            this.btnInserirAsterisco.Size = new System.Drawing.Size(131, 82);
            this.btnInserirAsterisco.TabIndex = 6;
            this.btnInserirAsterisco.Text = "Inserir Asteriscos na palavra 2";
            this.btnInserirAsterisco.UseVisualStyleBackColor = true;
            this.btnInserirAsterisco.Click += new System.EventHandler(this.btnInserirAsterisco_Click);
            // 
            // formExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnInserirAsterisco);
            this.Controls.Add(this.btnMesclar);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.lblPalavra1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formExercicio2";
            this.Text = "formExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Button btnMesclar;
        private System.Windows.Forms.Button btnInserirAsterisco;
    }
}