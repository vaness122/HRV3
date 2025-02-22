using HR.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAL.Repository
{
    public interface IEmployeeRepo
    {
        Task AddEmployee (string firstName, string middleName, string lastName,
            int age , string gender, string address);
        Task UpdateEmployee(int id, string firstName , string middleName, string lastName,
            int age,string gender ,string address);
        Task DeleteEmployee(int id);
        Task <Employee> GetEmployeeById(int id);
        Task<List<Employee>> GetAllEmployeesAsync();
    }
}
