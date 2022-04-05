namespace pSalario
{
    partial class frmSalario
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
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.mskdbxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AliquotaIRPF = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbDescontoINSS = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxCasada = new System.Windows.Forms.CheckBox();
            this.cbxNumeroDeFilhos = new System.Windows.Forms.ComboBox();
            this.txtbAliquotaIRPF = new System.Windows.Forms.TextBox();
            this.txtbSalarioFamilia = new System.Windows.Forms.TextBox();
            this.txtbSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtbDescontoIRPF = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(126, 24);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(169, 20);
            this.txtNomeFuncionario.TabIndex = 0;
            // 
            // mskdbxSalarioBruto
            // 
            this.mskdbxSalarioBruto.Location = new System.Drawing.Point(126, 59);
            this.mskdbxSalarioBruto.Mask = "99999.99";
            this.mskdbxSalarioBruto.Name = "mskdbxSalarioBruto";
            this.mskdbxSalarioBruto.Size = new System.Drawing.Size(169, 20);
            this.mskdbxSalarioBruto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salarío Bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero de Filhos";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(33, 130);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(262, 23);
            this.btnVerificar.TabIndex = 9;
            this.btnVerificar.Text = "Verifica Desconto";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnMasculino);
            this.groupBox1.Controls.Add(this.rbtnFeminino);
            this.groupBox1.Location = new System.Drawing.Point(328, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Checked = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(20, 30);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtnFeminino.TabIndex = 5;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(20, 63);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtnMasculino.TabIndex = 6;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "LblDados";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Salarío Família";
            // 
            // AliquotaIRPF
            // 
            this.AliquotaIRPF.AutoSize = true;
            this.AliquotaIRPF.Location = new System.Drawing.Point(30, 255);
            this.AliquotaIRPF.Name = "AliquotaIRPF";
            this.AliquotaIRPF.Size = new System.Drawing.Size(72, 13);
            this.AliquotaIRPF.TabIndex = 15;
            this.AliquotaIRPF.Text = "Aliquota IRPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Aliquota INSS";
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Enabled = false;
            this.txtAliquotaINSS.Location = new System.Drawing.Point(114, 217);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.Size = new System.Drawing.Size(137, 20);
            this.txtAliquotaINSS.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Salarío Líquido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Desconto IRPF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Desconto INSS";
            // 
            // txtbDescontoINSS
            // 
            this.txtbDescontoINSS.Enabled = false;
            this.txtbDescontoINSS.Location = new System.Drawing.Point(348, 217);
            this.txtbDescontoINSS.Name = "txtbDescontoINSS";
            this.txtbDescontoINSS.Size = new System.Drawing.Size(108, 20);
            this.txtbDescontoINSS.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxCasada);
            this.panel1.Location = new System.Drawing.Point(328, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 23);
            this.panel1.TabIndex = 7;
            // 
            // cbxCasada
            // 
            this.cbxCasada.AutoSize = true;
            this.cbxCasada.Location = new System.Drawing.Point(20, 4);
            this.cbxCasada.Name = "cbxCasada";
            this.cbxCasada.Size = new System.Drawing.Size(62, 17);
            this.cbxCasada.TabIndex = 8;
            this.cbxCasada.Text = "Casada";
            this.cbxCasada.UseVisualStyleBackColor = true;
            // 
            // cbxNumeroDeFilhos
            // 
            this.cbxNumeroDeFilhos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNumeroDeFilhos.FormattingEnabled = true;
            this.cbxNumeroDeFilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxNumeroDeFilhos.Location = new System.Drawing.Point(126, 95);
            this.cbxNumeroDeFilhos.Name = "cbxNumeroDeFilhos";
            this.cbxNumeroDeFilhos.Size = new System.Drawing.Size(169, 21);
            this.cbxNumeroDeFilhos.TabIndex = 2;
            // 
            // txtbAliquotaIRPF
            // 
            this.txtbAliquotaIRPF.Enabled = false;
            this.txtbAliquotaIRPF.Location = new System.Drawing.Point(114, 252);
            this.txtbAliquotaIRPF.Name = "txtbAliquotaIRPF";
            this.txtbAliquotaIRPF.Size = new System.Drawing.Size(137, 20);
            this.txtbAliquotaIRPF.TabIndex = 25;
            // 
            // txtbSalarioFamilia
            // 
            this.txtbSalarioFamilia.Enabled = false;
            this.txtbSalarioFamilia.Location = new System.Drawing.Point(114, 288);
            this.txtbSalarioFamilia.Name = "txtbSalarioFamilia";
            this.txtbSalarioFamilia.Size = new System.Drawing.Size(137, 20);
            this.txtbSalarioFamilia.TabIndex = 26;
            // 
            // txtbSalarioLiquido
            // 
            this.txtbSalarioLiquido.Enabled = false;
            this.txtbSalarioLiquido.Location = new System.Drawing.Point(114, 326);
            this.txtbSalarioLiquido.Name = "txtbSalarioLiquido";
            this.txtbSalarioLiquido.Size = new System.Drawing.Size(137, 20);
            this.txtbSalarioLiquido.TabIndex = 27;
            // 
            // txtbDescontoIRPF
            // 
            this.txtbDescontoIRPF.Enabled = false;
            this.txtbDescontoIRPF.Location = new System.Drawing.Point(348, 252);
            this.txtbDescontoIRPF.Name = "txtbDescontoIRPF";
            this.txtbDescontoIRPF.Size = new System.Drawing.Size(108, 20);
            this.txtbDescontoIRPF.TabIndex = 28;
            // 
            // frmSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 379);
            this.Controls.Add(this.txtbDescontoIRPF);
            this.Controls.Add(this.txtbSalarioLiquido);
            this.Controls.Add(this.txtbSalarioFamilia);
            this.Controls.Add(this.txtbAliquotaIRPF);
            this.Controls.Add(this.cbxNumeroDeFilhos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbDescontoINSS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AliquotaIRPF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskdbxSalarioBruto);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Name = "frmSalario";
            this.Text = "Salario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.MaskedTextBox mskdbxSalarioBruto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AliquotaIRPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbDescontoINSS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbxCasada;
        private System.Windows.Forms.ComboBox cbxNumeroDeFilhos;
        private System.Windows.Forms.TextBox txtbAliquotaIRPF;
        private System.Windows.Forms.TextBox txtbSalarioFamilia;
        private System.Windows.Forms.TextBox txtbSalarioLiquido;
        private System.Windows.Forms.TextBox txtbDescontoIRPF;
    }
}

