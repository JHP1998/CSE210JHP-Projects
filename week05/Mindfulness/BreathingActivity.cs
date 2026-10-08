using System.Security.Cryptography.X509Certificates;

class BreathingActivity: Activity
{
    public BreathingActivity() 
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through " +
            "breathing in and out sowly. Clear your mind and focus on breathing."
        )
    {
        
    }
    
    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while(DateTime.Now < endTime)
        {
            Console.WriteLine($"Breath In...");
            CountDown(4);

            if (DateTime.Now >= endTime)
            {
                break;
            }
            Console.WriteLine($"Breath out...");
            CountDown(4);
            

            
        }
        Console.WriteLine($"Well Done!");

            Console.WriteLine($" You have done {Duration} seconds of the breathing activity");

            Pause(3);

    }
}