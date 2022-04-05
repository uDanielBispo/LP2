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
                descontoIRPF = 0;



            if(txtNomeFuncionario.Text == "")
                MessageBox.Show("Nome vazio");

            if (!double.TryParse(mskdbxSalarioBruto.Text, out salarioBruto))
            {
                MessageBox.Show("Salario precisa ser numero");
                if(salarioBruto == 0)
                    MessageBox.Show("Salario precisa ser maior do que 0");
            }
            else
            {
                if (salarioBruto <= 800.47) 
                { 

                }
            }


        }


    }
}
