class Activity
{
    private DateTime activityEnd;
<<<<<<< HEAD
    protected TimeSpan duration;
    private double durationTime;
    // protected string message;
    // protected string activityName;
    // protected string finishedMessage;

    public void SetActivityEnd(int duration)
    {
        activityEnd = DateTime.Now.AddSeconds(duration);
    }

=======
    protected double durationTime; 

    public void SetActivityEnd(int durationInSeconds)
    {
        durationTime = durationInSeconds;
        activityEnd = DateTime.Now.AddSeconds(durationInSeconds + 5);
    }
>>>>>>> 54fe4bea82c529e302e1fb88abd1acd9db6ec9c3
    public DateTime GetActivityEnd()
    {
        return activityEnd;
    }

    public void SetDuration(int userDuration)
    {
        durationTime = userDuration;
        SetActivityEnd(userDuration);
    }
<<<<<<< HEAD
    public TimeSpan GetDuration(DateTime startTime)
    {
        return DateTime.Now - startTime;
    }
    public string PromptUser(string promptMessage)
=======

    static public string PromptUser(string promptMessage)
>>>>>>> 54fe4bea82c529e302e1fb88abd1acd9db6ec9c3
    {
        Console.Write(promptMessage);
        return Console.ReadLine();
    }
    public void Delay(int time)
    {
        Thread.Sleep(time * 1000);
    }
<<<<<<< HEAD
    public void Animation(int loadDuration)
=======
    public void MessageWithDelay(string message, int delayTime)
    {
        Console.Clear();
        Console.WriteLine(message);
        LoadingBar(delayTime);
        Console.Clear();
    }
    public void LoadingBar(int loadDuration)
>>>>>>> 54fe4bea82c529e302e1fb88abd1acd9db6ec9c3
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
<<<<<<< HEAD
=======
    public void Spinner(int durationInSeconds)
{
    char[] spinnerChars = { '/', '—', '\\', '|' };
    int spinnerIndex = 0;
    DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

    while (DateTime.Now < endTime)
    {
        // Display the next spinner character
        Console.Write("\r{0}", spinnerChars[spinnerIndex]);

        // Update the spinner index to the next character
        spinnerIndex++;
        if (spinnerIndex >= spinnerChars.Length)
        {
            spinnerIndex = 0;
        }

        // Slow down the spinner so it's visible
        Thread.Sleep(500);
    }

    // Clear the spinner from the current line after the duration has passed
    Console.Write("\r ");
}
>>>>>>> 54fe4bea82c529e302e1fb88abd1acd9db6ec9c3
    public string RandomItem(List<string> inputArray)
    {
        Random random = new();
        int randomNum = random.Next(0, inputArray.Count);
        return inputArray[randomNum];
    }
}