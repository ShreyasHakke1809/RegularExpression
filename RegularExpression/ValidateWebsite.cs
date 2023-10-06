using System.Text.RegularExpressions;

namespace RegularExpression
{
    internal class ValidateWebsite
    {
        public void Address()
        {
            string pattern = "^http(://)+[a-z]{3}[.][A-Z0-9a-z]{3,}[.][a-z]{3}$";
            Console.WriteLine("Enter input");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, pattern))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
