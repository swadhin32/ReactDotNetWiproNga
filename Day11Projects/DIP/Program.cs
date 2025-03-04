namespace DIP;

class Program
{
    static void Main(string[] args)
    {
        IEMP employeeRepository = new EmpRespo();

        // Add employees directly via EmployeeRepository
        employeeRepository.AddEmployee(new Employee { Id = 1, Name = "John Doe" });
        employeeRepository.AddEmployee(new Employee { Id = 2, Name = "Jane Smith" });

        // List employees directly via EmployeeRepository
        Console.WriteLine("Employee List:");
        foreach (var employee in employeeRepository.GetAllEmployees())
        {
            Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}");
        }

        Console.ReadLine();



    }
}
