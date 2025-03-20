namespace FastNumbersConcat;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append("Numbers: ");

        for (int i = 1; i <= 5000; i++)
        {
            sb.Append(i);
        }
        Console.WriteLine(sb.ToString().Substring(0, 1024));
        Console.WriteLine(DateTime.Now);
        
        
    }
}