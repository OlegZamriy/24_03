using System;

class Program
{
    static void Main()
    {
        StringExtensions.VowelCounted += VowelCountedHandler;

        string text = "Це є приклад рядка для підрахунку голосних літер.";

        int vowelCount = text.CountVowels();
        Console.WriteLine($"Кількість голосних літер у рядку: {vowelCount}");
    }

    static void VowelCountedHandler(object sender, int count)
    {
        Console.WriteLine($"Подія: підрахунок голосних літер у рядку - {count}");
    }
}
