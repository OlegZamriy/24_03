using System;

public static class IntExtensions
{
    public static event EventHandler<int> NumberChecked;

    public static bool IsPrime(this int number)
    {
        bool isPrime = true;
        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        NumberChecked?.Invoke(null, number);  
        return isPrime;
    }
}
