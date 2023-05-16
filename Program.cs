using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Введіть перше слово: ");
        string word1 = Console.ReadLine();

        Console.Write("Введіть друге слово: ");
        string word2 = Console.ReadLine();

        StringBuilder result = new StringBuilder();

        foreach (char letter in word1)
        {
            if (word2.Contains(letter))
            {
                result.Append(letter);
            }
        }

        Console.WriteLine("Літери, які є в обох словах: " + result);
        Console.ReadKey();
    }
}
