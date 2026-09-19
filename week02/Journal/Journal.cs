using System.Security.Cryptography.X509Certificates;

class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    private FileManager fileManager = new FileManager();

    private string[] prompts =
    {
        "What experience made you smile today?",
        "What was something new you learned today?",
        "What is a mistake you made today that you learned from?",
        "What is something you are grateful for today?",
        "Who is someone you love and why?"
    };

    public void WriteEntry()
    { //Writes an entry
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.Write("Response: ");
        
        string response = Console.ReadLine();

        JournalEntry entry = new JournalEntry( 
            DateTime.Now.ToString("MM/dd/yyyy"),
             prompt,
             response
        );

        entries.Add(entry);
    }
    public void DisplayEntry()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("There are no journal entries");
            return;
        }
        foreach (JournalEntry entry in entries)
        {
            Console.WriteLine();
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
        }
    }

    public void SaveEntry()
    {
        //Saves an entry
        fileManager.Save(entries);
        Console.WriteLine("SaveJournal");
    }

    public void LoadEntry()
    {
        //Loads an entry
        entries = fileManager.Load();
        Console.WriteLine("JournalLoaded");
    }


}