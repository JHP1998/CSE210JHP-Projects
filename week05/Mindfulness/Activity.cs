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
        Console.Clear();

       Console.WriteLine($" Starting {_name }.");
        
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long in seconds would you like your session? ");
        int duration;
        while( !int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.WriteLine($"Please enter a positive number of seconds");
        }
        _duration = duration;

        Console.WriteLine($" Get ready for the activity");
        Pause(3);
    }
    protected void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);

            Thread.Sleep(1000);
        }
        Console.Write("\r \r");

    }
    protected void Spinner(int seconds)
    {
        char[] spinner = {'|', '/', '-', '\\'};
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int spinnerIndex = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[spinnerIndex]);
            spinnerIndex ++;
            if (spinnerIndex >= spinner.Length)
            {
                spinnerIndex = 0;
            }
            Thread.Sleep(250);
            
        }
        Console.Write("\r \r");
        
    }
    public static void Pause(int seconds)
    {
        char[] spinner = {'|', '/', '-', '\\'};
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int spinnerIndex = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[spinnerIndex]);
            spinnerIndex ++;
            if (spinnerIndex >= spinner.Length)
            {
                spinnerIndex = 0;
            }
            Thread.Sleep(250);
        }
        Console.Write("\r \r");
    }
}