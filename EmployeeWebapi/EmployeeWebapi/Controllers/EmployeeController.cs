using EmployeeWebapi.BuisnessLayer;
using EmployeeWebapi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeBLL _service;
        public EmployeeController(EmployeeBLL service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> getAllEmployees()
        {
            var employees = _service.GetAllEmployees();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> getEmployeeById(int id)
        {
            var employee = _service.GetEmployeeById(id);
            if(employee==null)
                return NotFound();
            return Ok(employee);
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee employee) {
            _service.AddEmployee(employee);
            return CreatedAtAction(nameof(getEmployeeById), new{ id=employee.Id }, employee);
        }

        [HttpPut("{id}")]
        
        public IActionResult updateEmployee(int id, [FromBody] Employee employee)
        {
            if (id != employee.Id)
            {
                return BadRequest("Mismatched Employee ID");
            }

            _service.UpdateEmployee(employee);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id) {
            _service.DeleteEmployee(id);
            return NoContent(); }

    }
}
