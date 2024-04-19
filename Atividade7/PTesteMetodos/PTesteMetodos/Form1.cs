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
    }
}
