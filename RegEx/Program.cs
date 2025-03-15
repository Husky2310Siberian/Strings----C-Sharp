using System.Text.RegularExpressions;

namespace RegEx;
/// <summary>
/// regex pattern "[a-z]+\d"  finds lowercase letters followed by a single digit.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        string input = "HELLO + hello123";
        string pattern = @"[a-z]+\d"; // d+ finds all digits
        
        OneMatch(input, pattern);
    }

    public static void OneMatch(string input, string pattern)
    {
        Match match = Regex.Match(input, pattern);
        if (match.Success)
        {
            Console.WriteLine(match.Value);
        }
        else
        {
            Console.WriteLine("No match found");
        }
    }
}