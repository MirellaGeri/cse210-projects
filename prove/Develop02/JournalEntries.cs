using System;
using System.Collections.Generic;
using System.IO;

public static class JournalEntries
{
    public static List<Entry> Entries = new List<Entry>();
    public static void AddEntry(string prompt, string response)
    {
        Entries.Add(new Entry(prompt, response, DateTime.Now));
    }

    public static void DisplayEntries()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("No entries to display.\n");
        }
        else
        {
            foreach (var entry in Entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    public static void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in Entries)
                {
                    writer.WriteLine($"{entry.Date.ToString("yyyy-MM-dd HH:mm:ss")},{entry.Prompt},{entry.Response}");
                }
            }
            Console.WriteLine("Journal saved successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving the journal: {ex.Message}\n");
        }
    }

    public static void LoadFromFile(string filename)
    {
        try
        {
            if (File.Exists(filename))
            {
                Entries.Clear();
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length >= 3)
                        {
                            DateTime date = DateTime.Parse(parts[0]);
                            string prompt = parts[1];
                            string response = parts[2];

                            Entries.Add(new Entry(prompt, response, date));
                        }
                    }
                }
                Console.WriteLine("Journal loaded successfully!\n");
            }
            else
            {
                Console.WriteLine("File not found!\n");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading the journal: {ex.Message}\n");
        }
    }
}