using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Webapidemo.Controllers
{

    public class Employee
    {

        public int? Id { set; get; }

        public string? Name { set; get; }

        public string  Place { set; get; } = string.Empty;
    }

    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {

        private static List<Employee> emps = new List<Employee>()
            {
                new Employee{Id=1,Name="kiran",Place="bangalore"},
                 new Employee{Id=2,Name="sita",Place="chennai"},
                  new Employee{Id=3,Name="mohan",Place="Hyderabad"},
            };

        [HttpGet]
        public List<Employee> Employees()
        {
            
            return emps;
        }

        [HttpGet("Emp2")]
        public List<Employee> Employees2()
        {
           
            return emps;
        }

        [HttpPost]
        public Employee AddEmployee(Employee emp1)
        {
            emps.Add(emp1);
            return emp1;
        }

        [HttpPost("emppost2")]// same add but after adding returning list of employees
        public List<Employee> AddEmployee2(Employee emp1)
        {
            emps.Add(emp1);
            return emps;
        }

        [HttpPut]
        public Employee UpdateEmployee(Employee emp1)
        {
            var employee1=emps.Find(x=>x.Id==emp1.Id);
            if (employee1 == null)
            {
                return new Employee { Name = "Error", Place = "Employee not found" }; // Returning an Employee object with a message
            }
            employee1.Name = emp1.Name;
            employee1.Place=emp1.Place;
            return employee1;
                 
        }
        [HttpPut("empput2")]
        public List<Employee> UpdateEmployee2(Employee emp1)
        {
            var employee1 = emps.Find(x => x.Id == emp1.Id);
            if (employee1 == null)
            {
                // Return a list with a single Employee object containing the error message
                return new List<Employee>
                {
                    new Employee { Name = "Error", Place = "Employee not found" }
                };
            }
            employee1.Name = emp1.Name;
            employee1.Place = emp1.Place;
            return emps;

        }
        [HttpDelete]
        public Employee DeleteEmployee(int id)
        {
            var employee1 = emps.Find(x => x.Id == id);
            if (employee1 == null)
            {
                return new Employee { Name = "Error", Place = "Employee not found" }; // Returning an Employee object with a message
            }

            emps.Remove(employee1);
            return employee1;

        }

        [HttpDelete("empdelete2")]
        public List<Employee> DeleteEmployee2(int id)
        {
            var employee1 = emps.Find(x => x.Id == id);
            if (employee1 == null)
            {
                // Return a list with a single Employee object containing the error message
                return new List<Employee>
                {
                    new Employee { Name = "Error", Place = "Employee not found" }
                };
            }


            emps.Remove(employee1);
            return emps;

        }

        [HttpGet("{id}")]
        public Employee GetEmployees(int id)
        {
            var employee1 = emps.Find(x => x.Id == id);
            if (employee1 == null)
            {
                return new Employee { Name = "Error", Place = "Employee not found" }; // Returning an Employee object with a message
            }

            return employee1;

        }


    }
}
