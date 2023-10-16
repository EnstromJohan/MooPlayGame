namespace MooPlay
{
    public class GameMenu
    {
        private MooGame game;
        private List<PlayerData> data;

        public GameMenu()
        {
            game = new MooGame();
            data = new List<PlayerData>();
        }

        //Metod för att starta spelet
        public void StartGame(string playerName)
        {
            while (true)
            {
                string correctGuess = game.GenerateRandomNumber();
                int numberOfGuesses = game.PlayGame();

                SaveResult(playerName, numberOfGuesses);
                DisplayTopList();

                Console.WriteLine($"Correct, you tried {numberOfGuesses} times. Continue? (y/n)");
                string answer = Console.ReadLine();
                if (answer != null && !answer.StartsWith("y"))
                {
                    break;
                }
            }
        }

        private void SaveResult(string playerName, int numberOfGuesses)
        {
            data.Add(new PlayerData(playerName, numberOfGuesses));

            //Skriver resultat till txt fil
            try
            {
                using(StreamWriter writer = new StreamWriter("result.txt", append: true))
                {
                    writer.WriteLine($"{playerName} & {numberOfGuesses}");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine($"Error while saving result: {e.Message}");
            }
        }

        private void DisplayTopList()
        {
            //Sorterar listan efter genomsnittliga gissningar
            data.Sort((playerOne, playerTwo) => playerOne.Average().CompareTo(playerTwo.Average()));

            Console.WriteLine("Player   Games   Average");
            foreach (PlayerData player in data)
            {
                //Skriver ut spelarens statistik i en tabell
                Console.WriteLine($"{player.Name,-9}{player.GamesPlayed,-8}{player.Average:F2}");
            }
        }
    }
}
