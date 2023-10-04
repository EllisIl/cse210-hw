using System;

class Program
{
    static void Main(string[] args)
    {
        NewEntry lessConfusing = new()
        {
            entry = "This is a new string"
        };

        NewEntry moreConfusing = new()
        {
            entry = "Different string."
        };
        
        lessConfusing.Print();
        moreConfusing.Print();
    }
}