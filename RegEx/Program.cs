using System.Text.RegularExpressions;

namespace RegEx;

class Program
{
    static void Main(string[] args)
    {
        string input = "hello123";
        string pattern = @"[a-z]+\d";
        
        OneMatch(input, pattern);
    }

    public static void OneMatch(string input, string pattern)
    {
        Match match = Regex.Match(input, pattern);
        if (match.Success)
        {
            Console.WriteLine(match.Value);
        }
    }
}