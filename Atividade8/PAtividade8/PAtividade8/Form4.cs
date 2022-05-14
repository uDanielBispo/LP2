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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palavra = txtbEntradaTexto.Text.Replace(" ", "").ToUpper();
            char[] palavraInvertida = palavra.ToCharArray();
            Array.Reverse(palavraInvertida);
            string s = new string(palavraInvertida);

            if (string.Compare(palavra, s) == 0)
                lblResposta.Text = $"É um palindromo {s}";
            else
                lblResposta.Text = $"Não é um palindromo {s}";
            lblResposta.Visible = true;
        }

        private void lblResposta_Click(object sender, EventArgs e)
        {

        }
    }
}
