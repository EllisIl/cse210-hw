using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string UserName = PromptUserName();
        int FavNum = PromptUserNumber();
        int SqNum = SquareNumber(FavNum);
        DisplayResult(UserName, SqNum);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int num){
        return num * num;
    }

    static void DisplayResult(string UserName, int SqNum){
        Console.WriteLine($"{UserName}, the square of your number is {SqNum}");
    }
}