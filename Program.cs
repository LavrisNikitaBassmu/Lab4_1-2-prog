using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение, завершающееся точкой:");
        string input = Console.ReadLine();

        // Убираем точку в конце для удобства обработки
        if (input.EndsWith("."))
        {
            input = input.TrimEnd('.');
        }

        Dictionary<char, int> counts = new Dictionary<char, int>();

        // Подсчет символов
        foreach (char c in input)
        {
            if (counts.ContainsKey(c))
            {
                counts[c]++;
            }
            else
            {
                counts[c] = 1;
            }
        }

        Console.WriteLine("Символы, которые встречаются ровно один раз:");
        foreach (var pair in counts)
        {
            if (pair.Value == 1)
            {
                Console.Write(pair.Key + " ");
            }
        }
    }
}