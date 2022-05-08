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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCompara_Click(object sender, EventArgs e)
        {
            lblResposta.Text = "";

            int N;
            double H = 0;

            if (!int.TryParse(txtbEntrada.Text, out N))
                lblResposta.Text = "Valor invalido";
            else
            {
                if(N <= 0)
                    lblResposta.Text = "Precisa ser maior que 0";
                else
                {
                    for (double i = 1; i <= N; i++)
                    {
                        H += 1 / i;                        
                    }
                    lblResposta.Text += $"Resposta: {H}";
                }
            }
            lblResposta.Visible = true;
        }

        private void frmExercicio2_Load(object sender, EventArgs e)
        {

        }
    }
}
