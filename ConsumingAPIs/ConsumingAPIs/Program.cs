using ConsumingAPIs;
using System.Text.Json;

public class Program
{
    public static async Task Main(string[] args)
    {
       // await PokemonCall();
        await CharacterCall();
    }

   /*public static async Task PokemonCall()
    {
        // sending our request to https://pokeapi.co/api/v2/pokemon/smoochum

        // create a HttpClient object to use to send the request
        var client = new HttpClient();


        // Receive a response and store it in a variable
        // use 'await' when accessing an async method / resource
        HttpResponseMessage response = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/smoochum");

        // store body of the response in a variable (this is our json)
        string json = await response.Content.ReadAsStringAsync();

        // Deserialize = pulling a .NET object out of json
        // Serialize = create json from a .NET object

        // capitalization of properties doesn't matter with this option, as long as the prop names
        // match the json keys
        var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        Pokemon p = JsonSerializer.Deserialize<Pokemon>(json, options);
        Console.WriteLine(p + "\n");
    }

    */
    public static async Task CharacterCall()
    {
        // sending our request to https://swapi.dev/api/people/{index}

        // json for all of these monsters
        var characterNames = new string[] { "Luke Skywalker", "R2-D2", "Owen Lars"};

        // create a HttpClient object to use to send the request
        var client = new HttpClient();

        foreach (var characterName in characterNames)
        {
            // Receive a response and store it in a variable
            // use 'await' when accessing an async method / resource
            HttpResponseMessage response = await client.GetAsync($"https://swapi.dev/api/people/{characterName}");

            // store body of the response in a variable (this is our json)
            string json = await response.Content.ReadAsStringAsync();

            // Deserialize = pulling a .NET object out of json
            // Serialize = create json from a .NET object

            // capitalization of properties doesn't matter with this option, as long as the prop names
            // match the json keys
            var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

            Character character = JsonSerializer.Deserialize<Character>(json, options);
            Console.WriteLine(character + "\n");
        }
    }
}