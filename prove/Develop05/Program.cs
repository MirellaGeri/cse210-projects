using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
         while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing Activity");
            Console.WriteLine("2. Start reflection Activity");
            Console.WriteLine("3. Start listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choise from menu: ");
            string choice = Console.ReadLine();

            Activity activity = null;
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    running = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    continue;
            }

            activity.Run();
        }
    }
}