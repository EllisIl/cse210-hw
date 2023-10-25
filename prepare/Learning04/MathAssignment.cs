
class MathAssignment : Assignment
{
    protected string TextbookSection;
    protected string Problems;

    public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name, topic)
    {
        TextbookSection = textbookSection;
        Problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{TextbookSection} {Problems}";
    }
}