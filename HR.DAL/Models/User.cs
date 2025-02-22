using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAL.Models
{
    public class User
    {
        
        public  int Id { get; }
        
        public required string Username { get; set; }
        public required string Password { get; set; }

        public virtual ICollection <Employee> Employees { get; set; }
      
    }
}
