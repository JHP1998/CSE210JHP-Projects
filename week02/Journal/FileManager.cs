class FileManager
{
    private const string FileName = "Journal.txt";

    public void Save(List<JournalEntry>entries)
    {
        // Save entries
        using StreamWriter writer = new StreamWriter(FileName);
         foreach (JournalEntry entry in entries)
        {
            writer.WriteLine(entry.Date);
            writer.WriteLine(entry.Prompt);
            writer.WriteLine(entry.Response);
            writer.WriteLine("---");
        }
            writer.Close(); 
    }

    public List<JournalEntry> Load()

    {
        //Load entries
        List<JournalEntry>entries = new List<JournalEntry>();

        if(!File.Exists(FileName))
        {
            return entries;
        }

        string[] lines = File.ReadAllLines(FileName);

        for (int i = 0; i + 2 < lines.Length; i += 4)
        {
            entries.Add(
                new JournalEntry(
                 lines[i],
                 lines[i + 1], 
                 lines[i + 2]
                )
            );
        }

        return entries;
    }
}