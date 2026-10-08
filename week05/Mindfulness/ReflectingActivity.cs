class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        
    };
    
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn from this experience?",
        "How did you feel when this happened?",
        "What did you learn about yourself?",
        "How did this experience help you grow?"
    };
    private Random _random = new Random();

    public ReflectingActivity() : base(
        "Reflecting Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience."
    )
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine($"Consider the following prompt:");

        DisplayPrompt();
        Console.WriteLine("Press enter");

        Console.ReadLine();
        Console.WriteLine($"Now ponder on each of the following questions as they relate to this experience.");

        CountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while(DateTime.Now < endTime)
        {

            DisplayQuestions();
            Spinner(5);
            Console.WriteLine();

        }
        Console.WriteLine($"Well Done!");
        Console.WriteLine($" You have done {Duration} seconds of the reflecting activity");
        Pause(3);

        
        
    }
    public void GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
     
    }
    public void GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        Console.WriteLine(_questions[index]);
    }
    public void DisplayPrompt()
    {
        GetRandomPrompt();
        
    }
    public void DisplayQuestions()
    {
        GetRandomQuestion();
    }
}