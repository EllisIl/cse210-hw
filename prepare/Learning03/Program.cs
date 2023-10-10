using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac = new();

        frac.GetFraction();
        Console.WriteLine(frac.GetFractionString());
        Console.WriteLine(frac.GetDecimalValue());
        
        frac.GetFraction(5);
        Console.WriteLine(frac.GetFractionString());
        Console.WriteLine(frac.GetDecimalValue());

        frac.GetFraction(3, 4);
        Console.WriteLine(frac.GetFractionString());
        Console.WriteLine(frac.GetDecimalValue());

        frac.GetFraction(1, 3);
        Console.WriteLine(frac.GetFractionString());
        Console.WriteLine(frac.GetDecimalValue());

    }
}