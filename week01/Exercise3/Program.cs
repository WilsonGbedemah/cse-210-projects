using System;

class Program
{
    static void Main(string[] args)
    {

        string playAgain;

        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("I'm think of a number between 1 and 100.., can you guess it");

            while (guess != number)
            {
                Console.Write("What is the magic number? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else{
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
        } while (playAgain == "yes");

        Console.WriteLine("Thank you for playing!");
    }
}