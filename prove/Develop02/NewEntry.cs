class NewEntry
{
    public string entry;
    public string date;

    static string RandomPrompt() // gathers a random prompt from a csv file
    {
        // gather all the information from the csv file
        string filePath = "prompts.csv";
        string[] lines = File.ReadAllLines(filePath);

        // generate a random number and round it to be somewhere 
        // in the range of the list of prompts
        Random random = new();
        int randomLineNumber = random.Next(0, lines.Length); 

        // get a random item from the list using the random number
        string randomPrompt = lines[randomLineNumber];
    
        // return the random prompt
        return randomPrompt;
    }

    public void GetUserInput() // displays the random prompt, then gets the user's input
    {
        string selectedPrompt = RandomPrompt();

        Console.WriteLine($"Your Prompt: {selectedPrompt}");

        entry = Console.ReadLine();
        date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }
}