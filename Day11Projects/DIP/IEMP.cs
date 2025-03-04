using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP
{
    public interface IEMP
    {
        void AddEmployee(Employee employee);
        IEnumerable<Employee> GetAllEmployees();
    }
}