using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment
        Assignment assignment = new Assignment("Felix Wilson Gbedemah", "Number Bases");
        Console.WriteLine(assignment.GetSummary() + '\n');

        // MathAssignment
        MathAssignment mathAssignment = new MathAssignment("King Pharaoh", "Angles", "Section 2.3", "Problems 1-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList() + '\n');

        // WritingAssignment
        WritingAssignment writingAssignment = new WritingAssignment("Belinda Bankam", "Formal Letters", "Application letter for a job as a Software Engineer");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation() + '\n');
    }
}