using DollingerKyahReview;
using System.IO.Pipes;

namespace TryNumber3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<VideoGames> listOfGames = new List<VideoGames>();
            string RootFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            string filePath = $"{RootFolder}{Path.DirectorySeparatorChar}videogames.csv";

            try
            {
                string filecontent = File.ReadAllText(filePath);
                Console.WriteLine("File Contents: ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error has happened.");
                Console.WriteLine(ex.Message);
            }
            using (var reader = new StreamReader(filePath))
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                { 
                    string nextLine = reader.ReadLine();
                    string[] fields = nextLine.Split(",");

                    VideoGames videogames = new VideoGames(fields[0].Trim(), fields[1].Trim(), Int32.Parse(fields[2].Trim()), fields[3].Trim(), fields[4].Trim(), Decimal.Parse(fields[5].Trim()), Decimal.Parse(fields[6].Trim()), Decimal.Parse(fields[7].Trim()), Decimal.Parse(fields[8].Trim()), Decimal.Parse(fields[9].Trim()));

                    videogames.CompareTo(videogames);

                    listOfGames.Add(videogames);
                }

                listOfGames.Sort();
                foreach (VideoGames Game in listOfGames)
                {
                    Console.WriteLine(Game.ToString());
                }

                int numOfGames = listOfGames.Count;

                Console.WriteLine("\n\n\n\n");

                var selectPublisher = from x in listOfGames
                                      where x.Pub == "Sony"
                                      select x;

                foreach (VideoGames Game in selectPublisher)
                {
                    Console.WriteLine(Game.ToString());
                }

                int numberGames = selectPublisher.Count();

                double numGames = double.Parse(numOfGames.ToString());
                double numberGamesI = double.Parse(numberGames.ToString());

                double percentOfPub = Math.Round((numberGames /numberGamesI) * 100, 2);
                Console.WriteLine(percentOfPub + "%");
                Console.WriteLine("Please Press Enter to Continue");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("\n\n\n\n");

                var selectGenre = from a in listOfGames
                                  where a.Genre == "Simulation"
                                  select a;

                foreach (VideoGames vidgameI in selectGenre)
                { 
                    Console.WriteLine(vidgameI.ToString());
                }

                int numvidgame = selectGenre.Count();

                double numVidGame = double.Parse(numvidgame.ToString());

                Console.WriteLine(numVidGame);
                double percentGenre = Math.Round((numVidGame /numGames) * 100, 2);

                Console.WriteLine(percentGenre + "%");
                Console.WriteLine("Please pick a publisher");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Pick a Publisher");
                string userSelection = Console.ReadLine();
               
                var userPick = from z in listOfGames
                               where z.Pub == userSelection
                               select z;

                foreach (VideoGames usergame in userPick)
                { 
                    Console.WriteLine(usergame);
                }

                int userGameNum = userSelection.Count();

                double userGameNumI = Double.Parse(numberGames.ToString());

                Console.WriteLine(userGameNumI);

                double pubPercent = Math.Round((userGameNum / (double)numberGames) * 100, 2);

                Console.WriteLine(userPick + "%");
                Console.WriteLine("Press Enter");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("\n\n\n\n");

                Console.WriteLine("What Genre?");
                string lastOne = Console.ReadLine();



                var LastOne = from b in listOfGames
                                 where b.Genre == lastOne
                                 select b;

                foreach (VideoGames lo in listOfGames)
                {
                    Console.WriteLine(lo.ToString());
                }

                int userNUM = lastOne.Count();

                double USER = Double.Parse(lastOne.ToString());

                Console.WriteLine("Genre:" + USER);

                Console.WriteLine("Total Games: " + numberGames);

                double userPercent = Math.Round((USER / (double)numberGames) * 100, 2);
                Console.WriteLine(userPercent + "%");


            }
            
        }


    }
}


        
       
       
