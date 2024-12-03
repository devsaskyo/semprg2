using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExistsApparently
{
    class Program
    {
        static void Main()
        {
            List<string> slova = new List<string> { "jablko", "banán", "kiwi", "pomeranč", "hruška" };

            var sortedSlova = slova.OrderBy(s => s.Length);

            foreach (var slovo in sortedSlova)
            {
                Console.WriteLine(slovo);
            }
        }
    }

}
