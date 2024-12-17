using System;
public class Running : Activity
{
    private double distanceInMiles;
    public Running(DateTime date, double durationInMinutes, double distanceInMiles)
        : base(date, durationInMinutes)
    {
        this.distanceInMiles = distanceInMiles;
    }
    public override double GetDistance()
    {
        return distanceInMiles; 
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