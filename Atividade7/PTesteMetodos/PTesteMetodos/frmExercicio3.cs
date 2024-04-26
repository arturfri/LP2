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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnTestar1_Click(object sender, EventArgs e)
        {

        }


        private void btnRemove_Click(object sender, EventArgs e)
        {

            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            char[] arrayPalavra1 = txtPalavra1.Text.ToCharArray();
            Array.Reverse(arrayPalavra1);
            txtPalavra2.Text = new string(arrayPalavra1);

        }
    }
}
