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
			this.labelNumber = new Label();
			this.numericUpDownDigitSum = new NumericUpDown();
			this.labelDigitSum = new Label();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownDigitSum).BeginInit();
			this.SuspendLayout();
			// 
			// labelNumber
			// 
			this.labelNumber.AutoSize = true;
			this.labelNumber.Location = new Point(12, 14);
			this.labelNumber.Name = "labelNumber";
			this.labelNumber.Size = new Size(49, 15);
			this.labelNumber.TabIndex = 0;
			this.labelNumber.Text = "number";
			// 
			// numericUpDownDigitSum
			// 
			this.numericUpDownDigitSum.Location = new Point(67, 12);
			this.numericUpDownDigitSum.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
			this.numericUpDownDigitSum.Name = "numericUpDownDigitSum";
			this.numericUpDownDigitSum.Size = new Size(120, 23);
			this.numericUpDownDigitSum.TabIndex = 1;
			this.numericUpDownDigitSum.TextAlign = HorizontalAlignment.Center;
			this.numericUpDownDigitSum.ValueChanged += this.NumericUpDownDigitSum_ValueChanged;
			// 
			// labelDigitSum
			// 
			this.labelDigitSum.AutoSize = true;
			this.labelDigitSum.Location = new Point(12, 53);
			this.labelDigitSum.Name = "labelDigitSum";
			this.labelDigitSum.Size = new Size(60, 15);
			this.labelDigitSum.TabIndex = 2;
			this.labelDigitSum.Text = "digit sum:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(207, 245);
			this.Controls.Add(this.labelDigitSum);
			this.Controls.Add(this.numericUpDownDigitSum);
			this.Controls.Add(this.labelNumber);
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "DigitX";
			((System.ComponentModel.ISupportInitialize)this.numericUpDownDigitSum).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private Label labelNumber;
		private NumericUpDown numericUpDownDigitSum;
		private Label labelDigitSum;
	}
}
