public class OutdoorGatherings : Event
{
    public override string StandardDetails()
    {
        return $"Title: {EventTitle}, Description: {EventDescription}, Time: {EventTime}, Address: {EventAdd}";
    }

    public override string FullDetails()
    {
        return $"Title: {EventTitle}, Description: {EventDescription}, Time: {EventTime}, Address: {EventAdd}, Weather: {WeatherStatement}";
    }

    public override string ShortDescription()
    {
        return $"Outdoor Gathering, Title: {EventTitle}, Date: {EventDate.ToShortDateString()}";
    }
}

