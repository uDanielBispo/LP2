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
    public partial class formExercicio5 : Form
    {
        public formExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            int n1, n2;
            if(!int.TryParse(txtbN1.Text, out n1)||!int.TryParse(txtbN2.Text, out n2))
                MessageBox.Show("Numero1 e Numero2 precisam ser numeros inteiros");
            else
            {
                Random rnd = new Random();                
                lblResposta.Text = $"O numero sorteado foi: {rnd.Next(n1, n2)}";
                lblResposta.Visible = true;
            }
        }
    }
}
