namespace project_template.Services
{
    public class AskingQuestionsService
    {
        public string ProcessAnswer(string wakeUpTime, string food)
        {
            return $"You got up at {wakeUpTime} and ate {food}.";
        }
    }
}
