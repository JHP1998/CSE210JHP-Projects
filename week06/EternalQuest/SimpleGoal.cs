public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points, bool isComplete = false) : base(name, description, points)
    {
        _isComplete = isComplete;

        public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return isComplete() ? int.Parse(_points) : 0;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetails()
    {
      return IsComplete() ? "[X]" : "[ ]" + $" {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}
    
