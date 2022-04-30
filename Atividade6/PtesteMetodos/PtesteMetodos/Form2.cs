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
    public partial class formExercicio2 : Form
    {
        public formExercicio2()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtPalavra1.Text, txtPalavra2.Text, true) == 0) //terceiro parametro 'true' serve para ignorar o Case Sentitive
                MessageBox.Show("São iguais!");
            else
                MessageBox.Show("São diferentes!");
        }

        private void btnMesclar_Click(object sender, EventArgs e)
        {
            int metade = txtPalavra2.Text.Length / 2;

            /* texto1.Text --> a      x        **
             texto2.Text --> casa   fatec   sorocaba
                             caasa  faxtec  sor**aba
            */

            txtPalavra2.Text = txtPalavra2.Text.Substring(0, metade) + 
                txtPalavra1.Text +
                txtPalavra2.Text.Substring(metade, txtPalavra2.Text.Length - metade);
        }

        private void txtPalavra2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPalavra1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPalavra1_Click(object sender, EventArgs e)
        {

        }

        private void lblPalavra2_Click(object sender, EventArgs e)
        {

        }

        private void btnInserirAsterisco_Click(object sender, EventArgs e)
        {
            int meio = txtPalavra1.Text.Length / 2;
            txtPalavra2.Text = txtPalavra1.Text.Insert(meio, "**");
        }
    }
}
