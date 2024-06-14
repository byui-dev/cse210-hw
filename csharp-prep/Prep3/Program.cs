using System;

class Program
{
    static void Main(string[] args)
    {
        // Parts 1 and 2, where the user specifies a number
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
    
        // For Part 3, where we use a random number
       Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        
        int guess = -1;
    
       // While loop being used
       while (guess != magicNumber)
       {
           Console.Write("What is your guess? ");
           guess = int.Parse(Console.ReadLine());

           if (magicNumber > guess)
           {
              Console.WriteLine("Higher");
           }
           else if (magicNumber < guess)
           {
              Console.WriteLine("Lower");  
           }
           else
           {
             Console.WriteLine("You guessed it!");
           }
        }

    }    
    
}


