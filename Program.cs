using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int[] evenNumbers = numbers.FilterArray(x => x % 2 == 0);

        int[] oddNumbers = numbers.FilterArray(x => x % 2 != 0);

        Console.WriteLine("Парні числа:");
        foreach (var number in evenNumbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\nНепарні числа:");
        foreach (var number in oddNumbers)
        {
            Console.Write(number + " ");
        }
    }
}
