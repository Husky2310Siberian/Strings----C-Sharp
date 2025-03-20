namespace SlowNumbersConcat;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        string collector = "Numbers: ";

        for (int i = 1; i <= 5000; i++)
        {
            collector += i;
        }
        Console.WriteLine(collector.Substring(0,1024));
        Console.WriteLine(DateTime.Now);
        
        
    }
}