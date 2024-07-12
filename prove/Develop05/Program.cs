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
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Select a choice from the menu");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        var start = new Start();
                        start.Execute();
                        break;
                    case "2":
                        var listgoalnames = new ListGoalNames();
                        listgoalnames.Execute();
                        break;
                    case "3":
                        var savegoals = new SaveGoals();
                        savegoals.Execute();
                        break;
                    case "4":
                        var loadgoals = new LoadGoals(); 
                        loadgoals.Execute();
                        break;
                    case "5":    
                        var recordevent = new RecordEvent();
                        recordevent.Execute();
                        break;
                    case "6":
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