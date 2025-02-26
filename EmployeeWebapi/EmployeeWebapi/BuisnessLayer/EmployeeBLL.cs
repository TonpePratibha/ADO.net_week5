using EmployeeWebapi.DataAccessLayer;
using EmployeeWebapi.Entities;

namespace EmployeeWebapi.BuisnessLayer
{
    public class EmployeeBLL
    {
        private readonly EmployeeRepository _repository;

        public EmployeeBLL(EmployeeRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }




        public IEnumerable<Employee> GetAllEmployees() { 
        return _repository.GetAllEmployees();
        }


        public Employee GetEmployeeById(int id)
        {
            return _repository.GetEmployeeById(id);
        }

        public void AddEmployee(Employee employee) { 
        _repository.AddEmployee(employee);
        }
        
        public void UpdateEmployee(Employee employee)
        {
            if (employee == null || employee.Id == 0)
            {
                throw new ArgumentException("Invalid employee data");
            }

            _repository.UpdateEmployee(employee);
        }


        public void DeleteEmployee(int id)
        {
            _repository.DeleteEmployee(id);
        }
    }
}
