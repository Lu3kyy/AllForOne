namespace project_template.Services
{
    public class GuessItService
    {
        private static int? _secretNumber;
        private static int _attempts = 0;

        public GuessItService()
        {
            if (_secretNumber == null)
            {
                Random random = new Random();
                _secretNumber = random.Next(1, 101);
            }
        }

        public string MakeGuess(int guess)
        {
            _attempts++;

            if (guess < 1 || guess > 100)
                return "Please guess a number between 1 and 100.";

            if (guess < _secretNumber)
                return $"Too low! Attempts: {_attempts}";
            else if (guess > _secretNumber)
                return $"Too high! Attempts: {_attempts}";
            else
            {
                string result = $"Correct! You guessed it in {_attempts} attempts! The number was {_secretNumber}.";
                Random random = new Random();
                _secretNumber = random.Next(1, 101);
                _attempts = 0;
                return result;
            }
        }
    }
}
