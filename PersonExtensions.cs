using System;
using System.Linq;

public static class PersonExtensions
{
    public static event EventHandler<double> AverageAgeCalculated;

    public static double CalculateAverageAge(this Person[] people)
    {
        double averageAge = people.Average(p => p.Age);
        AverageAgeCalculated?.Invoke(null, averageAge);  
        return averageAge;
    }

    public static Person FindPersonWithMinAge(this Person[] people)
    {
        return people.OrderBy(p => p.Age).FirstOrDefault();
    }

    public static Person FindPersonWithMaxAge(this Person[] people)
    {
        return people.OrderByDescending(p => p.Age).FirstOrDefault();
    }
}
