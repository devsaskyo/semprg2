using System;
using System.Collections.Generic;

namespace DoingQueueApparently
{
    class Program
    {
        static void Main()
        {
            Console.Write("Zadejte slovo: ");
            string input = Console.ReadLine();
            Queue<char> queue = new Queue<char>();
            foreach (char character in input)
            {
                queue.Enqueue(character);
            }
            bool isAPalindrom = true;
            int i = 0;
            int j = input.Length - 1;
            while (i < j)
            {
                if (queue.Dequeue() != input[j])
                {
                    isAPalindrom = false;
                    break;
                }
                j--;
                i++;
            }
            if (isAPalindrom)
            {
                Console.WriteLine($"Slovo \"{input}\" je palindrom.");
            }
            else
            {
                Console.WriteLine($" Slovo \"{input}\" není palindrom.");
            }
        }
    }
}
