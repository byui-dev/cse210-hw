using System.Runtime.CompilerServices;

public abstract class Event
{
    private DateTime eventDate;
    private TimeSpan eventTime;
    private string eventTitle;
    private string eventDescription;
    private  EventAddress eventAddress;
    private string speakerName;
    private int eventCapacity;
    private string eMail;

    private string weatherStatement;

    public DateTime EventDate
    {
        get {return eventDate;}
        set {eventDate = value;}
    }

    public TimeSpan EventTime
    {
        get {return eventTime;}
        set {eventTime = value;}
    }

    public EventAddress EventAdd
    {
        get { return eventAddress; }
        set { eventAddress = value; }
    }

    public string EventTitle
    {
        get { return eventTitle;}
        set { eventTitle = value;}


    }

    public string EventDescription
    {
        get { return eventDescription;}
        set { eventDescription = value;}

    }

    public string SpeakerName
    {
        get { return speakerName;}
        set { speakerName = value;}
    }

    public int EventCapacity
    {
        get { return eventCapacity;}
        set { eventCapacity = value;}
    }


    public string EMail
    {
        get { return eMail;}
        set { eMail = value;}
    }

    public string WeatherStatement
    {
        get { return weatherStatement;}
        set { weatherStatement = value;}
    }
    
 
    public abstract string StandardDetails();
    public abstract string FullDetails();
    public abstract string ShortDescription();
}
   
