using System.Text.RegularExpressions;

namespace RegularExpression
{
    internal class NumberOfOccurrences
    {
        public void Pattern()
        {
            string pattern = @"fox(es)?";
            string s = @"foxes are omnivorous fox belonging to several genera of the family Canidae fox.";

            Regex regex = new Regex(pattern);

            int n = regex.Matches(s).Count;

            Console.WriteLine("There are " + n + " occurrences");
        }
    }
}
