using System.Security.Cryptography.X509Certificates;

namespace NullableStrings;

class Program
{
    static void Main(string[] args)
    {
        string s1;  //not nullable
        string? s2; //nullable
        
        Console.WriteLine("Please insert s1 and s2");
        s1 = Console.ReadLine()!;
        s2 = Console.ReadLine();

        if (s2 != null)
        {
            if (s1.Equals("Hello") && s2.Equals("World!!!"))
            {
                
            }
        }
    }

    public static string? GetUpperCaseString()
    {
        string? s1;
        Console.WriteLine("Please insert uppercase string");
        s1 = Console.ReadLine();
        
        return s1?.ToUpper();
        
    }
}