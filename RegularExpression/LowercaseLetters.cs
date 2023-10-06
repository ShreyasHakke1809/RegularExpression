using System.Text.RegularExpressions;

namespace RegularExpression
{
    internal class LowercaseLetters
    {
        public void Lower()
        {
            string input = "abc_def_ghi jkl_mno_pqr stuv_wxyz";
            string pattern = @"\b[a-z]+(_[a-z]+)+\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            Console.WriteLine("Sequences of lowercase letters joined by underscores:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
