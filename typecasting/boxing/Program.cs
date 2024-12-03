using System;

namespace TypeCastingApparently
{
    class Program
    {
        static void Main()
        {
            int number = 456;

            object boxedNumber = number;

            int unboxedNumber = (int)boxedNumber;

            if (unboxedNumber == number)
            {
                Console.WriteLine("Unboxing successful. Value: " + unboxedNumber);
            }
            else
            {
                Console.WriteLine("Unboxing failed.");
            }
        }
    }
}
