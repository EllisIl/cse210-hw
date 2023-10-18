class RemoveWord
{
    public List<string> Phrase;
    public string Reference;
    public int ItemsRemoved = 0;

    public void SetPhrase(List<string> StringList, string refer)
    {
        Phrase = StringList;
        Reference = refer;
    }

    private int RandIndex()
    {
        var random = new Random();
        int index = random.Next(Phrase.Count);

        return index;
    }

    public void PrintList()
    {
        Console.Clear();
        Console.Write($"{Reference}: ");
        foreach(string word in Phrase) Console.Write($"{word} ");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please enter to continue or type 'quit' to exit: ");
        string userIn = Console.ReadLine();

        if(userIn == "quit"){
            Environment.Exit(0);
        }

    }

    public void RemoveElement(bool first)
    {
        
        int index;
        if(first)
        {
            index = RandIndex();
            Phrase[index] = new string('_', Phrase[index].Length);
            ItemsRemoved += 1;
        } 
        else 
        {
            do
            {
                index = RandIndex();

            } while(Phrase[index].Contains('_'));

            Phrase[index] = new string('_', Phrase[index].Length);
            ItemsRemoved += 1;
        }

        PrintList();
    }

}