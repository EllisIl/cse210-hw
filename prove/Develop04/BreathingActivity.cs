class BreathingActivity : Activity
{
    private int breathingTime = 7;
    public void Breathing()
    {
        while(DateTime.Now < GetActivityEnd())
        {
            Console.Clear();

            Console.WriteLine("Breathe In");
            Animation(breathingTime);

            Console.Clear();

            Console.WriteLine("Breathe Out");
            Animation(breathingTime);

            breathingTime += 1;
        }
    }
}