﻿namespace PAtividade9
{
    partial class frmPrincial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exercicio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercicio1ToolStripMenuItem,
            this.exercicio2ToolStripMenuItem,
            this.exercicio3ToolStripMenuItem,
            this.exercicio4ToolStripMenuItem,
            this.exercicio5ToolStripMenuItem,
            this.exercicio6ToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // exercicio1ToolStripMenuItem
            // 
            this.exercicio1ToolStripMenuItem.Name = "exercicio1ToolStripMenuItem";
            this.exercicio1ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.exercicio1ToolStripMenuItem.Text = "Exercicio &1";
            this.exercicio1ToolStripMenuItem.Click += new System.EventHandler(this.exercicio1ToolStripMenuItem_Click);
            // 
            // exercicio2ToolStripMenuItem
            // 
            this.exercicio2ToolStripMenuItem.Name = "exercicio2ToolStripMenuItem";
            this.exercicio2ToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.exercicio2ToolStripMenuItem.Text = " Exercicio &2";
            this.exercicio2ToolStripMenuItem.Click += new System.EventHandler(this.exercicio2ToolStripMenuItem_Click);
            // 
            // exercicio3ToolStripMenuItem
            // 
            this.exercicio3ToolStripMenuItem.Name = "exercicio3ToolStripMenuItem";
            this.exercicio3ToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.exercicio3ToolStripMenuItem.Text = " Exercicio &3";
            this.exercicio3ToolStripMenuItem.Click += new System.EventHandler(this.exercicio3ToolStripMenuItem_Click);
            // 
            // exercicio4ToolStripMenuItem
            // 
            this.exercicio4ToolStripMenuItem.Name = "exercicio4ToolStripMenuItem";
            this.exercicio4ToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.exercicio4ToolStripMenuItem.Text = " Exercicio &4";
            this.exercicio4ToolStripMenuItem.Click += new System.EventHandler(this.exercicio4ToolStripMenuItem_Click);
            // 
            // exercicio5ToolStripMenuItem
            // 
            this.exercicio5ToolStripMenuItem.Name = "exercicio5ToolStripMenuItem";
            this.exercicio5ToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.exercicio5ToolStripMenuItem.Text = " Exercicio &5";
            this.exercicio5ToolStripMenuItem.Click += new System.EventHandler(this.exercicio5ToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.sairToolStripMenuItem.Text = " &Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // exercicio6ToolStripMenuItem
            // 
            this.exercicio6ToolStripMenuItem.Name = "exercicio6ToolStripMenuItem";
            this.exercicio6ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.exercicio6ToolStripMenuItem.Text = "Exercicio &6";
            this.exercicio6ToolStripMenuItem.Click += new System.EventHandler(this.exercicio6ToolStripMenuItem_Click);
            // 
            // frmPrincial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 410);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincial";
            this.Text = "PAtividade9";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exercicio1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicio2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicio3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicio4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicio5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicio6ToolStripMenuItem;
    }
}

