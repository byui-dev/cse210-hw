using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries; // List to store journal entries

    public Journal()
    {
        entries = new List<Entry>(); // Initialize the entries list
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry); // Add a new entry to the list
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.ToString()); // Display each entry
        }
    }

    public void SaveJournal(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.ToString()); // Write each entry to the file
            }
        }
    }

    public void LoadJournal(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear(); // Clear existing entries
            string[] lines = File.ReadAllLines(filename); // Read all lines from the file
            for (int i = 0; i < lines.Length; i += 3) // Each entry is 3 lines
            {
                if (i + 2 < lines.Length) // Ensure there are enough lines for a complete entry
                {
                    string date = lines[i];
                    string prompt = lines[i + 1].Replace("Prompt: ", "");
                    string response = lines[i + 2].Replace("Response: ", "");
                    entries.Add(new Entry(prompt, response) { Date = DateTime.Parse(date) }); // Add the loaded entry to the list
                }
                else
                {
                    Console.WriteLine("Incomplete entry found in the file.");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
