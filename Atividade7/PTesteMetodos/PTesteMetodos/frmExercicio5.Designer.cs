namespace PTesteMetodos
{
    partial class frmExercicio5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSorteio = new System.Windows.Forms.Button();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Numero 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Numero 1";
            // 
            // btnSorteio
            // 
            this.btnSorteio.Location = new System.Drawing.Point(48, 193);
            this.btnSorteio.Margin = new System.Windows.Forms.Padding(2);
            this.btnSorteio.Name = "btnSorteio";
            this.btnSorteio.Size = new System.Drawing.Size(124, 59);
            this.btnSorteio.TabIndex = 22;
            this.btnSorteio.Text = "Sorteio";
            this.btnSorteio.UseVisualStyleBackColor = true;
            this.btnSorteio.Click += new System.EventHandler(this.btnSorteio_Click);
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(132, 83);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(2);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(68, 20);
            this.txtPalavra2.TabIndex = 21;
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(132, 55);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(2);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(68, 20);
            this.txtPalavra1.TabIndex = 20;
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 341);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSorteio);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSorteio;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
    }
}