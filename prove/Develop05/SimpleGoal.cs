public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points): base
        {
            _isComplete = IsComplete;
        }
    public override void RecordEvent()
        {
            Console.WriteLine("what is the name of your goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            string description = Console.ReadLine();
            Console.WriteLine("what is the amount of points associated with this goal?");
            string points = Console.ReadLine();
            int.TryParse(points);

        }

    public override bool IsComplete()
        {

        }
            
    public override string GetStringRepresentation()
        {
            string GetStringRepresentation = Console.ReadLine($"[ ] name (description)");
        }
    }
}



        