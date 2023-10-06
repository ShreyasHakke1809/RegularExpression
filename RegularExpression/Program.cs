namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n1.String match\n2.Sequence of lowercase letters joined by underscore\n3.Validate website\n4.Valide image extension" +
                "\n5.Number of occurrences of word\n6.Print HTML tags\n7.Exit");
            bool loopAgain = true;
            while (loopAgain)
            {
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        MatchString matchString = new MatchString();
                        matchString.Match();
                        break;
                    case 2:
                        LowercaseLetters lowercaseLetters = new LowercaseLetters();
                        lowercaseLetters.Lower();
                        break;
                    case 3:
                        ValidateWebsite validateWebsite = new ValidateWebsite();
                        validateWebsite.Address();
                        break;
                    case 4:
                        ValidImageExtension extension = new ValidImageExtension();
                        extension.Image();
                        break;
                    case 5:
                        NumberOfOccurrences numberOfOccurrences = new NumberOfOccurrences();
                        numberOfOccurrences.Pattern();
                        break;
                    case 6:
                        HtmlTags htmlTags = new HtmlTags();
                        htmlTags.Tags();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    case 8:
                        loopAgain = false;
                        break;
                }
            }
        }
    }
}