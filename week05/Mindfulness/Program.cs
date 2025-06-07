using System;

class Program
{
    static void Main(string[] args)
    {
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
            Console.WriteLine("5. Start Goal Setting Activity");
            Console.WriteLine("6. Start Positive Affirmation Activity");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity ba = new BreathingActivity();
                ba.Run();
            }
            else if (choice == "2")
            {
                ListingActivity la = new ListingActivity();
                la.Run();
            }
            else if (choice == "3")
            {
                ReflectingActivity ra = new ReflectingActivity();
                ra.Run();
            }
            else if (choice == "4")
            {
                GratitudeActivity ga = new GratitudeActivity();
                ga.Run();
            }
            else if (choice == "5")
            {
                GoalSettingActivity gsa = new GoalSettingActivity();
                gsa.Run();
            }
            else if (choice == "6")
            {
                PositiveAffirmationsActivity paa = new PositiveAffirmationsActivity();
                paa.Run();
            }
            else if (choice == "7")
            {
                Console.WriteLine("Thank you for using the Mindful Moments. Goodbye!");
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
