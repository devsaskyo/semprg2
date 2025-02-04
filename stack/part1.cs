using System;
using System.Collections.Generic;

namespace stackingIGuess
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Zadejte text:");
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (char c in input)
            {
                stack.Push(c);
            }
            string reversed = "";
            while (stack.Count > 0)
            {
                reversed += stack.Pop();
            }
            Console.WriteLine("Obrácený text:");
            Console.WriteLine(reversed);
        }
    }
}
