using System;

public class Program
{
    static void Main(string[] args)
    {
        Valorant game = new Valorant("Valorant", 2021, "Riot Games", 5000000, "Yes", "Tactical shooter");
        game.DisplayInfo();
    }

    public class Valorant
    {

        private double AveragePlayers { get; set; }
        private string IsFreeToPlay { get; set; }
        private string Description { get; set; }

        public Valorant(string gameTitle, int releaseYear, string developer)
        {
            GameTitle = gameTitle;
            ReleaseYear = releaseYear;
            Developer = developer;
        }

        public Valorant(string gameTitle, int releaseYear, string developer, double averagePlayers, string isFreeToPlay, string description)
            : this(gameTitle, releaseYear, developer)
        {
            AveragePlayers = averagePlayers;
            IsFreeToPlay = isFreeToPlay;
            Description = description;
        }

        public string GameTitle { get; set; }
        public int ReleaseYear { get; set; }
        public string Developer { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Game Title: {GameTitle}");
            Console.WriteLine($"Release Year: {ReleaseYear}");
            Console.WriteLine($"Developer: {Developer}");
        }

        public Valorant()
        {

        }
    }
}
