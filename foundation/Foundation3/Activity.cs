using System;
using System.Collections.Generic;

public abstract class Activity
{
    private DateTime date;
    private double durationInMinutes;
    public Activity(DateTime date, double durationInMinutes)
    {
        this.date = date;
        this.durationInMinutes = durationInMinutes;
    }
    public DateTime Date => date;
    public double DurationInMinutes => durationInMinutes;
    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0; 
    public string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({DurationInMinutes} min): Distance {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F2} min per mile";
    }
}