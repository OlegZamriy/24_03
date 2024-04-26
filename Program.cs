using System;

class Program
{
    static void Main()
    {
        IntExtensions.NumberChecked += NumberCheckedHandler;

        int numberToCheck = 17;

        if (numberToCheck.IsPrime())
        {
            Console.WriteLine($"{numberToCheck} є простим числом.");
        }
        else
        {
            Console.WriteLine($"{numberToCheck} не є простим числом.");
        }
    }

    static void NumberCheckedHandler(object sender, int number)
    {
        Console.WriteLine($"Подія: перевірка числа {number} на простоту.");
    }
}
