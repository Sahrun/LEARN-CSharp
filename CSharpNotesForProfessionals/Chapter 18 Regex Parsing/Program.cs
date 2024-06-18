using System.Text.RegularExpressions;

namespace Chapter_18_Regex_Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 18: Regex Parsing");
            Console.WriteLine();
            Console.WriteLine("Section 18.1: Single match");

            string pattern = ":(.*?):";
            string lookup = "--:text in here:--";

            Regex rgLookup = new Regex(pattern, RegexOptions.Singleline, TimeSpan.FromSeconds(1));
            Match mLookup = rgLookup.Match(lookup);

            string found = mLookup.Groups[1].Value;

            Console.WriteLine(found);

            List<string> founds = new List<string>();
            pattern = ":(.*?):";
            lookup = "--:text in here:--:another one:-:third one:---!123:fourth:";

            Regex rgxLookup = new Regex(pattern,RegexOptions.Singleline,TimeSpan.FromSeconds(1));
            MatchCollection mLookups = rgxLookup.Matches(lookup);

            foreach (Match match in mLookups)
            {
                founds.Add(match.Groups[1].Value);
            }
        }
    }
}