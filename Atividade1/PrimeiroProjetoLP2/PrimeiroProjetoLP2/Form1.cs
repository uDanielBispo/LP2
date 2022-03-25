using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjetoLP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!, World!! " + textBox1.Text + ",\nSeja bem-vindo!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("1º Semestre Manhâ");
            listBox1.Items.Add("2º Semestre Manhâ");
            listBox1.Items.Add("1º Semestre Noite");
            listBox1.Items.Add("2º Semestre Noite");

            listBox1.SelectedIndex = 0;

            radioButton1.Select();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cidade, sexo, turma, transferido, nome;

            if (textBox1.Text == "")
                MessageBox.Show("Insira algum nome");
            else
                MessageBox.Show(textBox1.Text + " foi adicionado"); 

            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Cidade nao selecionada");
            else
                MessageBox.Show("The studant's city is" + comboBox1.SelectedItem);

            if(checkBox1.CheckState == CheckState.Checked)
                MessageBox.Show("Aluno transferido");
            else if (checkBox1.CheckState == CheckState.Unchecked)
                MessageBox.Show("Aluno não veio transferido");
            else
                MessageBox.Show("Indeterminado");
            if(radioButton1.Checked)
                MessageBox.Show("Aluno masculino");
            else
                MessageBox.Show("Aluna feminina");


            for (var i = 0; i <= checkedListBox1.CheckedItems.Count - 1; i++)
                MessageBox.Show(checkedListBox1.CheckedItems[i].ToString());
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
