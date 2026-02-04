namespace project_template.Services
{
    public class ReverseNumbersService
    {
        public string ReverseNumber(int number)
        {
            string numberStr = number.ToString();
            bool isNegative = numberStr.StartsWith("-");
            
            if (isNegative)
                numberStr = numberStr.Substring(1);
            
            char[] charArray = numberStr.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            
            return isNegative ? $"-{reversed}" : reversed;
        }
    }
}
