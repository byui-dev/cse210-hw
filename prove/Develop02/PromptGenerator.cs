public class PromptGenerator
{
    private List<string> prompts = new List<string> // List of prompts
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    private Random random = new Random(); // Random number generator

    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count); // Get a random index
        return prompts[index]; // Return the prompt at that index
    }
}
