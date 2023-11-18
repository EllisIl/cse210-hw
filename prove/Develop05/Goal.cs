abstract class Goal
{
    List<string> goalNames;
    List<string> goalDescs;
    List<int> goalPoints;
    List<string> goalCompletions;

    public List<string> GetGoalNames(){
        return goalNames;
    }
    public List<string> GetGoalDescs(){
        return goalDescs;
    }

    public abstract void CreateGoal();

    public abstract void CompleteGoal(int index);

    public List<int> AppendScores(List<int> pointList, int points){
        return pointList;
    }
}