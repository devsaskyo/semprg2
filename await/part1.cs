using System;
using System.Threading.Tasks;

namespace awaitIGuess
{
    class Program
    {
        static async Task AsynchronniOdpočet(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.WriteLine($"Zbývá {i} sekund");
                await Task.Delay(1000);
            }
            Console.WriteLine("Konec odpočtu!");
        }

        static async Task Main(string[] args)
        {
            var countDown = AsynchronniOdpočet(5);

            while (!countDown.IsCompleted)
            {
                Console.WriteLine("Dělám něco jiného...");
                await Task.Delay(500);
            }

            await countDown;
        }
    }
}
