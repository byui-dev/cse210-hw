using System;

namespace ActivityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (!quit)
            {
                Console.Clear();
                Console.WriteLine("Menu Options: ");
                Console.WriteLine("1. Start Breathing Activity");
                Console.WriteLine("2. Start Reflecting Activity");
                Console.WriteLine("3. Start Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Select a choice from the menu: ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        var breathingActivity = new BreathingActivity();
                        breathingActivity.Execute();
                        break;
                    case "2":
                        var reflectingActivity = new ReflectingActivity();
                        reflectingActivity.Execute();
                        break;
                    case "3":
                        var listingActivity = new ListingActivity();
                        listingActivity.Execute();
                        break;
                    case "4":
                        quit = true;
                        Console.WriteLine("Quitting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        Console.WriteLine("Press any key to return to the main menu");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
