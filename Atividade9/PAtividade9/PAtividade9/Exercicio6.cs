using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PAtividade9
{
    public partial class frmExercicio6 : Form
    {
        public frmExercicio6()
        {
            InitializeComponent();
        }

        private void btnExercutar_Click(object sender, EventArgs e)
        {
            ltbNomes.Items.Clear();
            
            int N = 5;
            string aux;

            for(int i=0; i<N; i++)
            {
                aux = Interaction.InputBox("Digite o "+(i+1)+"º nome:","Entrada de dados");
                aux = aux.Replace(" ", "");
                if (aux == "")
                {                    
                    break;
                }
                else
                {                    
                    ltbNomes.Items.Add((i + 1) + "º Nome: " + aux + ", contem " + aux.Length + " caracteres");
                }
            }
        }
    }
}
