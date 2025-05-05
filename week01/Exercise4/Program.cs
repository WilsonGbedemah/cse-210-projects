using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {

            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            // Add number to the list if it not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }

        // Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is : {sum}");

        // Compute the average

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        // Find the maximum number

        int max = numbers.Max();

        Console.WriteLine($"The maximum number is: {max}");




    }
}