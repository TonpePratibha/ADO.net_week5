using Review5;

internal class Program
{


    static void PrimeChecker() {
        try
        {
            Console.WriteLine("enter a num");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("enter a positive num");
            }
            if (isPrime(num))
            {
                Console.WriteLine("the nm is prime num");
            }
            else {
                Console.WriteLine("num not prime num");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("invalid input ,enter integer value");
        }
    }
    public static bool isPrime(int num) {
        if (num < 2) return false;
        
        for (int i = 2; i < num; i++) {
            if (num % i == 0)
            {
                return false;
            }
             
               
            
        }
        return true;
    } 


    static void BubbleSort(List<string>list) {

        int n = list.Count;
        for(int i = 0; i < n-1; i++)  
        {
            for (int j = 0; j < n - i - 1; j++) {
                if (string.Compare(list[j], list[j + 1])>0){ 
                    string temp=list[j];
                    list[j]=list[j + 1];
                    list[j+1]=temp;
        
        
        }

            }
        }

        }

    public static void AgeValidation() {
        
        try
        {
            Console.WriteLine("enter age");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                throw new InvalidAgeException("age must be greater than 18");
            }
            else {
                Console.WriteLine("age:" + age);
            }
        }
        catch (InvalidAgeException e) { 
        Console.WriteLine(e.Message);
        }
        Console.ReadLine();

    }


    private static void Main(string[] args)
    {

       // PrimeChecker();

        List<string> list= new List<string>();
        list.Add("akshay");
        list.Add("priti");
        list.Add("sayali");
        list.Add("tina");

        foreach(string s in list) {
            Console.WriteLine(s);

        }

        BubbleSort(list);

        Console.WriteLine("aftre sorting");
        foreach (string s in list)
        {
            Console.WriteLine(s);

        }

        
       Stack stack=new Stack();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Print();
        stack.Pop();
        stack.Peek();

        AgeValidation();

    }
    
}