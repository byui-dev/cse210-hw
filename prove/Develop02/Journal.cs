using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
   private List<Entry> entries = new List<Entry>();

   public void AddEntry(Entry entry)
   {
    entries.Add(entry);
   }

   public void DisplayJournal()
   {
      foreach (var entry in entries)
      {
          Console.WriteLine(entry);
      }
   }

   public void SaveJournal(string filename)
   {
      using (StreamWriter writer = new StreamWriter(filename))
      {
          foreach (var entry in entries)
          {
              
              writer.WriteLine(entry.Date.ToString("o"));
              writer.WriteLine(entry.Prompt);
              writer.WriteLine(entry.Response);
              writer.WriteLine("---");
          }
      }
    }
    
    public void LoadJournal(string filename)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
 
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (DateTime.TryParse(line, out DateTime date))
                {

                   string prompt = reader.ReadLine();
                   string response = reader.ReadLine();
                   entries.Add(new Entry(prompt, response) { Date = date });
                   reader.ReadLine();
                }
            }
        }        
    }
}        

        
    
      



   
