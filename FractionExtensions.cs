using System;

public static class FractionExtensions
{
    public static event EventHandler<Tuple<Fraction, Fraction>> MinMaxFractionFound;

    public static void FindMinMaxFractions(this Fraction[] fractions, out Fraction minFraction, out Fraction maxFraction)
    {
        if (fractions == null || fractions.Length == 0)
        {
            minFraction = null;
            maxFraction = null;
            return;
        }

        minFraction = fractions[0];
        maxFraction = fractions[0];

        for (int i = 1; i < fractions.Length; i++)
        {
            if ((double)fractions[i].Numerator / fractions[i].Denominator < (double)minFraction.Numerator / minFraction.Denominator)
            {
                minFraction = fractions[i];
            }

            if ((double)fractions[i].Numerator / fractions[i].Denominator > (double)maxFraction.Numerator / maxFraction.Denominator)
            {
                maxFraction = fractions[i];
            }
        }

        MinMaxFractionFound?.Invoke(null, new Tuple<Fraction, Fraction>(minFraction, maxFraction));
    }
}
