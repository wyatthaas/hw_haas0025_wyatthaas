using System;

class Program
{

	/* Go to Tools > Options.
     * In the search bar at the top left of the window, type IntelliCode.
     * Find C# user model predictions (or "Whole line completions") and set it to Disabled.
     * */

	static void Main()
	{
		bool running = true;

		while (running)
		{
			Console.Clear();

			// Please write down your name first. 
			Console.WriteLine("My name is Wyatt Haas. My OU 4x4 is haas0025, and my GitHub account name is @wyatthaas. \n");

			Console.WriteLine("=== CALCULATOR SYSTEM ===");
			Console.WriteLine("1) Calculate Sale Total");
			Console.WriteLine("2) Calculate Student Grade");
			Console.WriteLine("3) Exit");
			Console.Write("\nSelect an option: ");

			string input = Console.ReadLine();

			if (input == "1")
			{
				SaleTotal();
			}
			else if (input == "2")
			{
				StudentGrade();
			}
			else if (input == "3")
			{
				Console.WriteLine("Exiting program...");
				running = false;
			}
			else
			{
				Console.WriteLine("Invalid choice. Press any key to try again.");
				Console.ReadKey();
			}
		}
	}

	// --- Question 1 ---

	static void SaleTotal()
	{
		Console.Clear();
		Console.WriteLine("--- Sale Total Calculator ---");

		// ENTER YOUR CODE HERE



		Console.WriteLine("\nPress any key to return to menu...");
		Console.ReadKey();
	}

	// --- Question 2 ---

	static void StudentGrade()
	{
		Console.Clear();
		Console.WriteLine("--- Student Grade Calculator ---");

		// ENTER YOUR CODE HERE

		// final grade calculator

// enter first name, last name (string)
// enter student ID (int)

// welcome, 'xxxxxx xxxxxx'

// enter your quizzes grade qgrade (double)
// enter participation pgrade (double)
// enter homework hgrade (double)
// enter midterm mgrade (double)
// enter final fgrade (double)

// enter your quizzes q% (double)
// enter participation p% (double)
// enter homework h% (double)
// enter midterm m% (double)
// enter final f% (double)

// calculate final grade
// qgrade*q% + pgrade*p% + hgrade*h% + mgrade*m% + fgrade*f% = finalgrade
// finalgrade= 'xxx'%;

// output finalgrade 'xxx'%;

		Console.WriteLine("\nPress any key to return to menu...");
		Console.ReadKey();
	}
}
