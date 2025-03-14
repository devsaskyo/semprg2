using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Predicate<int> isEven = IsEven;
            List<int> evenNumbers = numbers.FindAll(isEven);
            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
        }
    }
}
