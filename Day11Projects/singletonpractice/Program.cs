using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singletonpractice
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class EmployeeManager
    {

        private List<Employee> _employees;

        // Private constructor to prevent direct instantiation
        private EmployeeManager()
        {
            _employees = new List<Employee>();
            Console.WriteLine("EmployeeManager initialized.");
        }



        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
            Console.WriteLine($"Employee {employee.Name} added.");
        }

        public void ListEmployees()
        {
            Console.WriteLine("List of employees:");
            foreach (var emp in _employees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            EmployeeManager obj = new EmployeeManager();
            Console.ReadLine();
        }
    }
}
