using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int choice;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do {
            Console.Write("Enter a number: ");
            choice = int.Parse(Console.ReadLine());
            if (choice != 0){
                numbers.Add(choice);
            }
        } while (choice != 0);

        int sum = 0;

        foreach (int num in numbers){
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
        Console.WriteLine($"The smallest positive number is: {numbers.Where(x => x >= 0).Min()}");

        Console.Write("The sorted list is: ");

        numbers.Sort();

        foreach (int num in numbers){
            Console.Write($"{num} ");
        }

    }
}