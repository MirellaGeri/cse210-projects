using System;

class Program
{
    static void WriteNewEntry()
    {
        Random random = new Random();
        string prompt = Prompts.List[random.Next(Prompts.List.Count)];

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your Response: ");
        string response = Console.ReadLine();

        JournalEntries.AddEntry(prompt, response);
        Console.WriteLine("Your entry has been saved!\n");
    }

    // Método para mostrar todas las entradas
    static void DisplayJournal()
    {
        JournalEntries.DisplayEntries();
    }

    // Método para guardar el diario en un archivo
    static void SaveJournalToFile()
    {
        Console.Write("Enter filename to save the journal: ");
        string filename = Console.ReadLine();
        JournalEntries.SaveToFile(filename);
    }

    // Método para cargar el diario desde un archivo
    static void LoadJournalFromFile()
    {
        Console.Write("Enter filename to load the journal: ");
        string filename = Console.ReadLine();
        JournalEntries.LoadFromFile(filename);
    }
    static void DisplayMenu()
    {
        Console.WriteLine("Journal Menu:");
        Console.WriteLine("1. Write journal");
        Console.WriteLine("2. Display journal");
        Console.WriteLine("3. Save journal");
        Console.WriteLine("4. Load journal");
        Console.WriteLine("5. Quit");
        Console.Write("Select an option (1-5): ");
    }
    static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournalToFile();
                    break;
                case "4":
                    LoadJournalFromFile();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.\n");
                    break;
            }
        }
    }
}