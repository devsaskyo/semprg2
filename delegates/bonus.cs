using System;

namespace DelegatesExample
{
    class Program
    {
        delegate int MathOperation(int a, int b);
        delegate void ActionWithString(string message);
        delegate bool PredicateWithInt(int number);

        static void Main(string[] args)
        {
            MathOperation addOperation = (a, b) => a + b;
            ActionWithString printResult = (message) => Console.WriteLine(message);
            PredicateWithInt isEven = (number) => number % 2 == 0;
            int result = addOperation(5, 3);
            printResult($"Output: {result}");
            string isEvenResult = isEven(result) ? "Yes" : "No";
            printResult($"Output: {isEvenResult}");
        }
    }
}
