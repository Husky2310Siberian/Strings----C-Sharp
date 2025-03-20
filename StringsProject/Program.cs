namespace StringsProject;

class Program
{
    static void Main(string[] args)
    {
        string s1 = "Hello World!";
        string s2 = "Hello World!"; // interning --> same post in Heap
        string s3 = "hello world!";
        string s4 = "HELLO WORLD!";
        
        // Equality --> Equals or ==
        Console.WriteLine($"{s1.Equals(s2)}");
        Console.WriteLine($"{s1 == s2}");
        Console.WriteLine($"{ReferenceEquals(s1, s2)}");
        Console.WriteLine($"{s1.Equals(s3)}");
        Console.WriteLine($"{s1 == s3}");
        Console.WriteLine($"{ReferenceEquals(s1, s3)}");
        
        // < , <= , => , >
        Console.WriteLine($"{string.Compare(s1 , s2)}");
        Console.WriteLine($"{string.Compare(s1 , s3)}");
        Console.WriteLine($"{string.Compare(s3 , s4)}");
        Console.WriteLine($"{s1.CompareTo(s3)}");
        
        // concat
        string s5 = "Hello";
        string s6 = "World!";
        Console.WriteLine($"{String.Concat(s5,s6)}");
        
        //ToUpper() , ToLower()
        Console.WriteLine(s4.ToLower());
        
        //indexOf , substring
        string s7 = "C# Strings Project";
        int index = s7.IndexOf("#"); // 1
        int index2 = s7.IndexOf("P" , 3);
        s7.Substring(0, 5);
        Console.WriteLine(index);
        Console.WriteLine(index2);

        //trim
        string s8 = "   C# Strings Project ";
        Console.WriteLine(s8.Trim());
        
        string s9 = " -- ** C# Strings  Hello     World **  {  }";
        char[] chars = { ' ', '\t', '\n', '\r', '-','*' , '{' , '}' };
        Console.WriteLine(s9.Trim(chars));
        
        string s = "Programming with Strings Project";
        string s111 = s.Substring(5, 5);
        Console.WriteLine(s111);
        string s222 = s.Replace("P" , "p");
        Console.WriteLine(s222);
        string s333 = s.Remove(16).Replace("P" , "p");
        Console.WriteLine(s333);
            
    }
    
    public static bool IsPalindrome(string s)
    {
        int i = 0, j = s.Length - 1; 

        while (i < j)
        {
            if (s[i] != s[j])
            {
                return false; // Return false immediately if a mismatch is found
            }
            i++;
            j--;
        }
        return true; // If no mismatch is found, return true
    }
}