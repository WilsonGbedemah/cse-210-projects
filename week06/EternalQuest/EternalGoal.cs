public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Points added externally in GoalManager
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return $"[∞] {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }
}
