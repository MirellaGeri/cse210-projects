public class Swimming : Activity
{
    private int numberOfLaps;
    public Swimming(DateTime date, double durationInMinutes, int numberOfLaps)
        : base(date, durationInMinutes)
    {
        this.numberOfLaps = numberOfLaps;
    }
    public override double GetDistance()
    {
        return (numberOfLaps * 50) / 1000.0 * 0.62; 
    }
    public override double GetSpeed()
    {
        return (GetDistance() / DurationInMinutes) * 60; 
    }
    public override double GetPace()
    {
        return DurationInMinutes / GetDistance(); 
    }
}