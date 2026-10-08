class ListingActivity : Activity
{
    private int _promptCount = 0;
    private List<string> _promptList = new List<string>
    {
        "Think about a challenge you overcame recently",
        "Think of a place that helps you find peace",
        "Think about something that makes you happy",
        "Think about someone who makes you smile",
        "Think about something you can work on to improve",
        "Think about something you are grateful for"

    };
    private Random _random = new Random();

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you focus on your surroundings/evironment."
    )
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine($"Get ready to write lists..");

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        _promptCount = 0;

        while(DateTime.Now < endTime)
        {
            Console.WriteLine($"Start writing lists..");

            GetRandomPrompt();

            Console.WriteLine($" Carefully think about the prompt..");

            Spinner(5);

            _promptCount ++;

            
        }
        Console.WriteLine();
            Console.WriteLine($"You pondered {_promptCount} prompts");
            Console.WriteLine($" You have done {Duration} seconds of the listing activity");

            Pause(3);

    }
    public void GetRandomPrompt()
    {
        int index = _random.Next(_promptList.Count);
        
        Console.WriteLine($"Prompt: {_promptList[index]}");

        
    }
}
    