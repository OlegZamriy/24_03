using System;
using System.Linq;

class Program
{
    static void Main()
    {
        DayTemperature[] temperatures = new DayTemperature[]
        {
            new DayTemperature(1, 30, 15),
            new DayTemperature(2, 25, 10),
            new DayTemperature(3, 35, 20),
            new DayTemperature(4, 20, 5),
            new DayTemperature(5, 28, 12)
        };

        var daysWithMaxDifference = temperatures
            .Select(temp => new { Day = temp.Day, Difference = temp.MaxTemperature - temp.MinTemperature })
            .OrderByDescending(d => d.Difference)
            .First();

        Console.WriteLine($"День з максимальною різницею температур: {daysWithMaxDifference.Day}");
        Console.WriteLine($"Різниця між найвищою та найнижчою температурою: {daysWithMaxDifference.Difference} градусів");
    }
}
