public class ScriptureRef
{
    private List<string> RefList = new()
    {
        "D&C 96:4",
        "Joseph Smith—Matthew 1:26",
        "D&C 17:2",
        "D&C 10:64",
        "John 3:16",
        "Proverbs 3:5-6"
    };

    private int RefIndex;
    private string Refer;

    public int GetRefIndex()
    {
        return RefIndex;
    }

    public string GetRefer()
    {
        return Refer;
    }

    public string RandRef() 
    {
        Random random = new();
        int randomIndex = random.Next(RefList.Count);
        RefIndex = randomIndex;

        Refer = RefList[RefIndex];
        return RefList[randomIndex];
    }
}