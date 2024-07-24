public class Lectures : Event
{
    public override string StandardDetails()
    {
        return $"Title: {EventTitle}, Description: {EventDescription}, Time: {EventTime}, Address: {EventAdd}";
    }

    public override string FullDetails()
    {
        return $"Title: {EventTitle}, Description: {EventDescription}, Time: {EventTime}, Address: {EventAdd}, Speaker Name: {SpeakerName}, Capacity: {EventCapacity}";
    }

    public override string ShortDescription()
    {
        return $"Lecture, Title: {EventTitle}, Date: {EventDate.ToShortDateString()}";
    }
}

