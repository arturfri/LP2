namespace PTesteMetodos
{
    partial class frmExercicio2
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
            this.btnTestar2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTestar1 = new System.Windows.Forms.Button();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.btnInserirAsterisco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestar2
            // 
            this.btnTestar2.Location = new System.Drawing.Point(206, 186);
            this.btnTestar2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTestar2.Name = "btnTestar2";
            this.btnTestar2.Size = new System.Drawing.Size(124, 59);
            this.btnTestar2.TabIndex = 18;
            this.btnTestar2.Text = "Insere o primeiro no segundo";
            this.btnTestar2.UseVisualStyleBackColor = true;
            this.btnTestar2.Click += new System.EventHandler(this.btnTestar2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Palavra 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Palavra 1";
            // 
            // btnTestar1
            // 
            this.btnTestar1.Location = new System.Drawing.Point(56, 186);
            this.btnTestar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTestar1.Name = "btnTestar1";
            this.btnTestar1.Size = new System.Drawing.Size(124, 59);
            this.btnTestar1.TabIndex = 15;
            this.btnTestar1.Text = "Palavras são iguais";
            this.btnTestar1.UseVisualStyleBackColor = true;
            this.btnTestar1.Click += new System.EventHandler(this.btnTestar1_Click);
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(140, 76);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(68, 20);
            this.txtPalavra2.TabIndex = 14;
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(140, 48);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(68, 20);
            this.txtPalavra1.TabIndex = 13;
            // 
            // btnInserirAsterisco
            // 
            this.btnInserirAsterisco.Location = new System.Drawing.Point(351, 186);
            this.btnInserirAsterisco.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserirAsterisco.Name = "btnInserirAsterisco";
            this.btnInserirAsterisco.Size = new System.Drawing.Size(124, 59);
            this.btnInserirAsterisco.TabIndex = 19;
            this.btnInserirAsterisco.Text = "Inserir asteriscos";
            this.btnInserirAsterisco.UseVisualStyleBackColor = true;
            this.btnInserirAsterisco.Click += new System.EventHandler(this.btnInserirAsterisco_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnInserirAsterisco);
            this.Controls.Add(this.btnTestar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestar1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTestar1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.Button btnInserirAsterisco;
    }
}