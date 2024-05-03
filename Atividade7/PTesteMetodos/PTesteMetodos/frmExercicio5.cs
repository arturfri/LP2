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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            Random ramdNumber = new Random();
            int numero1, numero2; 

            if(Int32.TryParse(txtPalavra1.Text, out numero1) && Int32.TryParse(txtPalavra2.Text, out numero2))
            {

                var sortedNumber = ramdNumber.Next(numero1, numero2);
                MessageBox.Show("Número sorteado : " + sortedNumber);
            }else
            {
                MessageBox.Show("Insira apenas números");
            }
                
        }
    }
}
