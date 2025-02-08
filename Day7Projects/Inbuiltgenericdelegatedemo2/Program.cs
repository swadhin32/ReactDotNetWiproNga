using System;
using System.Collections.Generic;

namespace Inbuiltgenericdelegatedemo2
{
    internal class Program
    {

        //public bool findeven(int number)
        //{
        //    if(number%2==0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        static void Main(string[] args)
        {
            // Func example: Takes two integers and returns their sum
            Func<int, int, int> sumFunc = (a, b) => a + b;
            int result = sumFunc(5, 10);
            Console.WriteLine($"Sum using Func: {result}");  // Output: 15

            // Action example: Takes a string and prints a message
            Action<string> printMessage = (message) => Console.WriteLine($"Message using Action: {message}");
            printMessage("Hello from Action!");

            // Predicate example: Checks if a number is even
            Predicate<int> isEven = (number) =>
            {
                if (number % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            // Use Predicate with List.FindAll to find all even numbers

            List<int> evenNumbers = numbers.FindAll(isEven);
            Console.WriteLine("Even numbers using Predicate: " + string.Join(", ", evenNumbers));
            Console.ReadLine();
        }
    }
}
