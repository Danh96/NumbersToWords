using System;

namespace NumbersToWords
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
				"eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen","eighteen", "nineteen" };

			string[] tens = { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

			Console.WriteLine("Please enter a number between 0 and 9999, this program will then represent it in words.");

			var input = string.Empty;

			input = Console.ReadLine();

			try
			{
				while (input.Length > 0)
				{
					if (input.Length > 1 && int.Parse(input[0].ToString()) == 0)
					{
						input = input.TrimStart(Convert.ToChar("0"));
					}
					else if (input.Length <= 1)
					{
						Console.Write(ones[int.Parse(input[0].ToString())] + " ");
						input = input.Remove(0, 1);
					}
					else if (input.Length <= 2 && int.Parse(input) <= 19)
					{
						Console.Write(ones[int.Parse(input)] + " ");
						input = input.Remove(0, 1);
						input = input.TrimStart(Convert.ToChar("0"));
					}
					else if (int.Parse(input) >= 20 && input.Length == 2)
					{
						Console.Write(tens[int.Parse(input[0].ToString())] + " ");
						input = input.Remove(0, 1);
						input = input.TrimStart(Convert.ToChar("0"));
					}
					else if (input.Length == 3)
					{
						Console.Write(ones[int.Parse(input[0].ToString())] + " hundred ");
						input = input.Remove(0, 1);
						input = input.TrimStart(Convert.ToChar("0"));
					}
					else if (input.Length == 4)
					{
						Console.Write(ones[int.Parse(input[0].ToString())] + " thousand ");
						input = input.Remove(0, 1);
						input = input.TrimStart(Convert.ToChar("0"));
					}
					else
					{
						Console.WriteLine("invalid input");
						break;
					}
				}
			}
			catch
			{
				Console.WriteLine("Invalid input");
			}
		}
	}
}