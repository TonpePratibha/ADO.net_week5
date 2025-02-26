using EmployeeWebapi.dbcontext;
using EmployeeWebapi.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebapi.DataAccessLayer
{
    public class EmployeeDAL:EmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeDAL(ApplicationDbContext context) {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
            public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
           return _context.Employees.Find(id);
        }

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            var existingEmployee = _context.Employees.Find(employee.Id);
            if (existingEmployee == null)
            {
                throw new InvalidOperationException("Employee not found");
            }

            _context.Entry(existingEmployee).CurrentValues.SetValues(employee);
            _context.SaveChanges();
        }


        public void DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee != null)
            { 
            _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }

        

    }
}
