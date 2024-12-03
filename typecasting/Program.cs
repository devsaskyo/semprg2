using System;

namespace TypeCastingApparently
{
    class Program
    {
        static void Main()
        {
            double doubleValue = 5.75;

            int intValue = (int)doubleValue;
            Console.WriteLine($"Explicit casting (double to int): {intValue}");

            float floatValue = intValue;
            Console.WriteLine($"Implicit casting (int to float): {floatValue}");

            object obj = 5.75;

            if (obj is double)
            {
                Console.WriteLine("Object is type double.");
            }

            double? convertedValue = obj as double?;
            if (convertedValue.HasValue)
            {
                Console.WriteLine($"Type casting 'as': {convertedValue.Value}");
            }
            else
            {
                Console.WriteLine("Type casting with 'as' was unsuccessful.");
            }
        }
    }

}
