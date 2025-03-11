using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ratesIGuess
{
    class Program
    {
        static async Task Main()
        {
            using var httpClient = new HttpClient();
            bool continueRunning = true;

            while (continueRunning)
            {
                try
                {
                    var response = await httpClient.GetAsync("https://saskyo.com/get-exchange-rates/?plaintext&ZofmV2ebs5Mj9ED4IreNJaHGCY8zI2FZ&EUR");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonData = await response.Content.ReadAsStringAsync();
                        var exchangeRates = JsonSerializer.Deserialize<Dictionary<string, double>>(jsonData);

                        if (exchangeRates != null && exchangeRates.ContainsKey("CZK") && exchangeRates.ContainsKey("USD"))
                        {
                            Console.WriteLine($"Kurz EUR vůči CZK: {exchangeRates["CZK"]}, USD: {exchangeRates["USD"]}");
                        }
                        else
                        {
                            Console.WriteLine("Error: rates for USD, CZK not available.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("API returned an error.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurred while trying to load data.");
                }

                if (Console.KeyAvailable && Console.ReadKey(intercept: true).Key == ConsoleKey.Escape)
                {
                    continueRunning = false;
                }

                await Task.Delay(500);
            }

            Console.WriteLine("Stopped.");
        }
    }
}
