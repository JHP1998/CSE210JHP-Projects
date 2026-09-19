using System;
using System.Collections;
class JournalProgram
{
    static void Main()
    {
        Journal journal = new Journal();
        while(true)
        {
            DisplayMenu();

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    journal.WriteEntry();
                    break;
                case "2":
                    Console.WriteLine("2");
                    journal.DisplayEntry();
                    break;
                case "3":
                    journal.SaveEntry();
                    break;
                case "4":
                    journal.LoadEntry();
                    break;
                case "5":
                    Console.WriteLine("Thanks for writing");
                    return;
                default:
                    Console.WriteLine("Please enter # 1-5");
                    break;
            }
        }

    }

    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Journal Menu! Please select an option:");
        Console.WriteLine("1. Write a new journal entry");
        Console.WriteLine("2. Display Journal entries");
        Console.WriteLine("3. Save Journal entries to a file");
        Console.WriteLine("4. Load Journal from a file");
    }
}