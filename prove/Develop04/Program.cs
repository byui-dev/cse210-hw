using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        while (!quit)
        {
        
            Console.Clear()
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1.Start Breathing Activity ");
            Console.WriteLine("2.Start Reflecting Activity ");
            Console.WriteLine("3.Start Listing Activity ");
            Console.WriteLine("4.Quit ");
            
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            switch (input)   
            {
                case "1":
                    var breathingactivity = new BreathingActivity();
                    breathingactivity.Execute();
                    break;

                case "4":
                    var reflectingactivity = new ReflectingActivity();
                    reflectingactivity.Execute();
                    break;

                case "3":
                    var listingactivity = new ListingActivity();
                    listingactivity.Execute();
                    break;

                case "4":
                    quit = true;
                    Console.WriteLine();
                    break;
                default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
            }
  
            if (!quit)
            {
                Console.WriteLine("Enter any key to return to the main menu");
                Console.ReadKey();
            }
        }
    }
}
