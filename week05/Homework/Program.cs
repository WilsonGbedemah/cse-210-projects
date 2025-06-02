using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment
        Assignment assignment = new Assignment("Felix Wilson Gbedemah", "Multiplication");
        Console.WriteLine(assignment.GetSummary() + '\n');s

        // MathAssignment
        MathAssignment mathAssignment = new MathAssignment("King Pharaoh", "Angles", "Section 2.3", "Problems 4-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList() + '\n');

        // WritingAssignment
        WritingAssignment writingAssignment = new WritingAssignment("Belinda Bankam", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation() + '\n');
    }
}