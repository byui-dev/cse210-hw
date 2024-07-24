public class Entry
{
    public DateTime Date { get; set; } // Property to store the date of the entry
    public string Prompt { get; set; } // Property to store the prompt
    public string Response { get; set; } // Property to store the response

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now; // Set the date to the current date and time
        Prompt = prompt; // Set the prompt
        Response = response; // Set the response
    }

    public override string ToString()
    {
        return $"{Date.ToString("g")}\nPrompt: {Prompt}\nResponse: {Response}\n"; // Return the entry as a string
    }
}
