using System;

class Program
{
    static void Main()
    {
        Person[] people = new Person[]
        { 
            new Person("Іван", "Петров", 25),
            new Person("Марія", "Іванова", 30),
            new Person("Петро", "Сидоров", 20),
            new Person("Анна", "Коваленко", 35)
        };

        Person personWithMinAge = people.FindPersonWithMinAge();
        Person personWithMaxAge = people.FindPersonWithMaxAge();
        double averageAge = people.CalculateAverageAge();

        Console.WriteLine($"Особа з мінімальним віком: {personWithMinAge.FirstName} {personWithMinAge.LastName}, {personWithMinAge.Age} років");
        Console.WriteLine($"Особа з максимальним віком: {personWithMaxAge.FirstName} {personWithMaxAge.LastName}, {personWithMaxAge.Age} років");
        Console.WriteLine($"Середній вік осіб: {averageAge:F2} років");
    }
}
