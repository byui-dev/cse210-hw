using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lecture = new Lectures();
        Receptions reception = new Receptions();
        OutdoorGatherings outdoorGathering = new OutdoorGatherings();

        SetEventInfo(lecture, "Annual Peace Lecture", "A peace lecture to be delivered by UN Peace Ambassador", "John Doe", new DateTime(2023, 1, 15), new TimeSpan(14, 0, 0), "123 Main St, City", 200, "contact@peacelecture.com");
        SetEventInfo(reception, "Wedding Reception", "Wedding Reception for Thomas Brady and Chelsea Spencer", "", new DateTime(2023, 3, 10), new TimeSpan(18, 0, 0), "456 Park Ave, Town", 150, "rsvp@bradyspencer.com");
        SetEventInfo(outdoorGathering, "Summer Music Festival", "Annual outdoor music festival featuring local bands", "", new DateTime(2023, 7, 1), new TimeSpan(12, 0, 0), "789 Beach Rd, Resort", 1000, "info@summerfest.com", "Sunny with a high of 75°F");

        DisplayEventInfo(lecture, "Lecture");
        DisplayEventInfo(reception, "Reception");
        DisplayEventInfo(outdoorGathering, "Outdoor Gathering");
    }

    static void SetEventInfo(Event ev, string title, string description, string speaker, DateTime date, TimeSpan time, string address, int capacity, string email, string weather = "")
    {
        ev.EventTitle = title;
        ev.EventDescription = description;
        ev.SpeakerName = speaker;
        ev.EventDate = date;
        ev.EventTime = time;
        ev.EventAdd = new EventAddress { StreetAddress = address };
        ev.EventCapacity = capacity;
        ev.EMail = email;
        if (ev is OutdoorGatherings)
        {
            ((OutdoorGatherings)ev).WeatherStatement = weather;
        }
    }

    static void DisplayEventInfo(Event ev, string eventType)
    {
        Console.WriteLine($"\n{eventType} Information:");
        Console.WriteLine($"Short Description: {ev.ShortDescription()}");
        Console.WriteLine($"Standard Details: {ev.StandardDetails()}");
        Console.WriteLine($"Full Details: {ev.FullDetails()}");
    }
}
