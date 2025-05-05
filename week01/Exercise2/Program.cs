using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input your grade score: ");
        string input = Console.ReadLine();
        int score = int.Parse(input);

        string letter = "";

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80 && score < 90)
        {
            letter = "B";
        }
        else if (score >= 70 && score < 80)
        {
            letter = "C";
        }
        else if (score >= 60 && score < 70)
        {
            letter = "D";
        }
        else if (score >= 0 && score < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Invalid score. Please enter a number between 0 and 100.");
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (score >= 70)
        {
            Console.WriteLine("You passed the course.");
        }
        else
        {
            Console.WriteLine("You failed the course. Better luck next time!");
        }
    }
}   