using System;

public static class FibonacciExtension
{
    public static bool IsFibonacci(this int number)
    {
        if (number == 0 || number == 1)
        {
            return true;
        }

        int a = 0;
        int b = 1;
        while (b <= number)
        {
            if (b == number)
            {
                return true;
            }
            int temp = a;
            a = b;
            b = temp + b;
        }

        return false;
    }
}

