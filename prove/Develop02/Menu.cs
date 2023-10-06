class Menu
{
    // user picks a prompt
    // 1. Write a new entry
    //      Use the NewEntry class
    // 2. Display the journal
    //      Display every entry from the journal selected
    // 3. Save the journal
    //      Save the journal to the file
    // 4. load the journal
    //      Should replace any entires currently store in the journal
    //      User inputs a file that already contains csv values

    public static void DisplayOptions()
    {
        string filePath = "options.csv";
        string[] lines = File.ReadAllLines(filePath);

        Console.WriteLine("Please select from the following: ");
        foreach(string option in lines)
        {
            Console.WriteLine(option);
        }
        Console.Write("Please enter your selection: ");
        int choice = int.Parse(Console.ReadLine());
        NewEntry entry = new();


        switch(choice){
            case 1: // New Entry
                entry.GetUserInput();
                entry.entries.Add(entry.entry);
                entry.prompts.Add(entry.prompt);
                entry.dates.Add(entry.date);
                break;
            case 2: // Display/Load Journal
                EditFile file = new();
                file.LoadJournal();
                break;
            case 3: // Save Journal
                EditFile userFile = new();
                userFile.SaveJournalEntry(entry.entries, entry.prompts, entry.dates);
                break;
        }
    }
}