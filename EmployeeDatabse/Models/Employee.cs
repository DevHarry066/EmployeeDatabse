using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabse.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public double Salary { get; set; }
        public string DepartmentName { get; set; }

        public Employee()
        {
                
        }
        public Employee(string name,DateTime date,double salary,string dept)
        {
            this.Name = name;
            this.DateOfJoining = date;
            this.Salary = salary;
            this.DepartmentName = dept;
        }
    }
}
