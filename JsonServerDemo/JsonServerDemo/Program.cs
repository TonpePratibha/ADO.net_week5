using RestSharp;
using System.Data;

internal class Program
{
    private static readonly string BASE_URL = "http://localhost:3000";

    static async Task Main() {
       // string path = "C:\\Users\\Admin\\source\\repos\\JsonServerDemo\\JsonServerDemo\\demojson.json";
        // File.Create(path);
        Console.WriteLine("json server restsharp xample");

        await GetAllUsersAsync();
        await GetuserById(1);
        await AddUserAsync(new{ name="pratibha", email="p@gmail.com"});
        await DeleteById(1);
        await UpdateUser(3, new { name = "abc", email = "abc@gmail.com" });
    }

    public static async Task GetAllUsersAsync() {   //task is used for async await programming ,thread based
    var client=new RestClient(BASE_URL);   //creates restclient at given url
        var request=new RestRequest("users",Method.Get);   //request fro client
        var response=await client.ExecuteAsync(request); //it will store response from request
        Console.WriteLine("users list");
        Console.WriteLine(response.Content);  //print data fro file

    }
        //if everything is good i code stil not getting output then run h=jsonserver againn using npx json-server --watch filename
    public static async Task GetuserById(int id) {
        var client = new RestClient(BASE_URL);
        var request = new RestRequest($"users/{id}", Method.Get);
        var response = await client.ExecuteAsync(request);
        Console.WriteLine($"{id} ,{response.Content}");
        //Console.WriteLine(response.Content);
    }
    private static async Task AddUserAsync(object newUser) { 
      var client = new RestClient(BASE_URL);
        var request = new RestRequest("users", Method.Post);
        request.AddJsonBody(newUser);

        var response=await client.ExecuteAsync(request);
        Console.WriteLine("user added");
        Console.WriteLine(response.Content);
    }

    public static async Task UpdateUser(int id,object newuser) { 
    var client =new RestClient(BASE_URL);
        var request = new RestRequest($"users/{id}",Method.Put);
        request.AddJsonBody(newuser);
        var response=await client.ExecuteAsync(request);
        Console.WriteLine(response.Content);

    }

    public static async Task DeleteById(int id) { 
    

        var client=new RestClient(BASE_URL);
        var request=new RestRequest($"users/{id}", Method.Delete);
       var response=await client.ExecuteAsync(request);
        Console.WriteLine("deleted user");
       

    }
   
}