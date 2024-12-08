using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing",
    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."){ }

    public override void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(3); 

        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Now Breathe out...\n");
            ShowCountDown(3);
        }

        DisplayEndingMessage();
    }
}