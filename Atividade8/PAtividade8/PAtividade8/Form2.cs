using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade8
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnQtdEspacos_Click(object sender, EventArgs e)
        {
            char[] vetorEntrada = rchtxtEntrada.Text.ToCharArray();
            int contEspacos = 0;
            
            foreach(char c in vetorEntrada)
            {
                if (c == ' ')
                    contEspacos++;
            }

            lblResposta.Text = $"Quantidade de espaços: {contEspacos}";
            lblResposta.Visible = true;
        }

        private void QtdLetraR_Click(object sender, EventArgs e)
        {
            char[] vetorEntrada = rchtxtEntrada.Text.ToCharArray();
            int contR = 0;

            foreach (char c in vetorEntrada)
            {
                if (c == 'R' | c =='r')
                    contR++;
            }

            lblResposta.Text = $"Quantidade de R's: {contR}";
            lblResposta.Visible = true;
        }

        private void QtdDePares_Click(object sender, EventArgs e)
        {
            string vetorEntrada = rchtxtEntrada.Text.Replace(" ", "").ToUpper();
            int contPares = 0;

            char caractereAnterior = ' ';

            foreach(char c in vetorEntrada)
            {
                if (c == caractereAnterior)
                    contPares++;
                
                caractereAnterior = c;
            }

            lblResposta.Text = $"Quantidade de pares: {contPares}";
            lblResposta.Visible = true;
        }
    }
}
