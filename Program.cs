using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        using var httpClient = new HttpClient();
        string apiUrl = "https://swapi.dev/api/people/";

        try
        {
            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"HTTP Request Error: {e.Message}");
        }
    }
}