class SimpleGoal : Goal
{
    List<string> goalNames;
    List<string> goalDescs;
    List<string> goalPoints;

    public override void CreateGoal(){
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string goalDesc = Console.ReadLine(); 

        Console.Write("How many points is this worth? ");
        string goalPoint = Console.ReadLine();

        goalNames.Add(goalName);
        goalDescs.Add(goalDesc);
        goalPoints.Add(goalPoint);
    }
    public override void CompleteGoal(int index){
        // goal is completed, removed off list
    }
}
