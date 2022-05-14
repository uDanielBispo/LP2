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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formPrincipal = Application.OpenForms["frmExercicio1"];

            if (formPrincipal != null)
                formPrincipal.Close();

            frmExercicio1 objFrmEx1 = new frmExercicio1();
            objFrmEx1.MdiParent = this;
            objFrmEx1.WindowState = FormWindowState.Maximized;
            objFrmEx1.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Form formPrincipal = Application.OpenForms["frmExercicio2"];

            if (formPrincipal != null)
                formPrincipal.Close();

            frmExercicio2 objFrmEx2 = new frmExercicio2();
            objFrmEx2.MdiParent = this;
            objFrmEx2.WindowState = FormWindowState.Maximized;
            objFrmEx2.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formPrincipal = Application.OpenForms["frmExercicio4"];

            if (formPrincipal != null)
                formPrincipal.Close();

            frmExercicio4 objFrmEx4 = new frmExercicio4();
            objFrmEx4.MdiParent = this;
            objFrmEx4.WindowState = FormWindowState.Maximized;
            objFrmEx4.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formPrincipal = Application.OpenForms["frmExercicio3"];

            if (formPrincipal != null)
                formPrincipal.Close();

            frmExercicio3 objFrmEx3 = new frmExercicio3();
            objFrmEx3.MdiParent = this;
            objFrmEx3.WindowState = FormWindowState.Maximized;
            objFrmEx3.Show();
        }
    }
}
