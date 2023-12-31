using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureRef NewRef = new();
        NewRef.RandRef();

        ScriptureText NewText = new();
        NewText.GetTextIndex(NewRef.GetRefIndex());
        NewText.ConvertTextToList();

        RemoveWord remWord = new();
        remWord.SetPhrase(NewText.GetTextList(), NewRef.GetRefer());

        remWord.PrintList();

        remWord.RemoveElements(1);


        while(remWord.GetItemsRemoved() < NewText.GetTextList().Count)
        {
            remWord.RemoveElements(2);
        }
    }
}
