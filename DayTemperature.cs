public class DayTemperature
{
    public int Day { get; set; }
    public int MaxTemperature { get; set; }
    public int MinTemperature { get; set; }

    public DayTemperature(int day, int maxTemperature, int minTemperature)
    {
        Day = day;
        MaxTemperature = maxTemperature;
        MinTemperature = minTemperature;
    }
}
