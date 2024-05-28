using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var startTime = DateTime.Now;

            var responses = new List<string>();

            try
            {
                using (var client = new HttpClient())
                {
                    responses.Add(MakeRequest(client, "https://hh.ru/oauth/token"));
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

        static string MakeRequest(HttpClient client, string url)
        {
            var response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                throw new Exception($"Server returned status code {response.StatusCode}");
            }
        }
    }
}