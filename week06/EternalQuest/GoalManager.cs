namespace EternalQuest;
public class GoalManager
{
    private readonly List<Goal> _goals = new List<Goal>();
    private int _score = 0;
   public static void Start()
    {
        bool running = true;
        while(running)
        {
            DisplayUserInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            switch (Console.ReadLine())
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                   running = false;
                   break;
                   default:
                   Console.WriteLine("Please enter a number from 1 to 6");
                   break;
            }

            
        }
    }

        public void DisplayUserInfo()
        {
            int level = (_score /500) +1;
            Console.WriteLine($"\n===Eternal Quest===");
            Console.WriteLine($"Score: {_score} points | Level: {level}");
            Console.WriteLine($"Next Level: {level * 500} points");

    }

    public void CreateNewGoal()
    {
        Console.WriteLine("\n Goal Type:");
        Console.WriteLine("1. Simple Goal (complete once)");
        Console.WriteLine("2. Eternal Goal (complete multiple times)");
        Console.WriteLine("3. Checklist Goal (complete a target number of times)");
        Console.Write("Choose a goal type: ");
        string goalType = Console.ReadLine();

        string name = ReadRequiredText("Goal Name: ");
        string description =ReadRequiredText("Goal Description: ");
        int points =ReadInt("Goal Points:" 0);

        switch (goalType) 
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                int target = ReadInt("Target Amount: ", 1);
                int bonus = ReadInt("Bonus Points: ", 0);
                _goals.Add(new CheckListGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal not created.");
                return;
        }
            Console.WriteLine("Goal created!");
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals created yet.");
            return;
        }

        Console.WriteLine("\n Your goals:");
        for (int i = 0; i < _goals.Count; i ++);
        Console.WriteLine($"{int + 1}. {_goals[i].GetDetailsString");
    
    }

    public void RecordEvent()
    {
        
        
    }
    
    
}