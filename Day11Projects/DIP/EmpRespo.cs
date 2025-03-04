using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP
{
    public class EmpRespo : IEMP
    {
        // In-memory list to store employees
        private readonly List<Employee> _employees = new List<Employee>();

        // Method to add an employee to the collection
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
            Console.WriteLine($"Employee {employee.Name} added.");
        }

        // Method to list all employees
        public  IEnumerable<Employee> GetAllEmployees()
        {
            return _employees;
        }
    }
}