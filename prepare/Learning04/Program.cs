using System;

class Program
{
    static void Main(string[] args)
    {
    
        // The creation of a base "Assignment" object
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary()); 

        // To create the derived class assignments
        MathAssignment a2 = new MathAssignment("Roberto Rogriguez", "Fractions", "7.3" , "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        
        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation);
    }
}