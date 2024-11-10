using System;

class Program
{
    static void Main(string[] args)
    {
        string name, lastname;
        Console.Write("What is your first name? ");
        name = Console.ReadLine();
        Console.Write("What is your last name? ");
        lastname = Console.ReadLine();
        Console.WriteLine($"Your name is {lastname}, {name} {lastname}.");

    }
}