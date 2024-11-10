using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int Number = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (Number != 0)
        {
            Console.Write("Enter a number: ");
            string numbertext = Console.ReadLine();
            Number = int.Parse(numbertext);
            if (Number != 0)
            {
                numbers.Add(Number);
            }
        }
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int large = numbers[0];
        foreach (int num in numbers)
        {
            if (num > large)
            {
                large = num;
            }
        }
        Console.WriteLine($"The largest number is: {large}");
    }
}