using System;
using System.ComponentModel.DataAnnotations;

namespace HR.DAL.Models
{
    public class EmployeeDto
    {
        public int Id { get; set; }
       
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public int UserId { get; set; }
    }
}
