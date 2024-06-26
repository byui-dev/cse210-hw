using System;

public class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");

    }
} 
=======
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome to the Journal Program! ");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
         

            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    journal.AddEntry(new Entry(prompt, response));
                    break;
        
                case "2":
                    journal.DisplayJournal();
                    break;

                case "3":
                    Console.Write("Enter filename to load: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveJournal(saveFilename);
                    break;

                case "4":    
                   Console.Write("Enter filename to save: ");
                   string loadFilename = Console.ReadLine();
                   journal.LoadJournal(loadFilename);
                   break;

                case "5":
                   running = false;
                   break;

                default:
                   Console.WriteLine("Invalid option. Please try again.");
                   break;
            }
        }
    }
}               



    
    
    
>>>>>>> dac1d97f751bcf5f0c96067fcda85ec086f9d003
