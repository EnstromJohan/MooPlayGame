namespace MooPlay
{
    public class PlayerData
    {
        public string Name { get; private set; }
        public int GamesPlayed { get; private set; }
        private int totalGuesses;

        public PlayerData(string name, int guesses)
        {
            Name = name;
            GamesPlayed = 1;
            totalGuesses = guesses;
        }

        public void Update(int guesses)
        {
            totalGuesses += guesses;
            GamesPlayed++;
        }

        //Hämtar antal gissningar per omgång
        public double Average => GamesPlayed > 0 ? (double)totalGuesses / GamesPlayed : 0.0;
    }
}

