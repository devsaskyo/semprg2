using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExistsApparently
{
    class Program
    {
        static void Main()
        {
            List<int> cisla = new List<int> { 5, 15, 8, 22, 1, 11 };

            var vysledek = cisla.Where(c => c > 10);

            foreach (var cislo in vysledek)
            {
                Console.WriteLine(cislo);
            }
        }
    }

}
