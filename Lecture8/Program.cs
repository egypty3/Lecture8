using static System.Console;
namespace Lecture8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//TimesTable(8,20);

			//decimal taxToPay = CalculateTax(
			//	amount: 149,
			//	twoLetterRegionCode: "FR"
			//	);
			//WriteLine($"You must pay {taxToPay} in tax.");
			//RunCardinalToOrdinal();
			//double a = 4.5;
			//double b = 2.5;
			//double answer = Add(a, b);

			//WriteLine($"{a} + {b} = {answer}");
			//WriteLine("Press ENTER to end the app.");
			//ReadLine();

			Person person1 = new();
			person1.name = "Tarek";
			person1.DateOfBirth = new DateTime(1979, 2, 20);
			person1.PrintPersonData();

			Person person2 = new();
			person2.name = "Mahmoud";
			person2.DateOfBirth = new DateTime(1999, 4, 15);
			person2.PrintPersonData();
		}
		static double Add (double a, double b){
			return a + b;
			}
		// doesn't return value
		static void TimesTable(byte number, byte size = 12)
		{
			WriteLine($"This is the {number} times table with {size} rows :");
			for (int row = 1; row <= size; row++)
			{
				WriteLine($"{row} x {number} = {row * number}");
			}
			WriteLine();
		}

		static decimal CalculateTax(
			decimal amount, string twoLetterRegionCode)
		{
			decimal rate = 0;

			switch (twoLetterRegionCode)
			{
				case "CH": //Switzerland
					rate = 0.08M;
					break;
				case "DK": //Denmark					
				case "No": //Norway
					rate = 0.25M;
					break;
				case "GB": // United Kingdom
				case "FR": // France
					rate = 0.2M;
					break;
				case "HU": // Hungary				
					rate = 0.27M;
					break;
				case "OR": //Oregon
				case "AK": //Alaska
				case "MT": //Montana
					rate = 0;
					break;
				case "ND": // North Dakota
				case "WI": // Wisconsin
				case "ME": // Maine
				case "VA": // Virginia
					rate = 0.05M;
					break;
				case "CA": // California
					rate = 0.0825M;
					break;
				default: // most US states
					rate = 0.06M;
					break;
			}
			return amount * rate;
		}


		static string CardinalToOrdinal(int number)
		{
			int lastTwoDigits = number % 100;
			switch (lastTwoDigits)
			{
				case 11: // special cases for 11th to 13th
				case 12:
				case 13:
					return $"{number:N0}th";					
				default:
					int lastDigit = number % 10;

					string suffix = lastDigit switch
					{
						1 => "st",
						2 => "nd",
						3 => "rd",
						_ => "th"
					};
					return $"{number:N0}{suffix}";					
			}			
		}
		static void RunCardinalToOrdinal()
		{
			for (int number = 1; number <= 2000; number++)
			{
				Write($"{CardinalToOrdinal(number)} ");
			}
		}
	}
}