using System;

class Program
{
    static void Main(string[] args)
    {
        // Display a welcome message
        DisplayWelcome();

        // Prompt the user for their name
        string userName = PromptUserName();

        // Prompt the user for their favorite number
        int userNumber = PromptUserNumber();

        // Square the number
        int squaredNumber = SquareNumber(userNumber);

        // Display the result
        DisplayResult(userName, userNumber, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userResponse = Console.ReadLine();
        int userNumber = int.Parse(userResponse);
        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        return userNumber * userNumber;
    }

    static void DisplayResult(string userName, int userNumber, int squaredNumber)
    {
        Console.WriteLine($"{userName}, your favorite number is {userNumber} and its square is {squaredNumber}.");
    }
}