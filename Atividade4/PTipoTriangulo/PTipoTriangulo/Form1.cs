using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTipoTriangulo
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            double ladoA,
                   ladoB,
                   ladoC,
                   resposta;

            if(!Double.TryParse(txtLado1.Text, out ladoA))
                MessageBox.Show("O campo Lado A precisa conter numeros.");
            if (!Double.TryParse(txtLado2.Text, out ladoB))
                MessageBox.Show("O campo Lado B precisa conter numeros.");
            if (!Double.TryParse(txtLado3.Text, out ladoC))
            {
                MessageBox.Show("O campo Lado C precisa conter numeros.");
                return;
            }

            if (ladoA == ladoB && ladoB == ladoC)
                MessageBox.Show("Equilatero");

            /*if(ladoA < Math.Abs(ladoB - ladoC) || ladoA > ladoB + ladoC)
                MessageBox.Show("Lado1 muito grande ou muito pequeno");

            if(ladoB < Math.Abs(ladoA - ladoC) || ladoB > ladoA + ladoC)
                MessageBox.Show("Lado2 muito grande ou muito pequeno");

            if(ladoC < Math.Abs(ladoA - ladoB) || ladoC > ladoA + ladoB)
                MessageBox.Show("Lado3 muito grande ou muito pequeno");*/

        }
    }
}
