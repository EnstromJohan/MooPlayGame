namespace MooPlay
{
    public class MooGame
    {
        private string ?correctGuess;

        //Metod för att generera ett slumpat nummer
        public string GenerateRandomNumber()
        {
            Random random = new Random();
            correctGuess = random.Next(1000, 1000).ToString("D4");
            return correctGuess;
        }

        //Error handling, kollar om gissningen är giltig.
        public bool IsGuessValid(string guess)
        {
            return guess.Length == 4 && guess.All(char.IsDigit);
        }

        public int PlayGame()
        {
            Console.WriteLine("New game:  ");
            Console.WriteLine("For practice, the number is: " + correctGuess);

            int numberOfGuesses = 0;

            do
            {
                Console.WriteLine("Enter your guess:  ");
                string guess = Console.ReadLine();

                if (!IsGuessValid(guess))

                {
                    Console.WriteLine("Invalid guess. Please enter a 4-digit number");
                    continue;
                }
                numberOfGuesses++;

                if (guess == correctGuess)
                {
                    Console.WriteLine("Your guess was correct, congratulations!");
                    break;
                }

                else
                {
                    string answer = GetGuess(correctGuess, guess);
                    Console.WriteLine(answer);
                }
            } while (true);

            return numberOfGuesses;
        }

        public string GetGuess(string correctGuess, string guess)
        {
            int bulls = 0;
            int cows = 0;

            for (int i = 0; i < 4; i++)
            {
                if (correctGuess[i] == guess[i])
                {
                    bulls++;
                }

                else if (correctGuess.Contains(guess[i]))
                {
                    cows++;
                }
            }
            return $"{bulls} bulls, {cows} cows";
        }
    }
}
