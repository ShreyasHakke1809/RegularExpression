using System.Text.RegularExpressions;

namespace RegularExpression
{
    internal class ValidImageExtension
    {
        public void Image()
        {
            string pattern = "^[A-Z0-9a-z]{1,}[.][jpg|jpeg|png|pdf|gif|psd|ai]+$";
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
