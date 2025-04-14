public class Running : Activity
{
    private double _distance;

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => _distance / (GetDuration() / 60.0);

    public override double GetPace() => GetDuration() / _distance;
}