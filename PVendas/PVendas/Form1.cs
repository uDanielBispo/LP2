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

namespace ProvaPratica1
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            lstbxVendas.Items.Clear();

            int n = 5;
            double[,] vendas = new double[n, 4];
            double[] vSemana = new double[4];
            double[] totMes = new double[n];
            double auxTotMes = 0;
            double totGeral = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    string aux = Interaction.InputBox($"Digite as vendas da {j+1}ª semana do mes {i+1}", "Entrada de dados");
                    if (aux == String.Empty)
                    {
                        lstbxVendas.Items.Add($">> Total Geral: R$" + totGeral.ToString("N2"));
                        return;
                    }

                    else if (!Double.TryParse(aux, out vSemana[j]))
                    {
                        MessageBox.Show("Valor inválido");
                        j--;
                    }
                    else
                    {
                        lstbxVendas.Items.Add($"Total do mês {i + 1} semana {j + 1}: R$" + vSemana[j].ToString("N2"));

                        auxTotMes += vSemana[j];
                        totGeral += vSemana[j];
                    }                    
                }
                totMes[i] = auxTotMes;              
                auxTotMes = 0;

                lstbxVendas.Items.Add($">> Total mês: R$"+ totMes[i].ToString("N2"));
                lstbxVendas.Items.Add("-----------------------------");
            }
            lstbxVendas.Items.Add($">> Total Geral: R$" + totGeral.ToString("N2"));
        }
    }
}
