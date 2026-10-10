namespace EternalQuest;
public class CheckListGoal : Goal
{
   private int _amountCompleted;
   private int _target;
   private int _bonus;

   public CheckListGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
   {
       _amountCompleted = 0;
       _target = target;
       _bonus = bonus;

       if (amountCompleted<= target)
       {
           _amountCompleted++;
           return int.Parse(_points);
       }
       else if (amountCompleted == target)
       {
           _amountCompleted++;
           return int.Parse(_points) + _bonus;
       }
       else
       {
           return 0;
       }

       public override int RecordEvent()
       {
           if (_amountCompleted < _target)
           {
               _amountCompleted++;
               return int.Parse(_points);
           }
           else if (_amountCompleted == _target)
           {
               _amountCompleted++;
               return int.Parse(_points) + _bonus;
           }
           else
           {
               return 0;
           }
       }

       public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return IsComplete() ? "[X]" : "[ ]" + $" {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
   }
}