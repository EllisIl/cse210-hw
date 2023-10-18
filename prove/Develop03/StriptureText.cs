class ScriptureText
{
    private List<string> TextsList = new()
    {
        "Therefore, take heed that ye see to this matter, and that portion that is necessary to benefit mine order, for the purpose of bringing forth my word to the children of men.",
        "For as the light of the morning cometh out of the east, and shineth even unto the west, and covereth the whole earth, so shall also the coming of the Son of Man be.",
        "And it is by your faith that you shall obtain a view of them, even by that faith which was had by the prophets of old.",
        "Therefore, I will unfold unto them this great mystery;",
        "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
        "5.Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6.In all thy ways acknowledge him, and he shall direct thy paths."
    };

    public int TextIndex;
    public List<string> TextList = new();
    
    public void GetTextIndex(int index)
    {
        TextIndex = index;
    }

    public void ConvertTextToList()
    {
        string text = TextsList[TextIndex];

        List<string> words = text.Split(' ').ToList();

        TextList = words;
    }
}