namespace project_template.Services
{
    public class Magic8BallService
    {
        private readonly string[] _responses = new[]
        {
            "It is certain",
            "It is decidedly so",
            "Without a doubt",
            "Yes definitely",
            "You may rely on it",
            "As I see it, yes",
            "Most likely",
            "Outlook good",
            "Yes",
            "Signs point to yes",
            "Reply hazy, try again",
            "Ask again later",
            "Better not tell you now",
            "Cannot predict now",
            "Concentrate and ask again",
            "Don't count on it",
            "My reply is no",
            "My sources say no",
            "Outlook not so good",
            "Very doubtful"
        };

        public string GetResponse(string question)
        {
            Random random = new Random();
            int index = random.Next(_responses.Length);
            return $"Question: {question}\nAnswer: {_responses[index]}";
        }
    }
}
