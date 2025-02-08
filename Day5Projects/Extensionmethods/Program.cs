using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensionmethods
{

    public static class StringExtensions
    {
        // Extension method to check if a string is a palindrome
        public static bool IsPalindrome(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            int i = 0;
            int j = str.Length - 1;

            while (i < j)
            {
                if (str[i] != str[j])
                    return false;
                i++;
                j--;
            }

            return true;
        }
    }
    public static class IntExtensions
    {
        // Extension method to check if an integer is odd
        public static bool IsOdd(this int number)
        {
            // A number is odd if it is not divisible by 2
            return number % 2 != 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string example1 = "madam";
            string example2 = "hello";

            string k;
            

            // Using the extension method as if it were an instance method
            Console.WriteLine(example1.IsPalindrome()); // Output: True
            Console.WriteLine(example2.IsPalindrome()); // Output: False

            int number1 = 5;
            int number2 = 8;

            // Using the extension method IsOdd on integers
            Console.WriteLine($"{number1} is odd: {number1.IsOdd()}"); // Output: 5 is odd: True
            Console.WriteLine($"{number2} is odd: {number2.IsOdd()}"); // Output: 8 is odd: False

        }
    }
}
