using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("WELCOME TO YOUR FRIENDLY JOURNAL\n");

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
            Console.WriteLine("5. Search entries");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice (1-6): ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");

                Console.WriteLine("How are you feeling today?");
                Console.WriteLine("1. Happy");
                Console.WriteLine("2. Okay");
                Console.WriteLine("3. Sad");
                Console.WriteLine("4. Angry");
                Console.WriteLine("5. Tired");
                Console.WriteLine("6. Grateful");
                Console.Write("Choose a mood (1–6): ");
                string moodChoice = Console.ReadLine();

                string mood = moodChoice switch
                {
                    "1" => "Happy",
                    "2" => "Okay",
                    "3" => "Sad",
                    "4" => "Angry",
                    "5" => "Tired",
                    "6" => "Grateful",
                    _ => "Unspecified"
                };

                Console.Write("Your response: ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();
                myJournal.AddEntry(date, mood, prompt, response);
                Console.WriteLine("Entry added successfully!\n");
            }
            else if (choice == "2")
            {
                Console.WriteLine("All Journal Entries:\n");
                myJournal.DisplayAll();

            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to save to (e.g., journal.txt): ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
                Console.WriteLine();
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to load from (e.g., journal.txt): ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
                Console.WriteLine();
            }
            else if (choice == "5")
            {
                Console.Write("Enter a date (e.g., 5/16/2025) or mood to search: ");
                string keyword = Console.ReadLine();
                myJournal.SearchEntries(keyword);
                Console.WriteLine();
            }
            else if (choice == "6")
            {
                running = false;
                Console.WriteLine("Goodbye! Keep writing and stay positive.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.\n");
            }
        }
    }
}
