using System;

class Program
{
    static List<string> entries = new();

    static void Main(string[] args)
    {
        NewEntry entry = new();

        do{
            entry.GetUserInput();

            entries.Add(entry.entry);
        } while (entries.Count < 10);

        Console.WriteLine(string.Join(", ", entries));
    }
}