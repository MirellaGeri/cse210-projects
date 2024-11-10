using System;

class Program
{
    static void Main(string[] args)
    {
        string message, letter ;
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        if (number>=70){
            message = "Congratulations, you passed!";
            letter = "C";
            if(number>=80){
                letter = "B";
                if (number>=90){
                    letter = "A";
                }
            }
        }else{
            message = "Don't give up, keep trying!";
            letter = "F";
            if (number>=60){
                letter = "D";
            }
        }
        Console.WriteLine($"Your grade is: {letter}");
        Console.WriteLine($"{message}");
    }
}