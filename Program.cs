using API;
using Newtonsoft.Json;

class Program
{
    static async Task Main()
    {
        using var httpClient = new HttpClient();
        string apiUrl = "https://swapi.dev/api/people/";
        var dict = new Dictionary<string, string>();

        try
        {
            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                var per = JsonConvert.DeserializeObject<People>(content);

                foreach (Person item in per.Results)
                {
                    HttpResponseMessage respo = await httpClient.GetAsync(apiUrl);
                    string home = await response.Content.ReadAsStringAsync();
                    var plan = JsonConvert.DeserializeObject<Planet>(home);

                    dict.Add(person.name, Planet.name);
                }
                
                //----------------------------------------------------------------------------------------
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