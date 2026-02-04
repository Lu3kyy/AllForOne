namespace project_template.Services
{
    public class ReverseService
    {
        public string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
