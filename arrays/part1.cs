using System;

namespace arraysIGuess
{
    class Program
    {
        static void Main()
        {
            int[,] matice = new int[2, 3];
            int soucet = 0;

            Console.WriteLine("Zadejte hodnoty pro matici 2x3 (2 řádky, 3 sloupce):");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Zadejte hodnotu pro matice[{i}, {j}]: ");
                    matice[i, j] = int.Parse(Console.ReadLine());
                    soucet += matice[i, j];
                }
            }

            Console.WriteLine("\nObsah matice:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matice[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nSoučet všech prvků je: {soucet}");
        }
    }
}
