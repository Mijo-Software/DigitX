namespace DigitX
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNumber = new Label();
            numericUpDownDigitSum = new NumericUpDown();
            labelDigitSum = new Label();
            labelDigitProduct = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDigitSum).BeginInit();
            SuspendLayout();
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(12, 14);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(49, 15);
            labelNumber.TabIndex = 0;
            labelNumber.Text = "number";
            // 
            // numericUpDownDigitSum
            // 
            numericUpDownDigitSum.Location = new Point(67, 12);
            numericUpDownDigitSum.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericUpDownDigitSum.Name = "numericUpDownDigitSum";
            numericUpDownDigitSum.Size = new Size(120, 23);
            numericUpDownDigitSum.TabIndex = 1;
            numericUpDownDigitSum.TextAlign = HorizontalAlignment.Center;
            numericUpDownDigitSum.ValueChanged += NumericUpDownDigitSum_ValueChanged;
            // 
            // labelDigitSum
            // 
            labelDigitSum.AutoSize = true;
            labelDigitSum.Location = new Point(12, 53);
            labelDigitSum.Name = "labelDigitSum";
            labelDigitSum.Size = new Size(60, 15);
            labelDigitSum.TabIndex = 2;
            labelDigitSum.Text = "digit sum:";
            // 
            // labelDigitProduct
            // 
            labelDigitProduct.AutoSize = true;
            labelDigitProduct.Location = new Point(12, 68);
            labelDigitProduct.Name = "labelDigitProduct";
            labelDigitProduct.Size = new Size(79, 15);
            labelDigitProduct.TabIndex = 3;
            labelDigitProduct.Text = "digit product:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(207, 245);
            Controls.Add(labelDigitProduct);
            Controls.Add(labelDigitSum);
            Controls.Add(numericUpDownDigitSum);
            Controls.Add(labelNumber);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DigitX";
            ((System.ComponentModel.ISupportInitialize)numericUpDownDigitSum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumber;
		private NumericUpDown numericUpDownDigitSum;
		private Label labelDigitSum;
        private Label labelDigitProduct;
    }
}
