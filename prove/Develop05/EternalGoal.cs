class EternalGoal : Goal
{
    List<string> goalNames;
    List<string> goalDescs;
    List<int> goalPoints;

    public override void CreateGoal(){
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string goalDesc = Console.ReadLine(); 

        Console.Write("How many points is this worth? ");
        int points = int.Parse(Console.ReadLine());

        goalNames.Add(goalName);
        goalDescs.Add(goalDesc);
        goalPoints.Add(points);
    }
    public override void CompleteGoal(int index){
        // never completes, just add points
        
    }
}