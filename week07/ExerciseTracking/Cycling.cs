public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetSpeed() => _speed;

    public override double GetDistance() => _speed * (GetDuration() / 60.0);

    public override double GetPace() => 60.0 / _speed;
}