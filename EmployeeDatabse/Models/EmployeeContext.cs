using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabse.Models
{
   public class EmployeeContext:DbContext
    {
        public EmployeeContext():base("name=EmployeeDBConnection")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
