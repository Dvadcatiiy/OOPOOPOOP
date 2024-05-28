using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var startTime = DateTime.Now;

            var responses = new List<string>();

            try
            {
                using (var client = new HttpClient())
                {
                    responses.Add(await MakeRequestAsync(client, "https://hh.ru/oauth/token"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            foreach (var response in responses)
            {
                Console.WriteLine(response);
            }

            var endTime = DateTime.Now;
            Console.WriteLine($"Total time: {(endTime - startTime).TotalSeconds} seconds");
        }

        static async Task<string> MakeRequestAsync(HttpClient client, string url)
        {
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception($"Server returned status code {response.StatusCode}");
            }
        }
    }
}