using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pSalario
{
    public partial class frmSalario : Form
    {
        public frmSalario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxNumeroDeFilhos.SelectedIndex = 0;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double
                salarioBruto = 0,
                aliquotaINSS = 0,
                aliquotaIRPF = 0,
                salarioFamilia = 0,
                salarioLiquido = 0,
                descontoINSS = 0,
                descontoIRPF = 0,
                qtdFilhos = 0;


            //VALIDAÇÂO
            if (txtNomeFuncionario.Text == "")
            {
                MessageBox.Show("Nome vazio");
                return;
            }
            if (!double.TryParse(mskdbxSalarioBruto.Text, out salarioBruto))
            {
                MessageBox.Show("Salario precisa ser numero");
                return;
            }
            else
            {
                if (salarioBruto <= 0)
                {
                    MessageBox.Show("Salario precisa ser maior que 0");
                    return;
                }

                //CALCULO INSS
                else if (salarioBruto <= 800.47)
                {
                    aliquotaINSS = 0.0765;
                    txtAliquotaINSS.Text = "7,65%";
                }
                else if (salarioBruto <= 1050)
                {
                    aliquotaINSS = 0.0865;
                    txtAliquotaINSS.Text = "8,65%";
                }
                else if (salarioBruto <= 1400.77)
                {
                    aliquotaINSS = 0.09;
                    txtAliquotaINSS.Text = "9%";
                }
                else if (salarioBruto <= 2801.56)
                {
                    aliquotaINSS = 0.11;
                    txtAliquotaINSS.Text = "11%";
                }

                else
                {
                    descontoINSS = 308.17;
                    txtAliquotaINSS.Text = "TETO";
                }
                if (descontoINSS == 0)            
                    descontoINSS = salarioBruto * aliquotaINSS;


                //CALCULO IRPF
                if (salarioBruto < 1257.12)
                {
                    aliquotaIRPF = 0;
                    txtbAliquotaIRPF.Text = "ISENTO";
                }
                else if (salarioBruto < 2512.08)
                {
                    aliquotaIRPF = 0.15;
                    txtbAliquotaIRPF.Text = "15%";
                }
                else
                {
                    aliquotaIRPF = 0.275;
                    txtbAliquotaIRPF.Text = "27,5%";
                }
                    descontoIRPF = salarioBruto * aliquotaIRPF;

                //CALCULO SALARIO FAMILIA
                double.TryParse(cbxNumeroDeFilhos.Text, out qtdFilhos);

                if (salarioBruto < 435.52)
                    salarioFamilia = 22.33 * qtdFilhos;
                else if (salarioBruto < +654.61)
                    salarioFamilia = 15.74 * qtdFilhos;

                salarioLiquido = salarioBruto - descontoIRPF - descontoINSS + salarioFamilia;

                txtbDescontoIRPF.Text = descontoIRPF.ToString("N2");
                txtbDescontoINSS.Text = descontoINSS.ToString("N2");
                txtbSalarioFamilia.Text = salarioFamilia.ToString("N2");
                txtbSalarioLiquido.Text = salarioLiquido.ToString("N2");

                //LABEL MENSAGEM 
                lblDados.Text = "Olá, os descontos do salario";
                if (rbtnFeminino.Checked == true)
                    lblDados.Text += " da Sra.";
                else
                    lblDados.Text += " do Sr.";
                lblDados.Text += txtNomeFuncionario.Text + " que é ";
                if (rbtnFeminino.Checked == true)
                {
                    if (cbxCasada.Checked == true)
                        lblDados.Text += "casada";
                    else
                        lblDados.Text += "solteira";
                }
                else if (cbxCasada.Checked == true)
                    lblDados.Text += "casado";
                else
                    lblDados.Text += "solteiro";

                if (qtdFilhos > 0)
                    lblDados.Text += "\ne que tem " + qtdFilhos.ToString() + " filho(s)";
                lblDados.Text += " são:";

                lblDados.Visible = true;
                }



            

        }


    }
}
