using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        // Use of a while loop or a do-while loop
        int userNumber = -1;
        while (userNumber !=0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            // This allows the number to be added to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Part 1 to compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is {sum}");

        // Part 2 allows us to compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is : {average}");

        // Part 3 allows us to find the max

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // the new max is found if this number is greater than the max!
                max = number;
            }
        } 

        Console.WriteLine($"The max is: {max}");
    }
}         