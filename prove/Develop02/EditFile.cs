class EditFile
{
    static string filepath;

    static void PromptUser()
    {
        Console.Write("Please enter the filepath to your csv file: ");
        filepath = Console.ReadLine();
    }

    public void SaveJournalEntry(List<string> entries, List<string> prompts, List<string> dates)
    {
        //get the filepath
        PromptUser();

        using (StreamWriter writer = new(filepath))
        {
            //loop through each item in the lists
            for (int i = 0; i < entries.Count; i++)
            {

            //write each entry from the list into the csv file, separating using ~|
                writer.WriteLine(string.Join("~|", prompts[i], entries[i], dates[i]));
            }
        }
        Console.WriteLine("Saved!");
    }

    public void LoadJournal()
    {
        //get the filepath
        PromptUser();

        //create a class that will read the file
        using (StreamReader reader = new(filepath))
        {
            //loop while there is still content
            while (!reader.EndOfStream)
            {
                //get the line and then split it using the preset seperating value
                var line = reader.ReadLine();
                var values = line.Split(new[] { "~|" }, StringSplitOptions.None);

                //print each part of the entry
                foreach (string value in values)
                {
                    Console.WriteLine(value);
                }

                //add and empty line at the end for formatting
                Console.WriteLine();
            }
        }
    }
}