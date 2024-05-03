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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCountNumeric_Click(object sender, EventArgs e)
        {
            var rchText = rchTxtTexto.Text;
            var lenghtTxt1 = rchText.Length;
            int i = 0, numericsCount = 0;
            while(i < lenghtTxt1)
            {
                if (Char.IsNumber(rchText[i]))
                {
                    numericsCount++;
                }
                i++;
            }
            MessageBox.Show("Quantidade de números : "+numericsCount);
        }

        private void btnProcuraVazio_Click(object sender, EventArgs e)
        {
            var rchText = rchTxtTexto.Text;
            var lenghtTxt1 = rchText.Length;
            int wSpacesCount = 0;
            for (int i = 0; i < lenghtTxt1; i++)
            {
                if (Char.IsWhiteSpace(rchText[i]))
                {
                    wSpacesCount++;
                }
            }
            MessageBox.Show("Quantidade de espaços em branco : " + wSpacesCount);

        }

        private void btnContarLetras_Click(object sender, EventArgs e)
        {
            var rchText = rchTxtTexto.Text;
            int lettersCount = 0;
            foreach (var letter in rchText)
            {
                if (Char.IsLetter(letter))
                {
                    lettersCount++;
                }
            }
            MessageBox.Show("Quantidade de letras : " + lettersCount);
        }
    }
}
