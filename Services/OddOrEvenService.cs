namespace project_template.Services
{
    public class OddOrEvenService
    {
        public string CheckOddOrEven(int number)
        {
            return number % 2 == 0 ? $"{number} is Even" : $"{number} is Odd";
        }
    }
}
