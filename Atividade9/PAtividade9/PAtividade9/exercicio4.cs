using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PAtividade9
{
    public partial class frmExercicio4 : Form
    {

        ArrayList Lista = new ArrayList();

        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void frmExercicio4_Load(object sender, EventArgs e)
        {
            
            Lista.Add("Ana");
            Lista.Add("André");
            Lista.Add("Débora");
            Lista.Add("Fátima");
            Lista.Add("João");
            Lista.Add("Janete");
            Lista.Add("Otávio");
            Lista.Add("Marcelo");
            Lista.Add("Pedro");
            Lista.Add("Thais");
            Lista.Remove("Otávio");

        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            string aux=""; 
            foreach (object obj in Lista)
            {
                aux += obj.ToString()+"\n";
                MessageBox.Show(aux);

            }
        }
    }
}
