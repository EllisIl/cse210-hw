class NewEntry
{
    public string entry;
    public string date;
    public string prompt;
    public List<string> entries = new();
    public List<string> prompts = new();
    public List<string> dates = new();

    private static List<string> LoadPrompts()
    {
        string filePath = "prompts.csv";
        if (File.Exists(filePath))
            return new List<string>(File.ReadAllLines(filePath));
        else
        {
            Console.WriteLine($"Error: File {filePath} not found.");
            return new List<string>();
        }
    }

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
        //save the prompt to a string for later use
        string selectedPrompt = RandomPrompt();

        //display the prompt to the user
        Console.WriteLine($"Your Prompt: {selectedPrompt}");

        //save the input, time, and prompt to the class variables
        entry = Console.ReadLine();
        date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        prompt = selectedPrompt;
    }
}