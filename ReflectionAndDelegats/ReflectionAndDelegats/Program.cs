using System.Reflection;



class Student {
    public int Rollno{ get; set; }
    public string Name { get; set; }
   public int marks { get; set; }

    public void DiaplayData() {

        Console.WriteLine(Rollno + Name + marks);

    }
    public Student() { 
    Rollno = 0;
        Name = "pratibha";
        marks = 100;
    }

    public Student(int rollno, string name,int marks) { 

        Rollno = rollno;
            Name = name;
        marks = marks;
    }

}

internal class Program
{


    private static void Main(string[] args)
    {
       /* Type type = typeof(string);
        Console.WriteLine(type.Name);
        MethodInfo[] methods = type.GetMethods();
        foreach (var method in methods) { 
        Console.WriteLine(method.Name);
            ParameterInfo[] parameters=method.GetParameters();
            foreach (var param in parameters) { 
            Console.WriteLine($"{param.Name}");
            }

        }*/

        Assembly assembly = Assembly.GetExecutingAssembly();
        Type[] types= assembly.GetTypes();
        foreach (Type type in types)
        {
            Console.WriteLine(type.Name);



            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods) { 
            Console.WriteLine($"{method.Name}");

                ParameterInfo[] parameters=method.GetParameters();
              foreach(ParameterInfo parameter in parameters)  {
                    Console.WriteLine(parameter.Name);
                }
            }

        }
    }
}