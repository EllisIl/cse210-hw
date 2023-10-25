class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new("Jane Smith", "Algebra", "Section 2.1", "Problems 1-10");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
    
        Console.WriteLine();

        WritingAssignment writing = new("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    
    }
}