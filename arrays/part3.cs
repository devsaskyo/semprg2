using System;

namespace arraysIGuess
{
    class Program
    {
        static void Main()
        {
            Console.Write("Zadej počet řádků první matice (m): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Zadej počet sloupců první matice (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Zadej počet řádků druhé matice (n - kontrola): ");
            int n2 = int.Parse(Console.ReadLine());

            if (n != n2)
            {
                Console.WriteLine("Chyba: Počet sloupců první matice musí být stejný jako počet řádků druhé matice.");
                return;
            }

            Console.Write("Zadej počet sloupců druhé matice (p): ");
            int p = int.Parse(Console.ReadLine());

            int[,] maticeA = new int[m, n];
            int[,] maticeB = new int[n, p];
            int[,] maticeC = new int[m, p];

            Console.WriteLine($"Zadej hodnoty pro první matici ({m}x{n}):");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"maticeA[{i + 1},{j + 1}]: ");
                    maticeA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"Zadej hodnoty pro druhou matici ({n}x{p}):");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write($"maticeB[{i + 1},{j + 1}]: ");
                    maticeB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        maticeC[i, j] += maticeA[i, k] * maticeB[k, j];
                    }
                }
            }

            Console.WriteLine("\nPrvní matice (A):");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(maticeA[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nDruhá matice (B):");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write(maticeB[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nVýsledek násobení (C = A × B):");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write(maticeC[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
