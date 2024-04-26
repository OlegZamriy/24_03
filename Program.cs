using System;

class Program
{
    static void Main()
    {
        StringExtensions.SentenceCounted += SentenceCountedHandler;

        string text = "Це є приклад рядка з двома реченнями. Це друге речення!";

        int sentenceCount = text.CountSentences();
        Console.WriteLine($"Кількість речень у рядку: {sentenceCount}");
    }

    static void SentenceCountedHandler(object sender, int count)
    {
        Console.WriteLine($"Подія: підрахунок речень у рядку - {count}");
    }
}
