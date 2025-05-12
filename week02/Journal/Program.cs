using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME TO YOUR JOURNAL\n");

        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to file");
            Console.WriteLine("4. Load entries from file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice (1-5): ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();
                Entry newEntry = new Entry(date, prompt, response);
                myJournal.AddEntry(newEntry);
                Console.WriteLine("Entry added successfully!");
            }
            else if (choice == "2")
            {
                Console.WriteLine("All Journal Entries:\n");
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to save to: ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
                Console.WriteLine("Entries saved successfully!");
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to load from: ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
                Console.WriteLine("Entries loaded successfully!");
            }
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("Exiting the program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine();
        }
       
    }
}