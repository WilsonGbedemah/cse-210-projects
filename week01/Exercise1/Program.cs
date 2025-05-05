using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ")
        string firstName = Console.ReadLine();
        
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.Writeline($"Your name is {lastName}, {firstName} {lastName}.");

    }
}