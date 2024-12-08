using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($" --- {prompt} ---"); 
        Console.WriteLine("You may begin in: "); 
        ShowCountDown(5);
        List<string> items = GetListFromUser();
        Console.WriteLine($"You listed {items.Count} items.");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item)) break;
            items.Add(item);
            _count++;
        }
        return items;
    }
}