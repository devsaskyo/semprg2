using System;
using System.Collections.Generic;

namespace stackingIGuess
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Zadejte výraz:");
            string input = Console.ReadLine();

            if (checkBrackets(input))
            {
                Console.WriteLine("Správně uzavřené závorky.");
            }
            else
            {
                Console.WriteLine("Špatně uzavřené závorky.");
            }
        }

        static bool checkBrackets(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in input)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
