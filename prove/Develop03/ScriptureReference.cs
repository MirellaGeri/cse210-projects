using System;
public class ScriptureReference
{
    public string Book { get; }
    public int StartChapter { get; }
    public int StartVerse { get; }
    public int? EndVerse { get; }

    public ScriptureReference(string book, int chapter, int verse)
    {
        Book = book;
        StartChapter = chapter;
        StartVerse = verse;
        EndVerse = null;
    }
    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        StartChapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }
    public override string ToString()
    {
        if (EndVerse.HasValue)
        {
            return $"{Book} {StartChapter}:{StartVerse}-{EndVerse}";
        }
        else
        {
            return $"{Book} {StartChapter}:{StartVerse}";
        }
    }
}