﻿using System;
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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnTestar2_Click(object sender, EventArgs e)
        {
            int meio = txtPalavra2.Text.Length / 2;

            txtPalavra2.Text = txtPalavra2.Text.Substring(0, meio) + txtPalavra1.Text + txtPalavra2.Text.Substring(meio, txtPalavra2.Text.Length - meio);
        }

        private void btnTestar1_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtPalavra1.Text, txtPalavra2.Text, true) == 0)
            {
                MessageBox.Show("São iguais");
            }
            else
            {
                MessageBox.Show("São difernetes");
            }
        }

        private void btnInserirAsterisco_Click(object sender, EventArgs e)
        {
            int meio = txtPalavra1.Text.Length / 2;

            txtPalavra2.Text = txtPalavra1.Text.Substring(0, meio) + "**" + txtPalavra1.Text.Substring(meio, txtPalavra1.Text.Length - meio);
        }
    }
}
