using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int correctnumber = randomGenerator.Next(1, 11);
        int number;
        do
        {
            Console.Write("What is your guess? ");
            string numbertext = Console.ReadLine();
            number = int.Parse(numbertext);
            if (number == correctnumber){
                Console.WriteLine("You guessed it!");
            }else if(number < correctnumber){
                Console.WriteLine("Higher");
            }else{
                Console.WriteLine("Lower");
            }
        } while (number != correctnumber);
    }
}