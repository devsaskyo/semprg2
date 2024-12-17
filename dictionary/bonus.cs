using System;

namespace DictionariesIGuess
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            var wordFrequency = SumWordFrequency(text);
            foreach (var word in wordFrequency)
            {
                Console.Write($"{word.Key} {word.Value} ");
            }
        }

        static Dictionary<string, int> SumWordFrequency(string text)
        {
            var frequency = new Dictionary<string, int>();
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                if (frequency.ContainsKey(word))
                {
                    frequency[word]++;
                }
                else
                {
                    frequency[word] = 1;
                }
            }

            return frequency;
        }
    }
}
