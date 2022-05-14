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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResp.Text = "";
            double[] quantidade = new Double[10];
            double[] precos = new Double[10];
            double faturamento = 0;
            string auxiliarQtd, auxiliarPrecos;

            for(int i=0; i<10; i++)
            {
                auxiliarQtd = Interaction.InputBox("Digite a quantidade do "+ (i+1) + "º produto", "Entrada de dados");
                if(!Double.TryParse(auxiliarQtd, out quantidade[i]))
                {
                    if(auxiliarQtd == "")                    
                        break;
                    else
                    {
                        MessageBox.Show("Numero inválido, digite novamente");
                        i--;
                    }
                }
                else
                {
                    for (int z = i; z < 10; z++)
                    {
                        auxiliarPrecos = Interaction.InputBox("Digite o preço do " + (i + 1) + "º produto", "Entrada de dados");
                        if (!Double.TryParse(auxiliarPrecos, out precos[i]))
                        {
                            MessageBox.Show("Numero inválido, digite novamente");
                            z--;
                        }
                        else
                        {
                            faturamento += quantidade[z] * precos[z];
                            lblResp.Text += $"Produto: {z+1}º | Quantidade: {quantidade[z]} | Preco: {precos[z]} | total: {quantidade[z]*precos[z]}\n";
                            lblResp.Visible = true;
                            break;
                        }
                    }
                }
            }
            lblResp.Text += $"Faturamento do mês: {faturamento}";
        }
    }
}
