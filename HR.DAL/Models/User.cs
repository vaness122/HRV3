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
        //public string userId { get { return Id==0? "00000" : Id.ToString().PadLeft(5); } }
        public required string Username { get; set; }
        public required string Password { get; set; }
      
    }
}
