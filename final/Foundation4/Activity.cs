public abstract class Activity
{
    public DateTime ActivityDate { get; set; }
    public int Duration { get; set; }  // In minutes
    public double Distance { get; set; }  // In kilometers
    public double Speed { get; set; }  // In km/h
    public int NumberLaps { get; set; }
    public double Pace { get; set; }  // In min/km

    public abstract double CalculateDistance();
    public abstract double CalculatePace();
    public abstract double CalculateSpeed();
    public abstract int CalculateLaps();
    public abstract string ActivitySummary();
}
