using HR.DAL.Data;
using HR.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAL.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {

        private readonly AppDbContext _context;
        public EmployeeRepo(AppDbContext context)
        {
              _context = context;   
        }
        public async Task AddEmployee(string firstName, string middleName, string lastName, int age, char gender, string address)
        {
            try
            {
                var employee = new Employee { FirstName = firstName, MiddleName = middleName, LastName = lastName, Age = age, Gender = gender, Address = address };
                _context.Employees.Add(employee);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception ("Error while adding employee" + ex.Message, ex);
            }
        }

        public async Task DeleteEmployee(int id)
        {
            try
            {
                var employee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
                if (employee != null)
                {
                    _context.Employees.Remove(employee);
                    await _context.SaveChangesAsync();
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Error while deleting employee" + ex.Message);
            }
            }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            try
            {
                return await _context.Employees.ToListAsync();
            }
            catch(Exception ex)
            {
                throw new Exception("error getting all employees:" + ex.Message);
            }
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            try
            {
                return await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception("error while getting employee:" + ex.Message);
            }
        }

        public async Task UpdateEmployee(int id, string firstName, string middleName, string lastName, int age, char gender, string address)
        {
            try
            {
                var employee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
                if (employee != null)
                {
                    employee.FirstName = firstName;
                    employee.MiddleName = middleName;
                    employee.LastName = lastName;
                    employee.Age = age;
                    employee.Gender = gender;
                    employee.Address = address;
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex) 
            { 
                throw new Exception("error while updating"+ ex.Message);
            }
        }
    }

       

    






    }

