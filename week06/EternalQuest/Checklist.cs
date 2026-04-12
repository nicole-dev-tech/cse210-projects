class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int currentCount = 0, int bonus = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        if (_currentCount == _targetCount)
        {
            return Points + _bonus;
        }
        return Points;
    }

    public override string GetStatus()
    {
        return _currentCount >= _targetCount ? $"[X] Completed {_currentCount}/{_targetCount}" : $"[ ] Completed {_currentCount}/{_targetCount}";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{_targetCount}|{_currentCount}|{_bonus}";
    }
}