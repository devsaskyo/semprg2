using System;
using System.Collections.Generic;

class Program
{
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Predicate<int> isEven = IsEven;
        List<int> evenNumbers = numbers.FindAll(isEven);
        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
    }
}
