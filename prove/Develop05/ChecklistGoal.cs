class ChecklistGoal : Goal
{
    List<string> goalNames;
    List<string> goalDescs;
    List<int> goalPoints;
    List<int> timesToComplete;
    List<int> bigBonus;

    public override void CreateGoal(){
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string goalDesc = Console.ReadLine(); 

        Console.Write("How many times do you want to complete this goal before it is checked off? ");
        int timesCompleted = int.Parse(Console.ReadLine());

        Console.Write("How many points is this worth each time it is completed? ");
        int points = int.Parse(Console.ReadLine());

        Console.Write("How many points extra should the final completion give? ");
        int bonusPoints = int.Parse(Console.ReadLine());

        goalNames.Add(goalName);
        goalDescs.Add(goalDesc);
        goalPoints.Add(points);
        timesToComplete.Add(timesCompleted);
        


    }
    public override void CompleteGoal(int index){
        // Make sure the goal is completed x number of times before actually checked off as complete.
        // last time completed adds normal points AND the Big Bonus!
    }
}