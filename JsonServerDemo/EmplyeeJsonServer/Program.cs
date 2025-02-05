using EmplyeeJsonServer;
using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Runtime.InteropServices;

internal class Program
{

    private static readonly string BASE_URL = "http://localhost:3000";
    private static async Task GetEmployyeList() {
        var client= new RestSharp.RestClient(BASE_URL);
        var request = new RestRequest("employees", Method.Get);
        var response = await client.ExecuteAsync(request);
        if (response.StatusCode == HttpStatusCode.OK)
        {
            List<Employee> emplist = JsonConvert.DeserializeObject<List<Employee>>(response.Content);
            foreach (var emp in emplist)
            {
                Console.WriteLine($"id:{emp.Id}, name: {emp.Name} ,salary:{emp.Salary}");

            }

        }
        else {
            Console.WriteLine("failed");
        }

    }


    private static async Task AddNewEmployee(string Id, string name, string salary)
    {
        var client = new RestSharp.RestClient(BASE_URL);
        var request = new RestRequest("employees", Method.Post);
        var jsonObj = new
        {
            Id = Id,
            name = name,
            salary = salary
        };

        request.AddJsonBody(jsonObj);

        var response = await client.ExecuteAsync(request);

        if (response.StatusCode == System.Net.HttpStatusCode.Created)
        {
            var employee = JsonConvert.DeserializeObject<Employee>(response.Content);
            Console.WriteLine($"Added Employee: {employee.Name}, Salary: {employee.Salary}");
        }
        else
        {
            Console.WriteLine($"Failed to add employee. Status: {response.StatusCode}");
        }
    }


    private static async Task DeleteEmployee(int id)
    {
        var client = new RestSharp.RestClient(BASE_URL);
        var request = new RestRequest($"employees/{id}", Method.Delete);
        var response = await client.ExecuteAsync(request);

        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            Console.WriteLine($"Successfully deleted employee with ID: {id}");
        }
        else
        {
            Console.WriteLine($"Failed to delete employee with ID: {id}. Status: {response.StatusCode}");
        }
    }

    private static async Task AddMultipleEmployees()
    {
        var client = new RestSharp.RestClient(BASE_URL);
        var employees = new List<Employee>
            {
                new Employee { Name = "Dustin", Salary = "85536" },
                new Employee { Name = "Will", Salary = "120123" },
                new Employee { Name = "Eleven", Salary = "123456" }
            };

        foreach (var emp in employees)
        {
            var request = new RestRequest("employees", Method.Post);
            var jsonObj = new
            {
                name = emp.Name,
                salary = emp.Salary
            };

            request.AddJsonBody(jsonObj);

            var response = await client.ExecuteAsync(request);

            if (response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                var addedEmp = JsonConvert.DeserializeObject<Employee>(response.Content);
                Console.WriteLine($"Added Employee: {addedEmp.Name}, Salary: {addedEmp.Salary}");
            }
            else
            {
                Console.WriteLine($"Failed to add employee {emp.Name}. Status: {response.StatusCode}");
            }
        }
    }
    private static async Task Main(string[] args)
    {

         //string path = "C:\\Users\\Admin\\source\\repos\\JsonServerDemo\\EmplyeeJsonServer\\Employeejson.json";
         //File.Create(path);
       // var client = new RestClient("http://localhost:3000");

        //// Create a GET request
       // var request = new RestRequest("employees", Method.Get);

        //// Execute the request
       // var response = client.Execute(request);

        //// Check response status
       // if (response.StatusCode == HttpStatusCode.OK)
      //  {
       //     Console.WriteLine("Data retrieved successfully!");

        //    // Deserialize the response content
         //  List<Employee> employeeList = JsonConvert.DeserializeObject<List<Employee>>(response.Content);

        //    // Print the employee details
          // if (employeeList != null)
          // {
           //    foreach (var emp in employeeList)
           //    {
            //        Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
              //  }
            //}
            //else
            //{
              // Console.WriteLine("No employees found or failed to deserialize.");
            //}
        //}
        //else
        //{
       //     Console.WriteLine($"Error: {response.StatusCode}, Message: {response.Content}");
        //}





        await GetEmployyeList();
        await AddNewEmployee("2","add","33454");
        await DeleteEmployee(2);
        await AddMultipleEmployees();
       
    }



}