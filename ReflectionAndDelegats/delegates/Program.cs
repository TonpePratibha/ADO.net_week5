


delegate void MyDel(int x,int y);
internal class Program
{
    public static void Add(int x, int y) 
     {
        //return x + y;
        Console.WriteLine(x + y);
    }
    public static void multiply(int x, int y)
    {
        // return x * y;
        Console.WriteLine(x * y);
    }
    private static void Main(string[] args)
    {
        /*  MyDel del = new MyDel(Add);
          int result = del(12, 23);
          Console.WriteLine(result);
          del = multiply ;
          result= del(12, 23);
          Console.WriteLine(result);


          //another way
          MyDel del1 = new MyDel(Add);  //it will gives th last function result it overrides previous result
          int result1 = del(10,20);
          del1 += multiply;
          Console.WriteLine(result1);
        */
        //to avoid above we ca ue nother way by making function return types to void
        MyDel del = Add;
        del += multiply;
        del(12, 20);
       

            
    }
}