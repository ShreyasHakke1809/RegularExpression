using System.Text.RegularExpressions;

namespace RegularExpression
{
    internal class HtmlTags
    {
        public void Tags()
        {
            string input = "< p > The < code > Regex </ code > is a compiledrepresentation of a regular expression.</ p >";
            string pattern = "<[^>]+>";//"^[<][a-z]{1,}[>][<][a-z]{1,}[/>]$";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
