using System;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("WELCOME TO THE RESUME PROGRAM\n");

        // Create a new Job object
        Job job1 = new Job();
        // Set the properties of the Job object
        job1._companyName = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2019";
        job1._endYear = "2021";
        

        // Create another Job object
        Job job2 = new Job();
        // Set the properties of the second Job object
        job2._companyName = "Apple";
        job2._jobTitle = "Machine Learning Engineer";
        job2._startYear = "2021";
        job2._endYear = "2024";

        // Create another Job object
        Job job3 = new Job();
        // Set the properties of the third Job object
        job3._companyName = "Google";
        job3._jobTitle = "Data Scientist";
        job3._startYear = "2024";
        job3._endYear = "Present";

       

        // Create a new Resume object
        Resume resume = new Resume();
        // Set the name of the resume
        resume._name = "Felix Wilson Gbedemah";
        // Add the jobs to the resume
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._jobs.Add(job3);

        // Display the resume
        resume.DisplayResume();


    }
}