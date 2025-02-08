namespace CSharp7And8newfeatures_Localfunctions
{
    internal class Program
    {

        public static int CalculateFactorial(int number)
        {
            // Local function to calculate factorial recursively
            int Factorial(int n)
            {
                if (n <= 1)
                    return 1;
                return n * Factorial(n - 1); // Recursion
            }

            return Factorial(number); // Call the local function
        }

        // A method demonstrating a local function that captures variables from the outer scope
        public static int CalculateSumWithLocalFunction(int x, int y)
        {
            // Local function capturing outer variables
            int Add()
            {
                return x + y; // x and y are captured from the outer method
            }

            return Add(); // Call the local function
        }
        static void Main(string[] args)
        {

            //functions which are present insdie another function means with body they 
            //are present and taking the values of parent function and inside the parent only i 
            // am giving a call if u give call then only it is called 
            Console.WriteLine("Starting the demo of local functions.");

            // Call the method that uses local functions
            int result = CalculateFactorial(5);
            Console.WriteLine($"Factorial of 5 is: {result}");

            // Call the method that demonstrates capturing variables from the outer scope
            int sum = CalculateSumWithLocalFunction(3, 4);
            Console.WriteLine($"Sum of 3 and 4 is: {sum}");



            Console.WriteLine("End of demo.");
            Console.ReadLine();
        }
    }
}
