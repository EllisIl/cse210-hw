using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureRef NewRef = new();
        NewRef.RandRef();

        ScriptureText NewText = new();
        NewText.GetTextIndex(NewRef.RefIndex);
        NewText.ConvertTextToList();

        RemoveWord remWord = new();
        remWord.SetPhrase(NewText.TextList, NewRef.Refer);

        remWord.PrintList();

        remWord.RemoveElement(true);


        while(remWord.ItemsRemoved < NewText.TextList.Count)
        {
            remWord.RemoveElement(false);
        }
    }
}
