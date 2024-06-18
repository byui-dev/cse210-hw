using System;

public class Resume
{
    public string _name;

    // Initializes list to a new list

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Custom data type "Job" being used
        foreach (Job job in _jobs)
        {
            // The Display method is being called
            job.Display();
        }
    }
}


