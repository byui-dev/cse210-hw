public class Swimming : Activity
{
    public override double CalculateDistance()
    {
        return Distance;
    }

    public override double CalculatePace()
    {
        return Duration / Distance;
    }

    public override double CalculateSpeed()
    {
        return Distance / (Duration / 60.0);
    }

    public override int CalculateLaps()
    {
        return (int)(Distance / 0.1);  
    }

    public override string ActivitySummary()
    {
        return $"Summary: {ActivityDate} Swimming for {Duration} minutes - Distance: {Distance} km, Speed: {Speed} km/h, Pace: {Pace} min/km";
    }
}
