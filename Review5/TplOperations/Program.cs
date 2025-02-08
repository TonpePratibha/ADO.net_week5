using System.Globalization;

internal class Program
{

    public static void WriteNumbers(string path, int[] nums)
    {

        File.WriteAllLines(path, nums.Select(n => n.ToString()));
    }
    static async Task Main()
    {
        string path = "E:\\bridgelabz_assignments\\ado.netanddelegates\\Review5\\TplOperations\\demo.text";
        //File.Create(path);

        int[] nums= { 1, 2, 3 ,4,5};
        List<string> names = new List<string> { "abc","xyz","pqr" };

        
        var write = Task.Run(() => WriteNumbers(path,nums));
        var sum = Task.Run(() => nums.Sum());  
        var sorting = Task.Run(() => names.OrderBy(name => name).ToList()); 

        await Task.WhenAll(write, sum, sorting);

        Console.WriteLine(sum.Result);
        Console.WriteLine( string.Join(", ", sorting));
    }
    

}
        
        
    
   

