using HR.DAL.Models;
using HR.DAL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HR.API.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepo _employeeRepository;
       

        public EmployeeController(IEmployeeRepo employeeRepository)
        {
            _employeeRepository = employeeRepository;
            
        }

        [HttpPost("add")]
        public async Task <IActionResult> AddEmployee([FromBody]Employee employee)
        {
            try
            {
                await _employeeRepository.AddEmployee(employee.FirstName, employee.MiddleName, employee.LastName,
                    employee.Age, employee.Gender, employee.Address);
                return Ok("Employee has been added successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500,"error:" + ex.Message);
            }
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update (int id , [FromBody]Employee employee)
        {
            try
            {
                await _employeeRepository.UpdateEmployee(id, employee.FirstName, employee.MiddleName, employee.LastName, employee.Age, employee.Gender, employee.Address);
                return Ok("Employee updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode (500 , "Error: "+ ex.Message);
            }
        }




















    }
}
