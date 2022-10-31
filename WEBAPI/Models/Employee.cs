using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeFname { get; set; }
        public string EmployeeLname { get; set; }
        public decimal EmployeeSalary { get; set; }
    }
}
