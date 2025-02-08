namespace cSharp7and8Newfeatures_expressionbodieddemo
{
    internal class Program
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // Constructor
            public Person(string firstName, string lastName)=>(FirstName,LastName)=(firstName,lastName);
           

            // Method
            public string GetFullName()=>$"{FirstName} {LastName}";
            

            // Read-only property
            public string FullName=>$"{FirstName}   {LastName}";
            
            // Finalizer (destructor)
            ~Person() => Console.WriteLine("Person object is being destroyed.");
          

            public static void add(int a, int b) => Console.WriteLine($"The sum is {a + b}");
          
        }
        static void Main(string[] args)
        {
            // Create a new person using expression-bodied constructor
            // Create a new person using expression-bodied constructor
            var person = new Person("John", "Doe");

            // Using expression-bodied method
            Console.WriteLine($"Full Name (method): {person.GetFullName()}");

            // Using expression-bodied property
            Console.WriteLine($"Full Name (property): {person.FullName}");

            Person.add(12, 45);

            // Destructor will run at the end when the program terminates
        }
    }
}
