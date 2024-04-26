using System;

class Program
{
    static void Main()
    {
        StudentGrade[] students = new StudentGrade[]
        {
            new StudentGrade("Іван", new int[] { 85, 90, 92 }),
            new StudentGrade("Марія", new int[] { 78, 85, 80 }),
            new StudentGrade("Петро", new int[] { 92, 95, 88 })
        };

        var studentWithMaxGrade = students.OrderByDescending(s => s.GetMaxGrade()).First();
        var studentWithAvgGrade = students.OrderByDescending(s => s.GetAverageGrade()).First();

        Console.WriteLine($"Студент з максимальною оцінкою: {studentWithMaxGrade.Name} ({studentWithMaxGrade.GetMaxGrade()})");
        Console.WriteLine($"Студент з середньою оцінкою: {studentWithAvgGrade.Name} ({studentWithAvgGrade.GetAverageGrade()})");
    }
}
