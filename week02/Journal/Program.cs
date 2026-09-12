using System;

class Program
{
    static void Main(string[] args)
    {

    //Create list of prompts
    List<string> prompts = new List<string>();
    prompts.Add("What experience made you smile today?");
    prompts.Add("What was something new you learned today?");
    prompts.Add("What is a mistake you made today that you learned from?");
    prompts.Add("What is something you are grateful for today?");
    prompts.Add("Who is someone you love and why?");

    if (prompts.Count > 0)
        {
            int index =Random.Shared.Next(prompts.Count);
            
            Console.WriteLine(prompts[index]);       }

    {
        // Create Journal Menu
        Console.WriteLine("Welcome to the Journal Menu! Please select an option:");
        Console.WriteLine("1. Write a new journal entry");
        Console.WriteLine("2. Display Journal entries");
        Console.WriteLine("3. Save Journal entries to a file");
        Console.WriteLine("4. Load Journal from a file");
        

        // Get user input
        string userInput = Console.ReadLine();

        // Create a new Journal entry
        if (userInput == "1")
        {
            JournalEntry newEntry = new JournalEntry();
            newEntry._date = DateTime.Now.ToString("MM/dd/yyyy");
            Console.WriteLine(newEntry._prompt);
            newEntry._response = Console.ReadLine();
            

        }
        else if (userInput == "2")
            {
                Journal journal = new Journal();
                journal.DisplayEntries();

        }
        else if (userInput == "3")
            {
                Journal journal = new Journal();
                journal.SaveToFile();

        }
        else if (userInput == "4")
        {
                    Journal journal = new Journal();
                    journal.LoadFromFile();
                }
            }
            }
            }
        }
    }
}