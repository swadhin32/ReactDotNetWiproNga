using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que4
{
    public class AdvancedArrayOperations
    {
        // Function to find all unique elements in an array
        public static int[] FindUniqueElements(int[] arr)
        {
            return arr.GroupBy(x => x).Where(g => g.Count() == 1).Select(g => g.Key).ToArray();
        }

        // Function to find the intersection of two arrays
        public static int[] FindIntersection(int[] arr1, int[] arr2)
        {
            return arr1.Intersect(arr2).ToArray();
        }

        // Function to merge two arrays and remove duplicates
        public static int[] MergeAndRemoveDuplicates(int[] arr1, int[] arr2)
        {
            return arr1.Concat(arr2).Distinct().ToArray();
        }

        // Function to find the longest increasing subsequence in an array
        public static int[] LongestIncreasingSubsequence(int[] arr)
        {
            List<int> lis = new List<int>();
            foreach (int num in arr)
            {
                int index = lis.BinarySearch(num);
                if (index < 0)
                {
                    index = ~index;
                    if (index == lis.Count)
                        lis.Add(num);
                    else
                        lis[index] = num;
                }
            }
            return lis.ToArray();
        }
        // Main method for testing
        public static void Main(string[] args)
        {
            int[] array1 = { 4,2,1,4,3,4,5,8,15 };
            int[] array2 = { 2, 3, 6, 7, 5 };
            Console.WriteLine("Unique Elements: " + string.Join(", ", FindUniqueElements(array1)));
            Console.WriteLine("Intersection: " + string.Join(", ", FindIntersection(array1, array2)));
            Console.WriteLine("Merged Without Duplicates: " + string.Join(", ", MergeAndRemoveDuplicates(array1, array2)));
            Console.WriteLine("Longest Increasing Subsequence: " + string.Join(", ", LongestIncreasingSubsequence(array1)));
        }
    }
}
