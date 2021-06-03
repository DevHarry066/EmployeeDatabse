using EmployeeDatabse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabse
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            EmployeeRepository employeeRepository = new EmployeeRepository();
            Employee e = new Employee();
            do
            {
                Console.WriteLine("\nEnter 1 for Add Employee");
                Console.WriteLine("Enter 2 for Get Employee Details");
                Console.WriteLine("Enter 3 for Get an Employee by Id");
                Console.WriteLine("Enter 4 to update an Employee");
                Console.WriteLine("Enter 5 to delete an Employee");
                Console.WriteLine("Press enter or 0 to Exit\n");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Employee Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Date Of Joining");
                        DateTime dateOfJoining = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter Employee Salary");
                        double salary = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter Department Name");
                        string depName = Console.ReadLine();
                        Employee e1 = new Employee(name, dateOfJoining, salary, depName);
                        employeeRepository.AddEmployee(e1);
                        //Employee er = ed.Add(e1);
                        Console.WriteLine("Employee Details added");
                        break;

                    case 2:
                        Console.WriteLine("Get All");
                        var employees = employeeRepository.GetAllEmployee();
                        Console.WriteLine("Available Employee Details");
                        foreach (var employee in employees)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Employee Id is " + employee.EmployeeId);
                            Console.WriteLine("Employee Name is " + employee.Name);
                            Console.WriteLine("Employee Date of Joining is " + employee.DateOfJoining);
                            Console.WriteLine("Employee Salary is " + employee.Salary);
                            Console.WriteLine("Employee Department Name is " + employee.DepartmentName);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter id to get info about Employee");
                        long id = Convert.ToInt64(Console.ReadLine());
                        var ee=employeeRepository.Get(id);
                        //var ee = ed.GetEmployeeById(id);
                        Console.WriteLine("\nEmployee Id is " + ee.EmployeeId);
                        Console.WriteLine("Employee Name is " + ee.Name);
                        Console.WriteLine("Employee Date of Joining is " + ee.DateOfJoining);
                        Console.WriteLine("Employee Salary is " + ee.Salary);
                        Console.WriteLine("Employee Department Name is " + ee.DepartmentName);
                        break;

                    case 4:
                        Console.WriteLine("Enter info about Employee to update");
                        Console.WriteLine("\nEnter Employee Id");
                        e.EmployeeId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name");
                        e.Name = Console.ReadLine();
                        Console.WriteLine("Enter Date Of Joining");
                        e.DateOfJoining = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter Employee Salary");
                        e.Salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Department Name");
                        e.DepartmentName = Console.ReadLine();
                        
                        Console.WriteLine("\nEnter Employee Id you want to update");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        employeeRepository.Update(e, id1);
                        Console.WriteLine("Employee Updated");
                        break;

                    case 5:
                        Console.WriteLine("\nEnter id of Employee you want to delete: ");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        employeeRepository.Delete(id2);
                        Console.WriteLine("Employee Deleted");
                        break;

                    default:
                        Console.WriteLine("Enter correct choice please\n");
                        break;
                }
                Console.WriteLine("Press 0 to exit");
                ch = Convert.ToInt32(Console.ReadLine());
            }
            while (ch != 0);
        }
    }
 }

