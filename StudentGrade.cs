using System;
using System.Linq;

public class StudentGrade
{
    public string Name { get; set; }
    public int[] Grades { get; set; }

    public StudentGrade(string name, int[] grades)
    {
        Name = name;
        Grades = grades;
    }

    public double GetMaxGrade()
    {
        return Grades.Max();
    }

    public double GetAverageGrade()
    {
        return Grades.Average();
    }
}
