using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private ScriptureReference reference;
    private List<Word> words;

    public Scripture(ScriptureReference reference, string text)
    {
        this.reference = reference;
        this.words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public Scripture(ScriptureReference reference, List<string> verses)
    {
        this.reference = reference;
        this.words = string.Join(" ", verses).Split(' ').Select(word => new Word(word)).ToList();
    }
    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"{reference.ToString()}:");
        foreach (var word in words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }
    public void HideRandomWord()
    {
        var visibleWords = words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count == 0) return;

        Random random = new Random();
        var randomWord = visibleWords[random.Next(visibleWords.Count)];
        randomWord.Hide();
    }
    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden);
    }
}