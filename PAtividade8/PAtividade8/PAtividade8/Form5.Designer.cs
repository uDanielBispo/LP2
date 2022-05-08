namespace PAtividade8
{
    partial class frmExercicio4
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
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbCargo = new System.Windows.Forms.TextBox();
            this.txtbMatri = new System.Windows.Forms.TextBox();
            this.txtbProd = new System.Windows.Forms.TextBox();
            this.txtbSal = new System.Windows.Forms.TextBox();
            this.txtGrat = new System.Windows.Forms.TextBox();
            this.btnCalcularSal = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(27, 37);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(100, 20);
            this.txtbNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Matrícula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Produção";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gratificação";
            // 
            // txtbCargo
            // 
            this.txtbCargo.Location = new System.Drawing.Point(27, 85);
            this.txtbCargo.Name = "txtbCargo";
            this.txtbCargo.Size = new System.Drawing.Size(100, 20);
            this.txtbCargo.TabIndex = 7;
            // 
            // txtbMatri
            // 
            this.txtbMatri.Location = new System.Drawing.Point(27, 135);
            this.txtbMatri.Name = "txtbMatri";
            this.txtbMatri.Size = new System.Drawing.Size(100, 20);
            this.txtbMatri.TabIndex = 8;
            // 
            // txtbProd
            // 
            this.txtbProd.Location = new System.Drawing.Point(149, 37);
            this.txtbProd.Name = "txtbProd";
            this.txtbProd.Size = new System.Drawing.Size(100, 20);
            this.txtbProd.TabIndex = 9;
            // 
            // txtbSal
            // 
            this.txtbSal.Location = new System.Drawing.Point(149, 85);
            this.txtbSal.Name = "txtbSal";
            this.txtbSal.Size = new System.Drawing.Size(100, 20);
            this.txtbSal.TabIndex = 10;
            // 
            // txtGrat
            // 
            this.txtGrat.Location = new System.Drawing.Point(149, 135);
            this.txtGrat.Name = "txtGrat";
            this.txtGrat.Size = new System.Drawing.Size(100, 20);
            this.txtGrat.TabIndex = 11;
            // 
            // btnCalcularSal
            // 
            this.btnCalcularSal.Location = new System.Drawing.Point(27, 184);
            this.btnCalcularSal.Name = "btnCalcularSal";
            this.btnCalcularSal.Size = new System.Drawing.Size(222, 32);
            this.btnCalcularSal.TabIndex = 12;
            this.btnCalcularSal.Text = "Calcular Salario";
            this.btnCalcularSal.UseVisualStyleBackColor = true;
            this.btnCalcularSal.Click += new System.EventHandler(this.btnCalcularSal_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(24, 164);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(52, 13);
            this.lblResposta.TabIndex = 13;
            this.lblResposta.Text = "Resposta";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnCalcularSal);
            this.Controls.Add(this.txtGrat);
            this.Controls.Add(this.txtbSal);
            this.Controls.Add(this.txtbProd);
            this.Controls.Add(this.txtbMatri);
            this.Controls.Add(this.txtbCargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbNome);
            this.Name = "frmExercicio4";
            this.Text = "Exercicio 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbCargo;
        private System.Windows.Forms.TextBox txtbMatri;
        private System.Windows.Forms.TextBox txtbProd;
        private System.Windows.Forms.TextBox txtbSal;
        private System.Windows.Forms.TextBox txtGrat;
        private System.Windows.Forms.Button btnCalcularSal;
        private System.Windows.Forms.Label lblResposta;
    }
}