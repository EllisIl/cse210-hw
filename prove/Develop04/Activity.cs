class Activity
{
    private DateTime activityEnd;
    protected TimeSpan duration;
    private double durationTime;
    // protected string message;
    // protected string activityName;
    // protected string finishedMessage;

    public void SetActivityEnd(int duration)
    {
        activityEnd = DateTime.Now.AddSeconds(duration);
    }

    public DateTime GetActivityEnd()
    {
        return activityEnd;
    }

    public void SetDuration(int userDuration)
    {
        durationTime = userDuration;
        SetActivityEnd(userDuration);
    }
    public TimeSpan GetDuration(DateTime startTime)
    {
        return DateTime.Now - startTime;
    }
    public string PromptUser(string promptMessage)
    {
        Console.Write(promptMessage);
        return Console.ReadLine();
    }
    public void Delay(int time)
    {
        Thread.Sleep(time * 1000);
    }
    public void Animation(int loadDuration)
    {
        int length = 20;
        string loadingBar;

        for (int i = 0; i <= length; i++)
        {
            loadingBar = "[" + new string('█', i) + new string('-', length - i) + "]";
            Console.Write("\r" + loadingBar); // \r moves the cursor to the start of the line
            Thread.Sleep(loadDuration * 1000 / length);
        }
    }
    public string RandomItem(List<string> inputArray)
    {
        Random random = new();
        int randomNum = random.Next(0, inputArray.Count);
        return inputArray[randomNum];
    }
}