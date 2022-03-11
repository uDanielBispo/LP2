using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
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

        private void EntradaRaio_Validated(object sender, EventArgs e)
        {
            double Raio;
            if(!Double.TryParse(EntradaRaio.Text, out Raio))
            {
                MessageBox.Show("Valor de raio inválido");
                EntradaRaio.Focus();
            }
            else if(Raio <= 0)
            {
                MessageBox.Show("Raio precisa ser maior que 0");
                EntradaRaio.Focus();
            }
        }

        private void EntradaAltura_Validated(object sender, EventArgs e)
        {
            double Altura;
            if (!Double.TryParse(EntradaAltura.Text, out Altura))
            {
                MessageBox.Show("Valor de altura inválido");
                EntradaAltura.Focus();
            }
            else if (Altura <= 0)
            {
                MessageBox.Show("Altura precisa ser maior que 0");
                EntradaAltura.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Raio;
            if (!Double.TryParse(EntradaRaio.Text, out Raio))
            {
                MessageBox.Show("Valor de raio inválido");
                EntradaRaio.Focus();
            }
            else if (Raio <= 0)
            {
                MessageBox.Show("Raio precisa ser maior que 0");
                EntradaRaio.Focus();
            }
            else
            {
                double Altura;
                if (!Double.TryParse(EntradaAltura.Text, out Altura))
                {
                    MessageBox.Show("Valor de altura inválido");
                    EntradaAltura.Focus();
                }
                else if (Altura <= 0)
                {
                    MessageBox.Show("Altura precisa ser maior que 0");
                    EntradaAltura.Focus();
                }
                else
                {
                    double Volume;
                    Volume = Math.PI * Math.Pow(Raio, 2) * Altura;
                    InputVolume.Text = Volume.ToString("N2");
                }
            }
        }
    }
}
