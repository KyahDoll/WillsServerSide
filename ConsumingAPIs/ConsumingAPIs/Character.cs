namespace ConsumingAPIs
{
    // from https://swapi.dev/api/people/{index}
    public class Character
    {
        public string Name { get; set; } = string.Empty;
        public string Mass  { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;

        public Character() { }

        public Character(string name, string mass, string gender, )
        {
            Name = name;
            Mass = mass;
            Gender = gender;
          
        }

        public override string ToString()
        {
            string characterString = "";
            characterString += $"{Name}\n";
            characterString += $"{Mass}\n";
            characterString += $"{Gender}\n";

            // ternary if
            characterString += ((Subgender == string.Empty) ? "N/A" : Subgender) + "\n";
            characterString += $"{Alignment}\n";

            return characterString;
        }
    }
}
