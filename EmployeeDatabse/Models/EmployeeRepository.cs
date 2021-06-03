using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabse.Models
{
    public class EmployeeRepository
    {
        public EmployeeRepository()
        {

        }

        public void AddEmployee(Employee e1)
        {
            using (var context = new EmployeeContext())
            {

                context.Employees.Add(e1);
                context.SaveChanges();

            }
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            var context = new EmployeeContext();
            return context.Employees.ToList();

        }
        public Employee Get(long id)
        {
            var context = new EmployeeContext();
            return context.Employees.FirstOrDefault(e => e.EmployeeId == id);
            
        }
        

        public void Update(Employee employee, int id)
        {
            var context = new EmployeeContext();
            var c=context.Employees.Find(id);
            c.Name = employee.Name;
            c.DateOfJoining = employee.DateOfJoining;
            c.Salary = employee.Salary;
            c.DepartmentName = employee.DepartmentName;
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var context = new EmployeeContext();
            var d=context.Employees.Find(id);
            context.Employees.Remove(d);
            context.SaveChanges();
        }

    }
}
