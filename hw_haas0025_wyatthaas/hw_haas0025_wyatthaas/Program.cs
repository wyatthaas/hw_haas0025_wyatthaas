using System;
using System.Threading;

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
			Console.WriteLine("My name is xxx xxx. My OU 4x4 is xxx, and my GitHub account name is @xxxxxx. \n");

			Console.WriteLine("=== FLOW CONTROL LOOPS ===");
			Console.WriteLine("1) FOREACH_METHOD");
			Console.WriteLine("2) SKIP_NEG");
			Console.WriteLine("3) FOR_LOOP");
			Console.WriteLine("4) CURSOR_MOVEMENT");
			Console.WriteLine("5) WHILE_LOOP");
			Console.WriteLine("6) DOWHILE_LOOP");
			Console.WriteLine("7) Exit");
			Console.Write("\nSelect an option: ");

			string input = Console.ReadLine();

			if (input == "1")
			{
				FOREACH_METHOD();
			}
			else if (input == "2")
			{
				SKIP_NEG();
			}
			else if (input == "3")
			{
				FOR_LOOP();
			}
			else if (input == "4")
			{
				CURSOR_MOVEMENT();
			}
			else if (input == "5")
			{
				WHILE_LOOP();
			}
			else if (input == "6")
			{
				DOWHILE_LOOP();
			}
			else if (input == "7")
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

	// --- DEMO 1 ---

	static void FOREACH_METHOD()
	{
		int[] scores = { 75, 82, 91, 100, 64, 88 };
		foreach (int score in scores)
		{
			if (score == 100)
			{
				Console.WriteLine("Found a perfect score! Ending search.");
				break;
				// The loop stops here. It will NOT check 64 or 88.    
			}
			Console.WriteLine("Checking score: " + score);
		}

		Console.WriteLine("\nPress any key to return to menu...");
		Console.ReadKey();

	}

	// --- DEMO 2 ---

	static void SKIP_NEG()
	{
		int[] Numbers = { 11, 12, -1, -3, 15 };
		foreach (int num in Numbers)
		{
			if (num < 0)
			{
				Console.WriteLine("Skipping negative number");
				continue;
				// Jumps back to the top of the loop for the next number. } Console.WriteLine(“Numbers: " + num); 
			}
			else
			{
				Console.WriteLine("Numbers: " + num);
			}
		}

		Console.WriteLine("\nPress any key to return to menu...");
		Console.ReadKey();
	}

	// --- DEMO 3 ---

	static void FOR_LOOP()
	{
		Console.WriteLine("\nFOR LOOP PROGRESS:");
		for (int i = 0; i <= 20; i++)
		{
			// The \r tells the cursor: "Go back to the start!"
			// This allows the next print to overwrite the old one.
			Console.Write("\r[" + new string('#', i) + new string('-', 20 - i) + "] " + (i * 5) + "%");
			// Warning: \r only works with Console.Write().
			// If you use Console.WriteLine(), the cursor moves to a new line anyway, and the "overwrite" effect won't happen!

			Thread.Sleep(100);
			/* Thread: This refers to the "execution thread" (the path the code is currently following).
             * .Sleep: The action of pausing.
             * (100): The duration of the pause in milliseconds.
             * 1,000 milliseconds = 1 second.
             * Thread.Sleep(1000); → Pauses for exactly 1 second.
             * Thread.Sleep(500); → Pauses for half a second.
             * Thread.Sleep(100); → A very tiny pause (0.1 seconds).
             * */

			/* Why we use it here? 
             * In the Progress Bar: If you don't use Sleep, the bar jumps from 0% to 100% instantly. 
             * Adding Thread.Sleep(50); makes it look like it's actually downloading something.
             * */

			/* Note: Because this command lives in a specific part of the C# library, you must include this line at the very top of your code:
             * using System.Threading;
             * */

		}

		Console.WriteLine("\nPress any key to return to menu...");
		Console.ReadKey();
	}

	// --- DEMO 4 ---

	static void CURSOR_MOVEMENT()
	{
		// Visualizing the Cursor Movement
		Console.Write("Hello\nWorld");
		Console.Write("Hello\rWorld");

		Console.WriteLine("\nPress any key to return to menu...");
		Console.ReadKey();

	}

	// --- DEMO 5 ---

	static void WHILE_LOOP()
	{
		// THE WHILE LOOP
		Console.WriteLine("\nWHILE LOOP PROGRESS:");
		int i = 0; // Setup counter before the loop
		while (i <= 20)
		{
			Console.Write("\r[" + new string('#', i) + new string('-', 20 - i) + "] " + (i * 5) + "%");
			i++; // Don't forget to increment or it runs forever!
			Thread.Sleep(100);
		}

		Console.WriteLine("\nPress any key to return to menu...");
		Console.ReadKey();


	}

	// --- DEMO 6 ---

	static void DOWHILE_LOOP()
	{
		// THE DO-WHILE LOOP
		Console.WriteLine("\nDO-WHILE LOOP PROGRESS:");
		int j = 0;
		do
		{
			Console.Write("\r[" + new string('#', j) + new string('-', 20 - j) + "] " + (j * 5) + "%");
			j++;
			Thread.Sleep(100);
		} while (j <= 20);

		Console.WriteLine("\nPress any key to return to menu...");
		Console.ReadKey();

	}


}