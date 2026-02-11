using System;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
		Console.WriteLine("--- Final Grade Calculator ---");

		Console.WriteLine("Enter your first and last name: ");
		string FirstLastName = Console.ReadLine();

		Console.WriteLine("Enter your student ID number: ");
		string StudentID = Console.ReadLine();


		Console.WriteLine($"Welcome, {FirstLastName}");
		Console.WriteLine("I will need some information to calculate your final grade.");

		Console.WriteLine("Enter your quizzes grade: ");
		double qgrade = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter your participation grade: ");
		double pgrade = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter your homework grade: ");
		double hgrade = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter your midterm grade: ");
		double mgrade = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter your final exam grade: ");
		double fgrade = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Enter your quizzes %: ");
		double qp = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter your participation %: ");
		double pp = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter your homework %: ");
		double hp = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter your midterm %: ");
		double mp = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter your final exam %: ");
		double fp = Convert.ToDouble(Console.ReadLine());

		string finalgrade = Convert.ToString(qgrade * qp + pgrade * pp + hgrade * hp + mgrade * mp + fgrade * fp);

		Console.WriteLine($"Your final grade is {finalgrade}%.");

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
