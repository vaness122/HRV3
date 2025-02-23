using HR.DAL.Models;
using HR.DAL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HR.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo _employeeRepository;
       

        public EmployeeController(IEmployeeRepo employeeRepository)
        {
            _employeeRepository = employeeRepository;
            
        }

        // POST api/Employee/add
        [HttpPost("add")]
        public async Task<IActionResult> AddEmployee([FromBody] EmployeeDto employee)
        {
            try
            {
                await _employeeRepository.AddEmployee(employee.FirstName, employee.MiddleName, employee.LastName, employee.Age, employee.Gender, employee.Address ,employee.UserId);
                return Ok("Employee has been added successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error: " + ex.Message);
            }
        }

        // PUT api/Employee/update/5
        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] EmployeeDto employee)
        {
            try
            {
                await _employeeRepository.UpdateEmployee(id, employee.FirstName, employee.MiddleName, employee.LastName, employee.Age, employee.Gender, employee.Address);
                return Ok("Employee updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error: " + ex.Message);
            }
        }

        // DELETE api/Employee/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _employeeRepository.DeleteEmployee(id);
                return Ok("Employee deleted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error: " + ex.Message);
            }
        }

        // GET api/Employee/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            try
            {
                var employee = await _employeeRepository.GetEmployeeById(id);
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error: " + ex.Message);
            }
        }

        // GET api/Employee
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            try
            {
                var employees = await _employeeRepository.GetAllEmployeesAsync();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error: " + ex.Message);
            }
        }
    }
}
