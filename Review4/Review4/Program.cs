using Review4;
using System.Text.RegularExpressions;


internal class Program
{
    static void ValidEmail(string email) {
        string emailpattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        Regex regex = new Regex(emailpattern);
        if (regex.IsMatch(email)) {
            Console.WriteLine("valid email");
        }
        else
        {

            Console.WriteLine("invalid email");
        }



    }
    static void Phonenumber(string num) {
        string pattern = @"\b\d{10}\b";    // @"[0-9]{10}$";
        Regex regex = new Regex(pattern);
        if (regex.IsMatch(num))
        {
            Console.WriteLine("valid number");
        }
        else {

            Console.WriteLine("invalid num");
        }


    }

    static void validatePassword(string pass) {
        string passpattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

        Regex regex = new Regex(passpattern);
        if (regex.IsMatch(pass))
        {
            Console.WriteLine("valid email");
        }
        else {
            Console.WriteLine("invalid email");

        }

    }

    static void ReplacewhiteSpaces() {
        Console.WriteLine("enetr string");
        string str = Console.ReadLine();

        string result = Regex.Replace(str, @"\s+", " ").Trim();


        Console.WriteLine(result);
    }


    static void ExtractDates() {

        Console.WriteLine("Enter text");
        string text = Console.ReadLine();


        string datespattern = @"(?:\d{2}/\d{2}/\d{4}|\d{4}-\d{2}-\d{2})";


        MatchCollection matches = Regex.Matches(text, datespattern);


        Console.WriteLine("extracted dates are");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }


    static void CheckFileSize(string filePath, long maxSize)
    {
        FileInfo fileInfo = new FileInfo(filePath);

        if (fileInfo.Length > maxSize)
        {
            throw new FileSizeException($"File size is too large!");
        }
    }




    public static void Palindrome()
    {

        Func<string, bool> isPalindrome = str => str == new string(str.ToCharArray().Reverse().ToArray());


        Console.WriteLine("enter a string ");
        string str = Console.ReadLine();


        bool result = isPalindrome(str);

        if (result)
        {
            Console.WriteLine($"string is a palindrome.");
        }
        else
        {
            Console.WriteLine($"string is not a palindrome.");
        }

    }


    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
    private static void Main(string[] args)
    {
        /* Console.WriteLine("enter email");
         string email = Console.ReadLine();
         ValidEmail(email);

         Console.WriteLine("enter phonenum");
         string num = Console.ReadLine();
        Phonenumber(num);

         Console.WriteLine("enter pass");
         string password = Console.ReadLine();
         validatePassword(password);
        */
        // ReplacewhiteSpaces();

        // ExtractDates();



        //file 
        string path = "C:\\Users\\Admin\\source\\repos\\Review4\\Review4\\demo.txt";
        long maxSize = 1 * 1024 * 1024;

        try
        {
            CheckFileSize(path, maxSize);
            Console.WriteLine("File size is within the limit.");
        }
        catch (FileSizeException ex)
        {
            Console.WriteLine(ex.Message);
        }


        //generics
        int x = 5, y = 10;

        Swap(ref x, ref y);
        Console.WriteLine("after swap" + x + y);


        string a = "abc", b = "xyz";
        Swap(ref a, ref b);
        Console.WriteLine("after swap" + a + b);



        //writedata to csv
        
    } }



