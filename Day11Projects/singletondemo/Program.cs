namespace singletondemo;
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class EmployeeManager
{

    // Static variable to hold the single instance of EmployeeManager
    private static EmployeeManager _instance;


    private List<Employee> _employees;

    // Private constructor to prevent direct instantiation
    private EmployeeManager()
    {
        _employees = new List<Employee>();
        Console.WriteLine("EmployeeManager initialized.");
    }

    // Public static method to provide global access to the single instance
    public static EmployeeManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new EmployeeManager();
            }
            return _instance;
        }
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

        // Access the Singleton instance of EmployeeManager
        EmployeeManager manager1 = EmployeeManager.Instance;
        manager1.AddEmployee(new Employee { Id = 1, Name = "John Doe" });

        // Access the same Singleton instance of EmployeeManager from another variable
        EmployeeManager manager2 = EmployeeManager.Instance;
        manager2.AddEmployee(new Employee { Id = 2, Name = "Jane Smith" });

        // List employees using either reference (manager1 or manager2)
        manager1.ListEmployees();  // or manager2.ListEmployees()

        // Confirm that manager1 and manager2 are referencing the same instance
        Console.WriteLine(ReferenceEquals(manager1, manager2));  // This will print: True


        //  EmployeeManager obj = new EmployeeManager(); // this will givve error because constrcuotr is private 
      // if u dont want to get error here make constrcuotr public then it will work 
        Console.ReadLine();
    }
}
