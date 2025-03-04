using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que5
{
    public class ArrayAdvancedChallenges
    {
        // Function to find the majority element in an array (element appearing more than n/2 times)
        public static int? FindMajorityElement(int[] arr)
        {
            // Implement logic here
            return arr.GroupBy(x => x).Where(g => g.Count() > arr.Length/2).Select(g=>g.Key).FirstOrDefault();
        }
        // Function to find the smallest missing positive integer
        public static int FindSmallestMissingPositive(int[] arr)
        {
            // Implement logic here
            HashSet<int> set = new HashSet<int>(arr.Where(x => x > 0));
            int smallest = 1;
            while (set.Contains(smallest)) smallest++;
            return smallest;
        }
        // Function to find the kth largest element in the array
        public static int FindKthLargest(int[] arr, int k)
        {
            // Implement logic here
            return arr.OrderByDescending(x => x).ElementAt(k - 1);
        }
        // Function to check if the array contains a duplicate
        public static bool ContainsDuplicate(int[] arr)
        {
            // Implement logic here
            return arr.Length != arr.Distinct().Count();
        }
        // Main method for testing
        public static void Main(string[] args)
        {
            int[] testArray = { 3, 10, 10, 10, 4, 2, 10 };
            Console.WriteLine("Majority Element: " + FindMajorityElement(testArray));
            Console.WriteLine("Smallest Missing Positive: " + FindSmallestMissingPositive(testArray));
            Console.WriteLine("3rd Largest Element: " + FindKthLargest(testArray, 3));
            Console.WriteLine("Contains Duplicate: " + ContainsDuplicate(testArray));
        }
    }
}
