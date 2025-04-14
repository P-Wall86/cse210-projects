public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * 50) / 1000.0;

    public override double GetSpeed() => GetDistance() / (GetDuration() / 60.0);

    public override double GetPace() => GetDuration() / GetDistance();
}
