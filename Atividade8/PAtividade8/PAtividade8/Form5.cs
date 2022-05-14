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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcularSal_Click(object sender, EventArgs e)
        {
            string nome, cargo;
            double A, prod, grat, sal, matri, salBruto;
            int B, C, D;

            nome = txtbNome.Text;
            cargo = txtbCargo.Text;

            if (nome == String.Empty || cargo == String.Empty)
            {
                MessageBox.Show("Nome e cargo precisam estar preenchidos");
            }

            else if (!double.TryParse(txtGrat.Text, out grat) || !double.TryParse(txtbSal.Text, out sal) ||
                     !double.TryParse(txtbProd.Text, out prod) || !double.TryParse(txtbMatri.Text, out matri))
                        MessageBox.Show("Produção/Salario/Matricula/Gratificação precisam ser numeros");
            else
            {
                A = sal;
                B = prod >= 100 ? 1 : 0;
                C = prod >= 120 ? 1 : 0;
                D = prod >= 150 ? 1 : 0;

                salBruto = A + A * (0.05 * B + 0.1 * C + 0.1 * D) + grat;

                if(salBruto > 7000 && prod >= 150)                
                    lblResposta.Text = $"Seu salario bruto é R${salBruto}";
                else if (salBruto > 7000)    
                    {
                        salBruto = 7000;
                        lblResposta.Text = $"Seu salario bruto é de {salBruto}";
                    }
                else
                {
                    lblResposta.Text = $"Seu salario bruto é de {salBruto}";
                }
                  
            }            
        }
    }
}
