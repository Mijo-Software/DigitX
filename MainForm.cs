namespace DigitX
{
	public partial class MainForm : Form
	{
		private int digitSum;

		public MainForm()
		{
			InitializeComponent();
		}

		private void NumericUpDownDigitSum_ValueChanged(object sender, EventArgs e)
		{
			digitSum = CrossOperations.DigitSum(number: (int)numericUpDownDigitSum.Value);
			labelDigitSum.Text = $"digit sum: {digitSum}";
		}
	}
}
