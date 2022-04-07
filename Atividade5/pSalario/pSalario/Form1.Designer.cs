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
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblNumeroFilhos = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.lblAliquotaIRPF = new System.Windows.Forms.Label();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
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
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(30, 27);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(90, 13);
            this.lblNomeFuncionario.TabIndex = 3;
            this.lblNomeFuncionario.Text = "Nome funcionário";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(30, 62);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(69, 13);
            this.lblSalarioBruto.TabIndex = 4;
            this.lblSalarioBruto.Text = "Salarío Bruto";
            // 
            // lblNumeroFilhos
            // 
            this.lblNumeroFilhos.AutoSize = true;
            this.lblNumeroFilhos.Location = new System.Drawing.Point(30, 98);
            this.lblNumeroFilhos.Name = "lblNumeroFilhos";
            this.lblNumeroFilhos.Size = new System.Drawing.Size(89, 13);
            this.lblNumeroFilhos.TabIndex = 5;
            this.lblNumeroFilhos.Text = "Numero de Filhos";
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
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(30, 168);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(52, 13);
            this.lblDados.TabIndex = 10;
            this.lblDados.Text = "LblDados";
            this.lblDados.Visible = false;
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(30, 291);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(78, 13);
            this.lblSalarioFamilia.TabIndex = 16;
            this.lblSalarioFamilia.Text = "Salarío Família";
            // 
            // lblAliquotaIRPF
            // 
            this.lblAliquotaIRPF.AutoSize = true;
            this.lblAliquotaIRPF.Location = new System.Drawing.Point(30, 255);
            this.lblAliquotaIRPF.Name = "lblAliquotaIRPF";
            this.lblAliquotaIRPF.Size = new System.Drawing.Size(72, 13);
            this.lblAliquotaIRPF.TabIndex = 15;
            this.lblAliquotaIRPF.Text = "Aliquota IRPF";
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Location = new System.Drawing.Point(30, 220);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(73, 13);
            this.lblAliquotaINSS.TabIndex = 14;
            this.lblAliquotaINSS.Text = "Aliquota INSS";
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Enabled = false;
            this.txtAliquotaINSS.Location = new System.Drawing.Point(114, 217);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.Size = new System.Drawing.Size(137, 20);
            this.txtAliquotaINSS.TabIndex = 11;
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(30, 329);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(80, 13);
            this.lblSalarioLiquido.TabIndex = 18;
            this.lblSalarioLiquido.Text = "Salarío Líquido";
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.Location = new System.Drawing.Point(261, 255);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(80, 13);
            this.lblDescontoIRPF.TabIndex = 22;
            this.lblDescontoIRPF.Text = "Desconto IRPF";
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Location = new System.Drawing.Point(261, 220);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(81, 13);
            this.lblDescontoINSS.TabIndex = 21;
            this.lblDescontoINSS.Text = "Desconto INSS";
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
            this.ClientSize = new System.Drawing.Size(493, 377);
            this.Controls.Add(this.txtbDescontoIRPF);
            this.Controls.Add(this.txtbSalarioLiquido);
            this.Controls.Add(this.txtbSalarioFamilia);
            this.Controls.Add(this.txtbAliquotaIRPF);
            this.Controls.Add(this.cbxNumeroDeFilhos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDescontoIRPF);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.txtbDescontoINSS);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblAliquotaIRPF);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblNumeroFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNomeFuncionario);
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
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblNumeroFilhos;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.Label lblAliquotaIRPF;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.Label lblDescontoINSS;
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

