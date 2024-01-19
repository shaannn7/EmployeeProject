using EmployeeProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employee;

        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }

        [HttpGet("All Employees")]
        public IActionResult GetAllEmployees() 
        {
            return Ok(_employee.GetAllEmployee());
        }

        [HttpGet("Employees By Id")]
        public IActionResult GetByID(int id) 
        {
            return Ok(_employee.GetEmployeeById(id));
        }
        [HttpGet("Employees By Name")]
        public IActionResult GetByName(string name)
        {
            return Ok(_employee.GetEmployeeByName(name));
        }

        [HttpPost("Add Employee")]
        public IActionResult AddEmployeee([FromBody]Employee employee)
        {
            _employee.AddEmployee(employee);
           return Ok();
        }

        [HttpPut("Update Employees")]
        public IActionResult UpdateEmp(int id ,Employee employee)
        {
            _employee.UpdateEmployee(id, employee);
            return Ok();
        }

        [HttpDelete("Delete Employee")]
        public IActionResult DeleteEmployeee(int id)
        {
            _employee.DeleteEmployee(id);
            return Ok();
        }
    }
}
