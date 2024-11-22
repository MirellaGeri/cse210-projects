using System;

class Program
{
    static void Main()
    {
        ScriptureReference reference = new ScriptureReference("John", 3, 16);
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Scripture scripture = new Scripture(reference, text);
        while (!scripture.AllWordsHidden())
        {
            scripture.Display();
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            else if (string.IsNullOrEmpty(input))
            {
                scripture.HideRandomWord();
            }
        }
        scripture.Display();
        Console.WriteLine("All words have been hidden. The program will now exit.");
    }
}