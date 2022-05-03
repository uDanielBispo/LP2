using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PtesteMetodos
{
    public partial class formExercicio4 : Form
    {
        public formExercicio4()
        {
            InitializeComponent();
        }

        private void btnQtdNumericos_Click(object sender, EventArgs e)
        {
            int qtdNumericos=0;
            string s = rctxtbExercicio4.Text;

            char[] arr = s.ToCharArray();

            foreach(char c in arr)
            {
                if (Char.IsNumber(c) == true) 
                {
                    qtdNumericos++;
                }
            }
            lblResposta.Text = $"Quantidade de digitos numéricos é de: {qtdNumericos}";
            lblResposta.Visible = true;
        }


        private void btnCaractereBranco_Click(object sender, EventArgs e)
        {
            int endereco = 1;
            string s = rctxtbExercicio4.Text;

            char[] arr = s.ToCharArray();

            foreach (char c in arr)
            {
                if (c == ' ')
                {
                    break;
                }
                endereco++;
            }
            lblResposta.Text = $"Posição do primeiro caractere branco é: {endereco}";
            lblResposta.Visible = true;
        }

        private void btnAlfabetico_Click(object sender, EventArgs e)
        {
            int qtdAlfabeticos = 0;
            string s = rctxtbExercicio4.Text;

            char[] arr = s.ToCharArray();

            foreach (char c in arr)
            {
                if (Char.IsLetter(c) == true)
                {
                    qtdAlfabeticos++;
                }
            }
            lblResposta.Text = $"Quantidade de caracteres alfabeticos: {qtdAlfabeticos}";
            lblResposta.Visible = true;
        }
    }
}
