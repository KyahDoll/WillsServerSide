using LateLab2;

string projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
string filePath = projectFolder + Path.DirectorySeparatorChar + "videogames.csv";

List<VideoGame> game = new List<VideoGame>();

using (var sr = new StreamReader(filePath))
{
    string fileHeader = sr.ReadLine();
    while (!sr.EndOfStream)
    {
        string? line = sr.ReadLine();
        string[] lineElements = line.Split(',');

        VideoGame vg = new VideoGame()
        {
            Name = lineElements[0],
            Platform = lineElements[1],
            Year = Double.Parse(lineElements[2]),
            Genre = lineElements[3],
            Publisher = lineElements[4],
        };

        game.Add(vg);
    }
}

//Dictionary Example
Dictionary<String, String> nameGenre = new Dictionary<String, String>();
foreach (var g in game)
{
    if (!nameGenre.ContainsKey(g.Genre) && !nameGenre.ContainsKey(g.Name))
    {
        nameGenre.Add(g.Genre, g.Name);
    }
}
Console.WriteLine("Using a dictionry the following list contains one game from every video game genre:\n");
foreach (KeyValuePair<string, string> item in nameGenre)
{
    Console.WriteLine("{1} is a {0} game", item.Key, item.Value);
}
Console.WriteLine("\n");
Console.WriteLine("To go to the next screen press any key: ");
Console.ReadLine();
Console.Clear();


//Stack Example
Stack<string> StackOfGames = new Stack<string>();
game.Sort((a, b) => a.Year.CompareTo(b.Year));
foreach (var g in game)
{
    StackOfGames.Push(g.Name);
}
/*foreach (var g in game)
{
    Console.WriteLine(g);
}
*/
//Console.WriteLine("----------------------------------------------------------------------------------------------------");
Console.WriteLine("The following list is a partial list of games ordered by year done with a Stack: ");
Console.WriteLine("These are the 20 newest games in this database: \n");
for (int i = 0; i < 20; i++)
{
    Console.WriteLine($"{i + 1}: {StackOfGames.Pop()}");
}
Console.WriteLine("\n");
Console.WriteLine("To go to the next screen press any key: ");
Console.ReadLine();
Console.Clear();


//Queue Example
Queue<VideoGame> QueueOfGames = new Queue<VideoGame>();
Console.WriteLine("What platform would you like to view games from: ");
var plat = Console.ReadLine();
foreach (var g in game.Where(g => g.Platform == plat))
{
    QueueOfGames.Enqueue(g);
}
int x = 1;
foreach (var g in QueueOfGames)
{
    Console.WriteLine($"Game Number {x} from {plat}:");
    Console.WriteLine(g);
    x++;
}
Console.WriteLine($"The above is a full list of games from {plat}, done with a Queue. \n");
