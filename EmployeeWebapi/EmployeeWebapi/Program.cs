using EmployeeWebapi.BuisnessLayer;
using EmployeeWebapi.DataAccessLayer;
using EmployeeWebapi.dbcontext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<EmployeeRepository, EmployeeDAL>();
builder.Services.AddScoped<EmployeeBLL>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

try
{
    app.Run();
}
catch (Exception ex)
{
    Console.WriteLine($"Error starting the app: {ex.Message}");
}


