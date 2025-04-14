using System.Globalization;
public abstract class Activity
{
    private string _date;
    private int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public string GetDate() => _date;
    public int GetDuration() => _duration;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        DateTime parsedDate = DateTime.Parse(_date);
        string formattedDate = parsedDate.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);

        return string.Format(CultureInfo.InvariantCulture,
            "{0} {1} ({2} min): Distance {3:0.0} km, Speed: {4:0.0} kph, Pace: {5:0.00} min per km",
            formattedDate, this.GetType().Name, _duration, GetDistance(), GetSpeed(), GetPace());
    }
}
