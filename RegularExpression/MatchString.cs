using System.Text.RegularExpressions;

namespace RegularExpression
{
    internal class MatchString
    {
        public void Match()
        {
            string pattern = "^[a]{2,3}[b]{2,3}$";
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
