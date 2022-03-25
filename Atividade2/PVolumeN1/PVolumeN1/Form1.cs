using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolumeN1
{
    public partial class PVolume : Form
    {
        public PVolume()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PVolume_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void te(object sender, EventArgs e)
        {
            double Raio;
            if (!Double.TryParse(InputRaio.Text, out Raio))
            {
                MessageBox.Show("Valor raio inválido");
                InputRaio.Focus();
            }
            else if(Raio <= 0)
            {
                MessageBox.Show("Raio deve ser maior que zero...");
                InputRaio.Focus();
            }

        }

        private void textbox1_Validated(object sender, EventArgs e)
        {
            double Altura;

            if(!Double.TryParse(InputAltura.Text, out Altura))
            {
                MessageBox.Show("Altura inválida");
                InputAltura.Focus();
            }
            else if(Altura <= 0)
            {
                MessageBox.Show("Altura deve ser maior que 0");
                InputAltura.Focus();
            }
                  
        }

        private void InputVolume_Validated(object sender, EventArgs e)
        {

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
