class Fraction
{
    private double numerator;
    private double denominator;

    public double GetNumerator()
    {
        return numerator;
    }

    public double GetDenominator()
    {
        return denominator;
    }

    public void SetNumerator(int newNum)
    {
        numerator = newNum;
    }

    public void SetDenominator(int newNum)
    {
        denominator = newNum;
    }

    public void GetFraction()
    {
        numerator = 1;
        denominator = 1;
    }
    public void GetFraction(double num)
    {
        numerator = num;
        denominator = 1;
    }

    public void GetFraction(double upNum, double downNum)
    {
        numerator = upNum;
        denominator = downNum;
    }

    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    public double GetDecimalValue()
    {
        return numerator/denominator;
    }

} 