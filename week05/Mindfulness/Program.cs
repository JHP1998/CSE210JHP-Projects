using System;

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine($"Welcome to the Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine($"Menu Options :");
            Console.WriteLine($" 1. Start Breathing Activity ");
            Console.WriteLine($" 2. Start Reflecting Activity ");
            Console.WriteLine($" 3. Start Listing Activity ");
            Console.WriteLine($" 4. View Activity Statistics ");
            Console.WriteLine($" 5. Quit ");
            Console.WriteLine();
            Console.WriteLine($" Select a choice from the Menu ");

            string choice = Console.ReadLine();
            Console.Clear();
            
            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    breathingCount++;

                    break;

                case "2":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    listingCount++;
                    break;

                case "3":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    reflectingCount++;
                    

                    break;

                case "4":
                    Console.WriteLine($"Breathing Activity Count : {breathingCount}");
                    Console.WriteLine($"Listing Activity Count : {listingCount}");
                    Console.WriteLine($"Reflecting Activity Count : {reflectingCount}"); 
                    Console.WriteLine();
                    Console.WriteLine($"Press enter to return to the menu");
                    Console.ReadLine();
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine($" Invalid choice, please select from Menu ");
                    Activity.Pause(2);

                    break;
            }
        }
    }
}