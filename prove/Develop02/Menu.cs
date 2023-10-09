class Menu
{
    public static void DisplayOptions()
    {
        string filePath = "options.csv";
        string[] lines = File.ReadAllLines(filePath);
        int choice;

        do{
            Console.WriteLine("Please select from the following: ");
            foreach(string option in lines) // print out every element from the options.csv file
            {
                Console.WriteLine(option);
            }

            Console.Write("Please enter your selection: ");
            NewEntry entry = new();
            EditFile file = new();

            choice = int.Parse(Console.ReadLine());

            switch(choice){
                case 1: // New Entry
                    entry.GetUserInput();
                    entry.entries.Add(entry.entry);
                    entry.prompts.Add(entry.prompt);
                    entry.dates.Add(entry.date);
                    break;
                case 2: // Display Journal
                    file.DisplayJournal();
                    break;
                case 3: // Save Journal
                    file.SaveJournalEntry(entry.entries, entry.prompts, entry.dates);
                    break;
                case 4:
                    // file.LoadJournal();
                    break;
            } 
        } while (choice != 5);
        Console.WriteLine("Have a great day!");
    }
}