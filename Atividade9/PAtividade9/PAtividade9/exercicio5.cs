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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            lblMatriz.Text = "";
            lblMedias.Text = "";
            
            double[,] notas = new Double[20,3];
            double[] media = new Double[20];
            double acumula=0, resposta=0;            

            string aux= "";

            for(int nAluno = 0; nAluno < 20; nAluno++)
            {
                lblMatriz.Text += $"Aluno {nAluno + 1}:";
                for (int nNota = 0; nNota < 3; nNota++)
                {
                    aux = Interaction.InputBox("Digite a " + (nNota + 1) + "a nota do " + (nAluno + 1) + "º Aluno:", "Entrada de dados");
                    if (aux != "")
                    {
                        if (!Double.TryParse(aux, out resposta))
                        {
                            MessageBox.Show("valor invalido");
                            nNota--;
                        }
                        else
                        {
                            lblMatriz.Text += $" nota{nNota + 1} = {aux} ";
                            notas[nAluno, nNota] = Double.Parse(aux);
                            acumula += notas[nAluno, nNota];
                        }
                    }
                    else
                        break;
                }

                if (aux == "")
                {
                    lblMedias.Text = "";
                    lblMatriz.Text = "";
                    return;
                }

                lblMatriz.Text += "\n";
                media[nAluno] = acumula /3;
                acumula = 0;


            }
            for (int i = 0; i < 20; i++)
            {
                lblMedias.Text += $"Aluno {i + 1}: media = {media[i]}\n";
            }


        }
    }
}
