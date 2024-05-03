namespace PTesteMetodos
{
    partial class frmExercicio4
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
            this.btnProcuraVazio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCountNumeric = new System.Windows.Forms.Button();
            this.rchTxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnContarLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcuraVazio
            // 
            this.btnProcuraVazio.Location = new System.Drawing.Point(192, 186);
            this.btnProcuraVazio.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcuraVazio.Name = "btnProcuraVazio";
            this.btnProcuraVazio.Size = new System.Drawing.Size(143, 59);
            this.btnProcuraVazio.TabIndex = 18;
            this.btnProcuraVazio.Text = "Contar espaços em branco";
            this.btnProcuraVazio.UseVisualStyleBackColor = true;
            this.btnProcuraVazio.Click += new System.EventHandler(this.btnProcuraVazio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Texto";
            // 
            // btnCountNumeric
            // 
            this.btnCountNumeric.Location = new System.Drawing.Point(29, 186);
            this.btnCountNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.btnCountNumeric.Name = "btnCountNumeric";
            this.btnCountNumeric.Size = new System.Drawing.Size(124, 59);
            this.btnCountNumeric.TabIndex = 15;
            this.btnCountNumeric.Text = "Contar numéricos";
            this.btnCountNumeric.UseVisualStyleBackColor = true;
            this.btnCountNumeric.Click += new System.EventHandler(this.btnCountNumeric_Click);
            // 
            // rchTxtTexto
            // 
            this.rchTxtTexto.Location = new System.Drawing.Point(53, 42);
            this.rchTxtTexto.Name = "rchTxtTexto";
            this.rchTxtTexto.Size = new System.Drawing.Size(100, 96);
            this.rchTxtTexto.TabIndex = 19;
            this.rchTxtTexto.Text = "";
            // 
            // btnContarLetras
            // 
            this.btnContarLetras.Location = new System.Drawing.Point(356, 186);
            this.btnContarLetras.Margin = new System.Windows.Forms.Padding(2);
            this.btnContarLetras.Name = "btnContarLetras";
            this.btnContarLetras.Size = new System.Drawing.Size(143, 59);
            this.btnContarLetras.TabIndex = 20;
            this.btnContarLetras.Text = "Contar letras";
            this.btnContarLetras.UseVisualStyleBackColor = true;
            this.btnContarLetras.Click += new System.EventHandler(this.btnContarLetras_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnContarLetras);
            this.Controls.Add(this.rchTxtTexto);
            this.Controls.Add(this.btnProcuraVazio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCountNumeric);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcuraVazio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCountNumeric;
        private System.Windows.Forms.RichTextBox rchTxtTexto;
        private System.Windows.Forms.Button btnContarLetras;
    }
}