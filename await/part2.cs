using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace awaitIGuess
{
    class Program
    {
        static async Task<string> StahniDataAsync(string url)
        {
            using (var client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }

        static async Task Main(string[] args)
        {
            string[] urls = { "https://www.example.com", "https://www.google.com" };

            var tasks = new Task<string>[urls.Length];

            for (int i = 0; i < urls.Length; i++)
            {
                tasks[i] = StahniDataAsync(urls[i]);
            }

            var results = await Task.WhenAll(tasks);

            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"URL: {urls[i]}, Počet znaků: {results[i].Length}");
            }
        }
    }

}
