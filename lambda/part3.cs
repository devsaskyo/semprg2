using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExistsApparently
{
    class Kniha
    {
        public string Nazev { get; set; }
        public string Autor { get; set; }
        public int RokVydani { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Kniha> knihy = new List<Kniha>
        {
            new Kniha { Nazev = "Kniha A", Autor = "Autor X", RokVydani = 1995 },
            new Kniha { Nazev = "Kniha B", Autor = "Autor Y", RokVydani = 2005 },
            new Kniha { Nazev = "Kniha C", Autor = "Autor X", RokVydani = 2010 },
            new Kniha { Nazev = "Kniha D", Autor = "Autor Z", RokVydani = 2018 }
        };

            var vysledek = knihy
                .Where(k => k.RokVydani > 2000)
                .OrderBy(k => k.Autor)
                .Select(k => k.Nazev);

            foreach (var nazev in vysledek)
            {
                Console.WriteLine(nazev);
            }
        }
    }

}
