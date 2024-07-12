using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal(); // Create a new Journal object
        PromptGenerator promptGenerator = new PromptGenerator(); // Create a new PromptGenerator object
        bool running = true; // Boolean variable to control the loop

        while (running)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine(); // Read user input
            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt(); // Get a random prompt
                    Console.WriteLine(prompt); // Display the prompt
                    string response = Console.ReadLine(); // Read the user's response
                    journal.AddEntry(new Entry(prompt, response)); // Add the new entry to the journal
                    break;

                case "2":
                    journal.DisplayJournal(); // Display all journal entries
                    break;

                case "3":
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine(); // Read the filename to load
                    journal.LoadJournal(loadFilename); // Load the journal from the file
                    break;

                case "4":
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine(); // Read the filename to save
                    journal.SaveJournal(saveFilename); // Save the journal to the file
                    break;

                case "5":
                    running = false; // Exit the loop and end the program
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
