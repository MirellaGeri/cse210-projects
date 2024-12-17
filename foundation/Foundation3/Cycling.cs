using System;
public class Cycling : Activity
{
    private double speedInKph;  
    public Cycling(DateTime date, double durationInMinutes, double speedInKph)
        : base(date, durationInMinutes)
    {
        this.speedInKph = speedInKph;
    }
    public override double GetDistance()
    {
        return (speedInKph * DurationInMinutes) / 60; 
    }
    public override double GetSpeed()
    {
        return speedInKph * 0.62;
    }
    public override double GetPace()
    {
        double speedInMph = speedInKph * 0.62; 
        return 60 / speedInMph;
    }
}