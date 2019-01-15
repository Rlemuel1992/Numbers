using System;
using System.Linq;
using System.Threading;



namespace Numbers100
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("What would you like me to address you as?");
			string name = Console.ReadLine();
			Next(name);
		}

		public static bool IsOdd(int value)
		{
			return value % 2 != 0;
		}
		public static bool IsEven(int value)
		{
			return value % 2 == 0;
		}

		static void Next(string name)
			{
			Console.WriteLine("Hello " + name + "! Hope you're doing well today.\n\n" +
				"Please enter a number from 1-100 and I'll do some cool stuff for you " + name + ".");


			int number = 1;

			try 

			{
				number = int.Parse(Console.ReadLine());
			}

			catch (FormatException)

			{
				Console.WriteLine("Please use whole numbers only");
			}

			if (number == 0)
			{
				Console.WriteLine("Please use a number greater than 0!");
				Next(name);

			}
			else if (number <= -1)
			{
				Console.WriteLine("No negative numbers please!");
				Next(name);
			}

			else if (IsOdd(number) && number >= 1 && number < 100)
			{
				Console.WriteLine("Your number " + number + " is odd");
			}
			else if (IsEven(number) && number > 1 && number < 25)
			{
				Console.WriteLine("Even and under 25");
			}
			else if (IsEven(number) && number > 25 && number <= 60)
			{
				Console.WriteLine("Even");
			}

			else if (IsEven(number) && number > 60 && number <= 100)
			{
				Console.WriteLine("Your number " + number + " is even.");
			}

			else if (number > 100)
			{
				Console.WriteLine("Your number " + number + " is too high for this program!");
			}

			 bool retry = true;
			while (retry == true)
			{

			Console.WriteLine("Would you like to do another?");
			string didYouWantToContinueThisProgramForASecondOrThirdOrFourthTimeOrReallyHoweverManyTimesYouWantToContinueDoWhatYouWantImNotYourKeeper = Console.ReadLine();

				if (didYouWantToContinueThisProgramForASecondOrThirdOrFourthTimeOrReallyHoweverManyTimesYouWantToContinueDoWhatYouWantImNotYourKeeper == "y")
				{
					Next(name);
				}

				else if (didYouWantToContinueThisProgramForASecondOrThirdOrFourthTimeOrReallyHoweverManyTimesYouWantToContinueDoWhatYouWantImNotYourKeeper == "n")
				{
					Console.WriteLine("Alright, press any button to exit. goodbye!");
					Console.ReadKey();
					Environment.Exit(1);
				}

				else
				{
					Console.WriteLine("I didn't get that, please make sure you type 'y' or 'n' in lowercase");
					retry = true;
				}
			}
		}
	}
}
