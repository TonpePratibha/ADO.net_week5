using EmployeeWebapi.Entities;

namespace EmployeeWebapi.DataAccessLayer
{
    public interface EmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
    }
}
