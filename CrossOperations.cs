namespace DigitX
{
	internal class CrossOperations
	{
		// 1. private Digit Sum
		public static int DigitSum(int number)
		{
			int sum = 0;
			int n = Math.Abs(value: number);
			while (n > 0)
			{
				sum += n % 10;
				n /= 10;
			}
			return sum;
		}

		// 2. Digit Product
		public static int DigitProduct(int number)
		{
			int product = 1;
			int n = Math.Abs(value: number);
			if (n == 0)
			{
				return 0;
			}

			while (n > 0)
			{
				product *= n % 10;
				n /= 10;
			}
			return product;
		}

		// 3a. Alternating Digit Difference (from front/back)
		public static int AlternatingDigitDifference(int number, bool fromFront = true)
		{
			int n = Math.Abs(value: number);
			string text = n.ToString();
			int difference = 0;

			if (fromFront)
			{
				for (int i = 0; i < text.Length; i++)
				{
					int digit = text[index: i] - '0';
					difference += (i % 2 == 0) ? digit : -digit;
				}
			}
			else
			{
				bool plus = true;
				for (int i = text.Length - 1; i >= 0; i--)
				{
					int digit = text[index: i] - '0';
					difference += plus ? digit : -digit;
					plus = !plus;
				}
			}

			return difference;
		}

		// 3b. Simple Digit Difference (subtract all, from front/back)
		public static int SimpleDigitDifference(int number, bool fromFront = true)
		{
			int n = Math.Abs(value: number);
			string text = n.ToString();
			if (text.Length == 0)
			{
				return 0;
			}

			int difference;
			if (fromFront)
			{
				difference = text[index: 0] - '0';
				for (int i = 1; i < text.Length; i++)
				{
					difference -= text[index: i] - '0';
				}
			}
			else
			{
				difference = text[^1] - '0';
				for (int i = text.Length - 2; i >= 0; i--)
				{
					difference -= text[index: i] - '0';
				}
			}
			return difference;
		}

		// 4. Safe Digit Quotient (divide, skip zeros, from front/back)
		public static int SafeDigitQuotient(int number, bool fromFront = true)
		{
			int n = Math.Abs(value: number);
			string text = n.ToString();
			if (text.Length == 0)
			{
				return 0;
			}

            int quotient;
			if (fromFront)
			{
				quotient = text[index: 0] - '0';
				for (int i = 1; i < text.Length; i++)
				{
					int digit = text[index: i] - '0';
					if (digit != 0)
					{
						quotient /= digit;
					}
				}
			}
			else
			{
				quotient = text[^1] - '0';
				for (int i = text.Length - 2; i >= 0; i--)
				{
					int digit = text[index: i] - '0';
					if (digit != 0)
					{
						quotient /= digit;
					}
				}
			}

			return quotient;
		}
	}
}