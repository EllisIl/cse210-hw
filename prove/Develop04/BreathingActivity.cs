class BreathingActivity : Activity
{
    private int breathingTime = 7;
    public void Breathing()
    {
        while(DateTime.Now < GetActivityEnd())
        {
<<<<<<< HEAD
            Console.Clear();

            Console.WriteLine("Breathe In");
            Animation(breathingTime);

            Console.Clear();

            Console.WriteLine("Breathe Out");
            Animation(breathingTime);
=======
            MessageWithDelay("Breathe in", breathingTime);

            MessageWithDelay("Breathe out", breathingTime);
>>>>>>> 54fe4bea82c529e302e1fb88abd1acd9db6ec9c3

            breathingTime += 1;
        }
    }
}