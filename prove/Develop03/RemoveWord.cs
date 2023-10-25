using System.Diagnostics.Tracing;

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

    public void RemoveElement() // removes a random element in the list
    {
        for(int i = 0; i < 2; i++){
            int index;
            do index = RandIndex(); while(Phrase[index].Contains('_')); // get a random index that does not contain underscores

            Phrase[index] = new string('_', Phrase[index].Length); // set the item in the list to a string with the same length of underscores

            ItemsRemoved += 1;
            PrintList(); // print out the newly changed list
        }    
    }
}
