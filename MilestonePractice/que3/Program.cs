using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que3
{
    public class ArrayOperations
    {
        // Function to calculate the median of an array
        public static double CalculateMedian(int[] arr)
        {
            int[] sortedArr = arr.OrderBy(x => x).ToArray();
            int n = sortedArr.Length;
            if (n % 2 == 0)
                return (sortedArr[n / 2 - 1] + sortedArr[n / 2]) / 2.0;
            else
                return sortedArr[n / 2];
        }
        // Function to find the second largest element in an array
        public static int FindSecondLargest(int[] arr)
        {
            int max = arr.Max(); // Find the largest number
            return arr.Where(c => c != max).Max();
        }
        // Function to check if an array is a palindrome
        public static bool IsPalindrome(int[] arr)
        {
            // Implement logic here
            string input = string.Join("", arr);
            string input2 = string.Join("", arr.Reverse());
            if (input.Equals(input2))
            {
                return true;
            }
            else
                return false;
        }
        // Function to rotate the array to the left by a given number of steps
        public static int[] RotateLeft(int[] arr, int steps)
        {
            int n = arr.Length;
            steps %= n;
            int[] rotatedArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                rotatedArr[i] = arr[(i + steps) % n];
            }
            return rotatedArr;
        }
        // Main method for testing
        public static void Main(string[] args)
        {
            int[] testArray = { 5, 1, 4, 5, 10 };
            Console.WriteLine("Median: " + CalculateMedian(testArray));
            Console.WriteLine("Second Largest: " + FindSecondLargest(testArray));
            Console.WriteLine("Is Palindrome: " + IsPalindrome(testArray));
            int[] rotatedArray = RotateLeft(testArray, 4);
            Console.WriteLine("Rotated Array: " + string.Join(", ", rotatedArray));
        }
    }
}
