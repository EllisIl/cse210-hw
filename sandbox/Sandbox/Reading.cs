public class Reading
{
    public void MakeDict()
    {
        var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };
            
        foreach(var kvp in cities)
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
    }
}

