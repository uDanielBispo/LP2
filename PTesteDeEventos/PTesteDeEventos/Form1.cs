using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteDeEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("Componente perdeu o foco");
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("Componente ganhou foco");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            { //testando se a tecla é enter
                SendKeys.Send("{TAB}");
                e.Handled = true; //desativa o beep
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Nome vazio");
                textBox1.Focus();//da o foco no componente desejado
            }
            
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            DateTime dtAuxiliar;
            if(!DateTime.TryParse(maskedTextBox1.Text, out dtAuxiliar))
            {
                MessageBox.Show("Data invalida");
                e.Cancel = true;
            }                
        }

        private void maskedTextBox2_Validating(object sender, CancelEventArgs e)
        {
            double vlrBoleto;

            if (!Double.TryParse(maskedTextBox2.Text, out vlrBoleto))
            {
                MessageBox.Show("Valor invalido");
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*textBox1_Validated(sender, e);
            maskedTextBox1_Validating(sender, new CancelEventArgs());
            maskedTextBox2_Validating(sender, new CancelEventArgs());*/

            if (textBox1.Text == "" || textBox1.Text == " ")
            {
                MessageBox.Show("Nome vazio");
                textBox1.Focus(); // da o foco no componente desejado
            }
            else
            {
                DateTime dtAuxiliar;

                if (!DateTime.TryParse(maskedTextBox1.Text, out dtAuxiliar))
                {
                    MessageBox.Show("Data Inválida!");
                    maskedTextBox1.Focus();
                }
                else
                {
                    double vlrBoleto;



                    if (!Double.TryParse(maskedTextBox2.Text, out vlrBoleto))
                    {
                        MessageBox.Show("Valor inválido!");
                        maskedTextBox2.Focus();
                    }
                }
            }
        }
    }
}
