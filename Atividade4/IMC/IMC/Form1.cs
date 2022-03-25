using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class IMC : Form
    {
        public IMC()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            double peso,
            altura,
            resultado;

            if (!Double.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("Peso precisa ser numero.");
                
            }
            if (!Double.TryParse(mskbxAltura.Text, out altura))
            {
                MessageBox.Show("Altura precisa ser numero.");
                return;
            }

            resultado = peso / Math.Pow(altura, 2);
            txtResultado.Text = resultado.ToString("N2");

            if(resultado < 18.5)
                MessageBox.Show("Magreza IMC: "+resultado.ToString("N2"));
            else if (resultado <=24.9)
                MessageBox.Show("Normal IMC: " + resultado.ToString("N2"));
            else if (resultado <= 39.9)
                MessageBox.Show("Obesidade IMC: " + resultado.ToString("N2"));
            else 
                MessageBox.Show("Obesidade grave IMC: " + resultado.ToString("N2"));

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            mskbxAltura.Clear();
            txtResultado.Clear();
            txtPeso.Clear();                
        }
    }
}
