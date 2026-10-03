class Activity
{
        private static string _name;
        private static string _description;
        private static int _duration;
    public Activity()
    {
        _name =" ";
        _description =" ";
        _duration = 0;
        
    }



    public Activity(string name, string description)
    {
        string _name = name;
        string _description = description;
        int _duration = 0;


    }
    protected string Name
    {
        get { return _name; }
    }

    protected string Description
    {
        get { return _description; }
    }

    protected int Duration
    {
        get { return _duration; }
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    
    }
    protected void DisplayStartingMessage()
    {
        
    }
    protected void CountDown(int seconds)
    {
        Console.Clear()

        Console.WriteLine($" Starting {_name }.");
        
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long in seconds would you like your session? ");

        int duration;
        while (not int.TryParse(Console.ReadLine, out duration) || duration <= 0)
        {
                Console.WriteLine("Please enter a positive number of seconds. ");
        }
        _duration = duration;

        Console.WriteLine();

        Console.WriteLine("Get Ready...");

        Pause(3);
    }
    protected void Spinner(int seconds)
    {
        
    }
    public static void Pause(int seconds)
    {
        
    }
}