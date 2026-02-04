namespace project_template.Services
{
    public class AddingTwoNumbersService
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public string Compare(int number1, int number2)
        {
            if (number1 > number2)
                return $"{number1} is higher than {number2}.";
            else if (number1 < number2)
                return $"{number1} is lower than {number2}.";
            else
                return $"{number1} and {number2} are equal.";
        }
    }
}
