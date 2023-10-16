namespace MooPlay
{
    public class PlayerData
    {
        public string Name { get; private set; }
        public int GamesPlayed { get; private set; }
        private int TotalGuesses;

        public PlayerData(string name, int totalGuesses)
        {
            Name = name;
            GamesPlayed = 1;
            TotalGuesses = totalGuesses;
        }

        public void Update(int totalGuesses)
        {
            TotalGuesses += totalGuesses;
            GamesPlayed++;
        }

        public double Average()
        {
            if (GamesPlayed > 0)
            {
                return (double)TotalGuesses / GamesPlayed;
            }

            else
            {
                return 0.0;
            }
        }
    }
}

