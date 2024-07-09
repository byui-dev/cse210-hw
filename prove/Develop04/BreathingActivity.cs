using System;
using System.Threading;

namespace ActivityApp
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
        }

        public override void Display()
        {
            Console.WriteLine("Welcome to the Breathing Activity");
            Console.WriteLine();
            Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.WriteLine();
        }

        public override void PromptUserInput()
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int duration))
            {
                StartBreathingExercise(duration);
            }
            else
            {
                Console.WriteLine("Invalid input. Enter the correct number of seconds.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        private void StartBreathingExercise(int duration)
        {
            Console.Clear();
            Console.WriteLine("Get ready to begin your breathing exercise...");
            DateTime endTime = DateTime.Now.AddSeconds(duration);
            bool breatheIn = true;
            while (DateTime.Now < endTime)
            {
                if (breatheIn)
                {
                    Console.WriteLine("Breathe in...");
                }
                else
                {
                    Console.WriteLine("Breathe out...");
                }
                for (int i = 5; i > 0; i--)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                breatheIn = !breatheIn;
            }
            Console.WriteLine("Breathing exercise complete. Well done.");
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
