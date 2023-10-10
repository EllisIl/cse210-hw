class Menu
{
    public static void DisplayOptions()
    {
        string filePath = "options.csv";
        string[] lines = File.ReadAllLines(filePath);
        int choice;
        NewEntry entry = new(); // Declare outside of the loop to maintain data

        do
        {
            Console.WriteLine("Please select from the following: ");
            foreach (string option in lines) // print out every element from the options.csv file
            {
                Console.WriteLine(option);
            }


            Console.Write("Please enter your selection: ");
            choice = int.Parse(Console.ReadLine());

            EditFile file = new();
            switch (choice)
            {
                case 1:
                    entry.GetUserInput();
                    break;
                case 2:
                    file.DisplayJournal();
                    break;
                case 3: // Save Journal
                    EditFile userFile = new();
                    userFile.SaveJournalEntry(entry.entries, entry.prompts, entry.dates);
                    break;
                case 4:
                    // file.LoadJournal();
                    break;
            }
        } while (choice != 5);
        Console.WriteLine("Have a great day!");
    }
}