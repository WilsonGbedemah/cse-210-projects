using System;

public class Cycling : Activity
{
    private double _speed; // in kph

    public Cycling(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetSpeed() => _speed;

    public override double GetDistance()
    {
        return (_speed * GetLengthInMinutes()) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}
