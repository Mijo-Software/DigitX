namespace DigitX
{
	public partial class MainForm : Form
	{
		private int
            digitSum,
            digitProduct,
            simpleDigitDifference,
            alternatingDigitDifferenceFromFront,
            alternatingDigitDifferenceFromBack,
            safeDigitQuotientFromFront,
            safeDigitQuotientFromBack;

        public MainForm()
		{
			InitializeComponent();
		}

        private void NumericUpDownDigitSum_ValueChanged(object sender, EventArgs e)
        {
            int number = (int)numericUpDownDigitSum.Value;
            digitSum = CrossOperations.DigitSum(number: number);
            digitProduct = CrossOperations.DigitProduct(number: number);
            simpleDigitDifference = CrossOperations.SimpleDigitDifference(number: number);
            alternatingDigitDifferenceFromFront = CrossOperations.AlternatingDigitDifference(number: number, fromFront: true);
            alternatingDigitDifferenceFromBack = CrossOperations.AlternatingDigitDifference(number: number, fromFront: false);
            safeDigitQuotientFromFront = CrossOperations.SafeDigitQuotient(number: number, fromFront: true);
            safeDigitQuotientFromBack = CrossOperations.SafeDigitQuotient(number: number, fromFront: false);
            labelDigitSum.Text = $"digit sum: {digitSum}";
            labelDigitProduct.Text = $"digit product: {digitProduct}";
            labelSimpleDigitDifference.Text = $"simple digit difference: {simpleDigitDifference}";
            labelAlternatingDigitDifferenceFromFront.Text = $"alternating digit difference from front: {alternatingDigitDifferenceFromFront}";
            labelAlternatingDigitDifferenceFromBack.Text = $"alternating digit difference from back: {alternatingDigitDifferenceFromBack}";
            labelDigitQuotientFromFrontSafe.Text = $"digit quotient from front (safe): {safeDigitQuotientFromFront}";
            labelDigitQuotientFromBackSafe.Text = $"digit quotient from back (safe): {safeDigitQuotientFromBack}";
        }
    }
}
