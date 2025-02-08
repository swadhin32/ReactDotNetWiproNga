using System;

namespace Csharp7and8Newfeatures_patternmatching
{

    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        public static void CheckEmployee(Employee employee)
        {
            // Matching properties of an object using pattern matching
            string result = employee switch
            {
                { Age: >= 30, FirstName: "Alice" } => "Alice is at least 30 years old.",
                { Age: < 30 } => "Employee is under 30 years old.",
                _ => "Other employee"
            };
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            object[] items = { "Hello", 42, 3.14, new Person("John", "Doe"), null };

            // i want to go or touch each elelement and do modiifcation to this element 
            //so using for loop i can do but for loop is there which will take only one 
            // type but i can use foreach loop and can use var but for each loop is 
            // read only loop 
            // so i can do patern matching here like this below code 

            foreach(var item in items)
            {
                //pattern matching using switch expression
                string result = item switch
                {
                    string s => $"String  is of length:{s.Length}:{s}",
                    int i => $"Integer: {i}",
                    double d=> $"Double : {d}",
                    Person p => $"Person :{p.FirstName} {p.LastName}",
                    null => "Null value",
                    _ => "Unknown type"
                };
                Console.WriteLine(result);
                
            }
            var employee = new Employee { FirstName = "Alice", LastName = "Smith", Age = 12 };
            CheckEmployee(employee);
            Console.ReadLine();
        }
    }
}
