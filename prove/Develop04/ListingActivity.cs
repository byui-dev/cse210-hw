using System;
using System.Collections.Generic;
using System.Threading;

namespace ActivityApp
{
    public class ListingActivity : Activity
    {
        private List<string> Prompts;

        public ListingActivity()
        {
            Prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
        }

        public override void Display()
        {
            Console.WriteLine("Welcome to the Listing Activity");
            Console.WriteLine();
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.WriteLine();
        }

        public override void PromptUserInput()
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            string userInput = Console.ReadLine();
            int duration;
            if (int.TryParse(userInput, out duration))
            {
                StartListingExercise(duration);
            }
            else
            {
                Console.WriteLine("Invalid input. Enter the correct number of seconds.");
            }
        }

        private void StartListingExercise(int duration)
        {
            DateTime endTime = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < endTime)
            {
                Random random = new Random();
                int index = random.Next(Prompts.Count);
                string selectedPrompt = Prompts[index];
                Console.WriteLine(selectedPrompt);

                string userInput = Console.ReadLine();
                Console.WriteLine("You listed: " + userInput);

                for (int i = 5; i > 0; i--)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Listing exercise complete. Well done.");
        }

        public override void Execute()
        {
            Display();
            PromptUserInput();
        }
    }
}
