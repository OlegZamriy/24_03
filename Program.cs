using System;

class Program
{
    static void Main()
    {
        Fraction[] fractions = new Fraction[]
        {
            new Fraction(1, 2),
            new Fraction(3, 4),
            new Fraction(5, 6),
            new Fraction(7, 8),
            new Fraction(2, 3)
        };

        fractions.FindMinMaxFractions(out Fraction minFraction, out Fraction maxFraction);

        Console.WriteLine($"Мінімальний дріб: {minFraction.Numerator}/{minFraction.Denominator}");
        Console.WriteLine($"Максимальний дріб: {maxFraction.Numerator}/{maxFraction.Denominator}");

        FractionExtensions.MinMaxFractionFound += MinMaxFractionFoundHandler;
    }

    static void MinMaxFractionFoundHandler(object sender, Tuple<Fraction, Fraction> result)
    {
        Console.WriteLine($"Подія: Мінімальний дріб - {result.Item1.Numerator}/{result.Item1.Denominator}, Максимальний дріб - {result.Item2.Numerator}/{result.Item2.Denominator}");
    }
}
