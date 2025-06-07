using System;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> activityLog = new Dictionary<string, int>()
        {
            { "Breathing", 0 },
            { "Listing", 0 },
            { "Reflection", 0 },
            { "Gratitude", 0 },
            { "Positive Affirmation", 0 }
        };

        Console.Clear();
        Console.WriteLine("Welcome to the Mindful Moments");
        Console.WriteLine("================================");
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("Mindful Moments Menu");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Listing Activity");
            Console.WriteLine("3. Start Reflection Activity");
            Console.WriteLine("4. Start Gratitude Activity");
            Console.WriteLine("5. Start Positive Affirmation Activity");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity ba = new BreathingActivity();
                ba.Run();
                activityLog["Breathing"]++;
            }
            else if (choice == "2")
            {
                ListingActivity la = new ListingActivity();
                la.Run();
                activityLog["Listing"]++;
            }
            else if (choice == "3")
            {
                ReflectingActivity ra = new ReflectingActivity();
                ra.Run();
                activityLog["Reflection"]++;
            }
            else if (choice == "4")
            {
                GratitudeActivity ga = new GratitudeActivity();
                ga.Run();
                activityLog["Gratitude"]++;
            }
            else if (choice == "5")
            {
                PositiveAffirmationsActivity paa = new PositiveAffirmationsActivity();
                paa.Run();
                activityLog["Positive Affirmation"]++;
            }
            else if (choice == "6")
            {
                Console.WriteLine("\nActivity Log Summary:");
                foreach (var entry in activityLog)
                {
                    Console.WriteLine($"- {entry.Key} performed {entry.Value} time(s)");
                }
                Console.WriteLine("\nThank you for using Mindful Moments. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to continue.");
                Console.ReadLine();
            }
        }
    }
}
