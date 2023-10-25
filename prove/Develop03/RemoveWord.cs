class RemoveWord
{
    private List<string> Phrase;
    private string Reference;
    private int ItemsRemoved = 0;

    public int GetItemsRemoved()
    {
        return ItemsRemoved;
    }

    public void SetPhrase(List<string> StringList, string refer)
    {
        Phrase = StringList;
        Reference = refer;
    }

    private int RandIndex() // get a random number that represents an index for the list
    {
        var random = new Random();
        int index = random.Next(Phrase.Count);

        return index;
    }

    public void PrintList() // prints all the items in the list and prompts the user for input
    {
        Console.Clear();
        Console.Write($"{Reference}: ");
        foreach(string word in Phrase) Console.Write($"{word} "); // write every item in the list on a single line

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter to continue or type 'quit' to exit: ");
        string userIn = Console.ReadLine(); // prompt the user for input

        if(userIn == "quit"){ // if the user types "quit"
            Environment.Exit(0); // program exits
        }
    }

    public void RemoveElements(int count) // removes multiple random elements in the list
{
    for(int i = 0; i < count; i++)
    {
        int index;
        int attempt = 0;
        
        do 
        {
            index = RandIndex();
            attempt++;
            
            // Safety check to prevent infinite loop
            if(attempt > Phrase.Count * 2) 
            {
                Console.WriteLine("Too many attempts to find a word to remove.");
                return;
            }
        } 
        while(Phrase[index].Contains('_')); // get a random index that does not contain underscores

            Phrase[index] = new string('_', Phrase[index].Length); // set the item in the list to a string with the same length of underscores

            ItemsRemoved += 1;
            PrintList(); // print out the newly changed list
        }    
    }
}
