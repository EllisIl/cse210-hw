using System;

class Program
{
    static void Main(string[] args)
    {
        bool playing = true;
        while (playing) {
            int guess;
            Random randomGenerator = new Random();
            int guesses = 0;

            int magicNum = randomGenerator.Next(1, 11);

            do {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guesses += 1;
                
                if (guess > magicNum){
                    Console.WriteLine("Lower");
                } else if (guess < magicNum){
                    Console.WriteLine("Higher");
                }
            } while (guess != magicNum);

            Console.WriteLine($"You guessed it in {guesses} guesses!");
            Console.Write("Would you like to play again? (y/n) ");
            char choice = char.Parse(Console.ReadLine());

            if (choice == 'n') {
                playing = false;
            }
        }
        Console.WriteLine("Thank you for playing!");
    }
}