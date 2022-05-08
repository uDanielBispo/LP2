using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; // Projeto > Referencia > Assembles > Visual basic

namespace PAtividade9
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void frmExercicio1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            
            string auxiliar;
            
        
            for(int i=0; i<20; i++)
            {
                auxiliar = Interaction.InputBox("Digite um numero posição = " + (i+1), "Entrada de dados");
                if(!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Nao é numero");
                    i--;
                }
            }
            Array.Reverse(vetor);
            auxiliar = "";
            foreach(int i in vetor)
            {
                auxiliar = auxiliar + "\n" + i;
                MessageBox.Show(auxiliar);
            }

        }
    }
}
