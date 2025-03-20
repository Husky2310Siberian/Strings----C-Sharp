using System.Text.RegularExpressions;

namespace ValidateMobileRegEx;

class Program
{
    static void Main(string[] args)
    {
        // string inputmobile = "1234567899";
        // string inputmobile2 = "123-456-7899";
        // string inputmobile3 = "12-34-56789";
        // string inputmobile4 = "12-34-567";
        //
        // Console.WriteLine(IsMobileNumberValid(inputmobile))};
        // Console.WriteLine(IsMobileNumberValid(inputmobile2));
        // Console.WriteLine(IsMobileNumberValid(inputmobile3));
        // Console.WriteLine(IsMobileNumberValid(inputmobile4));

        string[] str = { "1234567899", "+123 456 7899", "+12-34-56789", "12-34-567", "+12 34567800"};

        foreach (string mobile in str)
        {
            Console.WriteLine("{0} {1} a valid mobile number" , mobile, IsMobileNumberValid(mobile) ? "is" : "is not");
        }


    }

    public static bool IsMobileNumberValid(string inputMobileNumber)
    {
        string regexMobileNumber = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]{2}[0-9]{6}$)|(^[0-9]{3}-[0-9]{3}-[0-9]{4}$)";
        
        Regex regex = new Regex(regexMobileNumber);
        
        if (regex.IsMatch(inputMobileNumber))
        {
            return true;
        }
        else
        {
           return false;
        }
    }
}