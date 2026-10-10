namespace EternalQuest;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points, int timesRecorded = 0) : base(name, description, points)
    {
        private int _timesRecorded = timesRecorded;

        public override int RecordEvent()
        {
            _timesRecorded++;
            return int.Parse(_points);
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetDetailsString()
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed: {_timesRecorded} times";
        }

        public override string GetStringRepresentation()
        {
        return $"EternalGoal|{_shortName}|{_description}|{_points}|{_timesRecorded}";
        }
        
    }

    }
    
}