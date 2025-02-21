﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAL.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set;}
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName  { get; set; }
        public string LastName  { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
    }
}
