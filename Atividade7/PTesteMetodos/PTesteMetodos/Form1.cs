using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copy Things");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paste Things");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTestar1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void exercícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio2>().Count() > 0)
            {
                Application.OpenForms["frmExercicio2"].BringToFront();
            }
            else
            {
                frmExercicio2 frm2 = new frmExercicio2();
                frm2.MdiParent = this;
                frm2.WindowState = FormWindowState.Maximized;
                frm2.Show();
            }
        }

        private void exercícioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio3>().Count() > 0)
            {
                Application.OpenForms["frmExercicio3"].BringToFront();
            }
            else
            {
                frmExercicio3 frm3 = new frmExercicio3();
                frm3.MdiParent = this;
                frm3.WindowState = FormWindowState.Maximized;
                frm3.Show();
            }
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                Application.OpenForms["frmExercicio4"].BringToFront();
            }
            else
            {
                frmExercicio4 frm4 = new frmExercicio4();
                frm4.MdiParent = this;
                frm4.WindowState = FormWindowState.Maximized;
                frm4.Show();
            }
        }
    }
}
