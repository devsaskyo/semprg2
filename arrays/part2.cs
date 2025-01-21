using System;

namespace arraysIGuess
{
    class Program
    {
        static void Main()
        {
            int[,] matice1 = new int[3, 3];
            int[,] matice2 = new int[3, 3];
            int[,] soucetMatice = new int[3, 3];

            Console.WriteLine("Zadejte hodnoty pro první matici (3x3):");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Zadejte hodnotu pro matice1[{i}, {j}]: ");
                    matice1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nZadejte hodnoty pro druhou matici (3x3):");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Zadejte hodnotu pro matice2[{i}, {j}]: ");
                    matice2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    soucetMatice[i, j] = matice1[i, j] + matice2[i, j];
                }
            }

            Console.WriteLine("\nPrvní matice:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matice1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nDruhá matice:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matice2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSoučet matic:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(soucetMatice[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

}
