using System;
using System.Collections.Generic;
using System.Threading;

namespace ActivityApp
{
    public class ReflectingActivity : Activity
    {
        private List<string> initialPrompts;
        private List<string> followUpPrompts;
        private Random random;

        public ReflectingActivity()
        {
            initialPrompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            followUpPrompts = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };

            random = new Random();
        }

        public override void Display()
        {
            Console.WriteLine("Welcome to the Reflecting Activity.");
            Console.WriteLine();
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Console.WriteLine();
        }

        public override void PromptUserInput()
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int duration))
            {
                StartReflectingExercise(duration);
            }
            else
            {
                Console.WriteLine("Invalid input. Enter the correct number of seconds.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        private void StartReflectingExercise(int duration)
        {
            Console.Clear();
            Console.WriteLine("Get ready to begin your reflecting exercise...");

            DateTime endTime = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < endTime)
            {
                int index = random.Next(initialPrompts.Count);
                string selectedPrompt = initialPrompts[index];
                Console.WriteLine(selectedPrompt);
                Console.ReadLine();

                index = random.Next(followUpPrompts.Count);
                selectedPrompt = followUpPrompts[index];
                Console.WriteLine(selectedPrompt);
                Console.ReadLine();

                for (int i = 5; i > 0; i--)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Reflecting exercise complete. Well done.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public override void Execute()
        {
            Display();
            PromptUserInput();
        }
    }
}
