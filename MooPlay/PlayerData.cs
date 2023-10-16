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

        public double Average()
        {
            if (GamesPlayed > 0)
            {
                return (double)totalGuesses / GamesPlayed;
            }

            else
            {
                return 0.0;
            }
        }
    }
}

