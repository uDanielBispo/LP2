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

            if(!Double.TryParse(txtLadoA.Text, out ladoA))
                MessageBox.Show("O campo Lado A precisa conter numeros.");
            if (!Double.TryParse(txtLadoB.Text, out ladoB))
                MessageBox.Show("O campo Lado B precisa conter numeros.");
            if (!Double.TryParse(txtLadoC.Text, out ladoC))
            {
                MessageBox.Show("O campo Lado C precisa conter numeros.");
                return;
            }
            if (ladoA > Math.Abs(ladoB - ladoC) && ladoA < ladoB + ladoC &&
                ladoB > Math.Abs(ladoA - ladoC) && ladoB < ladoA + ladoC &&
                ladoC > Math.Abs(ladoA - ladoB) && ladoC < ladoA + ladoB)
            {
                MessageBox.Show("Os valores formam um triangulo");
                if (ladoA == ladoB && ladoB == ladoC)
                    MessageBox.Show("Equilatero");
                else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
                    MessageBox.Show("Isóceles");
                else
                    MessageBox.Show("Escaleno");
            }
            else
            {
                MessageBox.Show("Os valores nao formam um triangulo");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
