﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAL.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set;}
        [NotMapped]
        public string employeeId
        {
            get { return Id == 0 ? "00000" : Id.ToString().PadLeft(5 ,'0'); }
        }
        public string FirstName { get; set; }
        public string MiddleName  { get; set; }
        public string LastName  { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
    }
}
