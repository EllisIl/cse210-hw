class ListingActivity : Activity
{
    private DateTime startTime;

    private List<string> prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> things = new(){
        
    };

    public void Listing(){
        Console.WriteLine($"Think about the following prompt for {duration} seconds, and list as many things as you can. \nPress enter after each one.");
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(GetActivityEnd());
        while(DateTime.Now < GetActivityEnd())
        {
            Console.ReadLine();
        }
    }
}