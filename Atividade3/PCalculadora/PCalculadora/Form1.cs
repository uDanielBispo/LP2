using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EntradaN2_Validated(object sender, EventArgs e)
        {
            double N2;
            if (!Double.TryParse(EntradaN2.Text, out N2))
                MessageBox.Show("2ºNumero precisa ser um numero");
        }

        private void EntradaN1_Validated(object sender, EventArgs e)
        {
            double N1;
            if (!Double.TryParse(EntradaN1.Text, out N1))
                MessageBox.Show("1ºNumero precisa ser um numero");
        }

        private void Soma_Click(object sender, EventArgs e)
        {
            double  res, N1, N2;

            if (!Double.TryParse(EntradaN1.Text, out N1))
            {
                MessageBox.Show("1ºNumero precisa ser um numero");
                return;
            }
            if (!Double.TryParse(EntradaN2.Text, out N2))
            {
                MessageBox.Show("2ºNumero precisa ser um numero");
                return;
            }

            res = N1 + N2;
            Resultado.Text = res.ToString("N2");
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Subtracao_Click(object sender, EventArgs e)
        {
            double res, N1, N2;

            if (!Double.TryParse(EntradaN1.Text, out N1))
            {
                MessageBox.Show("1ºNumero precisa ser um numero");
                return;
            }
            if (!Double.TryParse(EntradaN2.Text, out N2))
            {
                MessageBox.Show("2ºNumero precisa ser um numero");
                return;
            }

            res = N1 - N2;
            Resultado.Text = res.ToString("N2");
        }

        private void Multiplicacao_Click(object sender, EventArgs e)
        {
            double res, N1, N2;

            if (!Double.TryParse(EntradaN1.Text, out N1))
            {
                MessageBox.Show("1ºNumero precisa ser um numero");
                return;
            }
            if (!Double.TryParse(EntradaN2.Text, out N2))
            {
                MessageBox.Show("2ºNumero precisa ser um numero");
                return;
            }

            res = N1 * N2;
            Resultado.Text = res.ToString("N2");
        }

        private void Divisao_Click(object sender, EventArgs e)
        {
            double res, N1, N2;

            if (!Double.TryParse(EntradaN1.Text, out N1))
            {
                MessageBox.Show("1ºNumero precisa ser um numero");
                return;
            }
            if (!Double.TryParse(EntradaN2.Text, out N2))
            {
                MessageBox.Show("2ºNumero precisa ser um numero");
                return;
            }
            if (N2 == 0)
            {
                MessageBox.Show("2ºNumero precisa ser diferente de 0");
                return;
            }

            

            res = N1 / N2;
            Resultado.Text = res.ToString("N2");
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            EntradaN1.Clear();
            EntradaN2.Clear();
            Resultado.Clear();

            EntradaN1.Focus();
        }
    }
}
