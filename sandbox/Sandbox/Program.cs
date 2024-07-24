using System;
using System.IO

class Program
{
    static void Main(string[] args)
    {
        string[] prompts = { "Who was the most interesting person I interacted with today?", "What was the best part of my day?" , "How did I see the hand of the Lord in my life today?" , "What was the strongest emotion I felt today?" , If I had one thing I could do over today, what would it be?"" };
        string[] responses = new string[prompts.Length];
        DateTime date = DateTime.Now;

        for (int = 0; i < prompts.Length; i++)
        {
            Console.Write(prompts[i] + ": ");
            responses[i] = Console.ReadLine();
        }
       
        using (StreamWriter writer = new StreamWriter("journal.txt", true))
        {
            writer.WriteLine("Date: " +date.ToString());
            for (int i = 0; i < prompts.Length; i++)
            {
                writer.WriteLine(prompts[i] + ": " + responses[i]);
            }
        }
        Console.WriteLine("Entry saved successfully!");
    }
}