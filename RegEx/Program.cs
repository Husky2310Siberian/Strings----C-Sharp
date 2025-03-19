using System.ComponentModel.Design;
using System.Text.RegularExpressions;

namespace RegEx;
/// <summary>
/// regex pattern "[a-z]+\d"  finds lowercase letters followed by a single digit.
///     \b ensures the match starts at a word boundary.
///     \w+ matches the key name (like price1, price2, price3).
///     : matches the colon separator.
///     \s* allows for optional whitespace after the colon.
///     \$\d+ ensures that a dollar sign ($) is followed by one or more digits.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        string input = "HELLO + hello123";
        string pattern = @"[a-z]+\d"; // d+ finds all digits
        GetOneMatch(input, pattern);
        
        string input2 = "Price1: $10, PRICE2: $20 , price3: $30";
        string pattern2 = @"\b\w+:\s*\$\d+";
        GetMultipleMatches(input2, pattern2);
        
        string input3 = "Phone number: 123-456789";
        string pattern3 = @"\d";
        Replaces(input3, pattern3);
        
        string input4 = "red,white,green,blue";
        string pattern4 = @"\b,";
        Split(input4, pattern4);
    }

    public static void GetOneMatch(string input, string pattern)
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

    public static void GetMultipleMatches(string input, string pattern)
    {
        MatchCollection matches = Regex.Matches(input, pattern);
        foreach (Match matche in matches)
        {
            Console.WriteLine(matche.Value);
        }
    }

    public static void Replaces(string input, string pattern)
    {
        string replaced = Regex.Replace(input, pattern, "*");
        Console.WriteLine(replaced);
    }

    public static void Split(string input, string pattern)
    {
        string [] tokens = Regex.Split(input, pattern);
        foreach (string token in tokens)
        {
            Console.WriteLine(token);
        }
    }
}