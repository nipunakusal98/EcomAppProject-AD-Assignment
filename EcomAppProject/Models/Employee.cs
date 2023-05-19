
using EcomAppProject.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace EcomAppProject.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePassword { get; set; } 
        public EmployeeType EmployeeType { get; set; }
    }
}
