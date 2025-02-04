using CsvHelper;
using FileHandling;
using System.Globalization;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        var records = new List<Student> {
       new Student{Id=1,Name="abc",Email="abc@gmail.com" },
       new Student{Id=2,Name="xyz",Email="xyz@gmail.com" },
       new Student{Id=3,Name="def",Email="def@gmail.com" }
        };


        string csvpath = "C:\\Users\\Admin\\source\\repos\\Review4\\FileHandling\\demo1csv.csv";
       // File.Create(csvpath);
       using (var writter = new StreamWriter(csvpath))

       using (var csvinput = new CsvWriter(writter, CultureInfo.InvariantCulture))
        {

            csvinput.WriteRecords(records);
       }
    }
}