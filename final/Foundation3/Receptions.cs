public class Receptions : Event
{
    public override string StandardDetails()
    {
        return $"Title: {EventTitle}, Description: {EventDescription}, Time: {EventTime}, Address: {EventAdd}";
    }

    public override string FullDetails()
    {
        return $"Title: {EventTitle}, Description: {EventDescription}, Time: {EventTime}, Address: {EventAdd}, RSVP: {EMail}";
    }

    public override string ShortDescription()
    {
        return $"Reception, Title: {EventTitle}, Date: {EventDate.ToShortDateString()}";
    }
}



 


