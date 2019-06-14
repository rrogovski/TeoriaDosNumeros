namespace WFA
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelPrimosAteP = new System.Windows.Forms.Label();
            this.buttonExeTeorema4 = new System.Windows.Forms.Button();
            this.textBoxVerificaPrimo = new System.Windows.Forms.TextBox();
            this.richTextBoxPrimos = new System.Windows.Forms.RichTextBox();
            this.label_InteiroPositivo = new System.Windows.Forms.Label();
            this.numericUpDown_inteiro = new System.Windows.Forms.NumericUpDown();
            this.labelDivisoresAteP = new System.Windows.Forms.Label();
            this.richTextBoxDivisores = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inteiro)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrimosAteP
            // 
            this.labelPrimosAteP.AutoSize = true;
            this.labelPrimosAteP.Location = new System.Drawing.Point(9, 70);
            this.labelPrimosAteP.Name = "labelPrimosAteP";
            this.labelPrimosAteP.Size = new System.Drawing.Size(38, 13);
            this.labelPrimosAteP.TabIndex = 14;
            this.labelPrimosAteP.Text = "Primos";
            // 
            // buttonExeTeorema4
            // 
            this.buttonExeTeorema4.Image = ((System.Drawing.Image)(resources.GetObject("buttonExeTeorema4.Image")));
            this.buttonExeTeorema4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExeTeorema4.Location = new System.Drawing.Point(138, 20);
            this.buttonExeTeorema4.Name = "buttonExeTeorema4";
            this.buttonExeTeorema4.Size = new System.Drawing.Size(75, 23);
            this.buttonExeTeorema4.TabIndex = 13;
            this.buttonExeTeorema4.Text = "Executar";
            this.buttonExeTeorema4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExeTeorema4.UseVisualStyleBackColor = true;
            this.buttonExeTeorema4.Click += new System.EventHandler(this.buttonExeTeorema2_Click);
            // 
            // textBoxVerificaPrimo
            // 
            this.textBoxVerificaPrimo.Location = new System.Drawing.Point(12, 47);
            this.textBoxVerificaPrimo.Name = "textBoxVerificaPrimo";
            this.textBoxVerificaPrimo.ReadOnly = true;
            this.textBoxVerificaPrimo.Size = new System.Drawing.Size(120, 20);
            this.textBoxVerificaPrimo.TabIndex = 12;
            // 
            // richTextBoxPrimos
            // 
            this.richTextBoxPrimos.Location = new System.Drawing.Point(12, 86);
            this.richTextBoxPrimos.Name = "richTextBoxPrimos";
            this.richTextBoxPrimos.ReadOnly = true;
            this.richTextBoxPrimos.Size = new System.Drawing.Size(769, 70);
            this.richTextBoxPrimos.TabIndex = 11;
            this.richTextBoxPrimos.Text = "";
            // 
            // label_InteiroPositivo
            // 
            this.label_InteiroPositivo.AutoSize = true;
            this.label_InteiroPositivo.Location = new System.Drawing.Point(9, 6);
            this.label_InteiroPositivo.Name = "label_InteiroPositivo";
            this.label_InteiroPositivo.Size = new System.Drawing.Size(54, 13);
            this.label_InteiroPositivo.TabIndex = 9;
            this.label_InteiroPositivo.Text = "Inteiro > 0";
            // 
            // numericUpDown_inteiro
            // 
            this.numericUpDown_inteiro.Location = new System.Drawing.Point(12, 22);
            this.numericUpDown_inteiro.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numericUpDown_inteiro.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_inteiro.Name = "numericUpDown_inteiro";
            this.numericUpDown_inteiro.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_inteiro.TabIndex = 10;
            this.numericUpDown_inteiro.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDivisoresAteP
            // 
            this.labelDivisoresAteP.AutoSize = true;
            this.labelDivisoresAteP.Location = new System.Drawing.Point(9, 161);
            this.labelDivisoresAteP.Name = "labelDivisoresAteP";
            this.labelDivisoresAteP.Size = new System.Drawing.Size(50, 13);
            this.labelDivisoresAteP.TabIndex = 16;
            this.labelDivisoresAteP.Text = "Divisores";
            // 
            // richTextBoxDivisores
            // 
            this.richTextBoxDivisores.Location = new System.Drawing.Point(12, 177);
            this.richTextBoxDivisores.Name = "richTextBoxDivisores";
            this.richTextBoxDivisores.ReadOnly = true;
            this.richTextBoxDivisores.Size = new System.Drawing.Size(769, 70);
            this.richTextBoxDivisores.TabIndex = 15;
            this.richTextBoxDivisores.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 345);
            this.Controls.Add(this.labelDivisoresAteP);
            this.Controls.Add(this.richTextBoxDivisores);
            this.Controls.Add(this.labelPrimosAteP);
            this.Controls.Add(this.buttonExeTeorema4);
            this.Controls.Add(this.textBoxVerificaPrimo);
            this.Controls.Add(this.richTextBoxPrimos);
            this.Controls.Add(this.label_InteiroPositivo);
            this.Controls.Add(this.numericUpDown_inteiro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Teoria dos Números";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_inteiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelPrimosAteP;
        private System.Windows.Forms.Button buttonExeTeorema4;
        private System.Windows.Forms.TextBox textBoxVerificaPrimo;
        private System.Windows.Forms.RichTextBox richTextBoxPrimos;
        private System.Windows.Forms.Label label_InteiroPositivo;
        private System.Windows.Forms.NumericUpDown numericUpDown_inteiro;
        private System.Windows.Forms.Label labelDivisoresAteP;
        private System.Windows.Forms.RichTextBox richTextBoxDivisores;
    }
}

