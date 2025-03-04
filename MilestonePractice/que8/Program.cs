using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que8
{
    public class StringModification
    {
        // Function to insert a character at every nth position in a string
        public static string InsertAtEveryNthPosition(string input, char toInsert, int n)
        {
            // Implement logic here
            return string.Concat(input.Select((c, i) => (i + 1) % n == 0 ? c.ToString() + toInsert : c.ToString()));
        }
        // Function to remove every occurrence of a specific character from a string
        public static string RemoveAllOccurrences(string input, char toRemove)
        {
            // return input.Replace(toRemove.ToString(), "");
            return string.Join("",input.Split(toRemove));
        }
        // Function to replace the nth occurrence of a substring with another substring
        public static string ReplaceNthOccurrence(string input, string toReplace, string replacement, int n)
        {
            int count = 0;
            int index = -1;

            while ((index = input.IndexOf(toReplace, index + 1)) != -1)
            {
                count++;
                if (count == n)
                {
                    return input.Substring(0, index) + replacement + input.Substring(index + toReplace.Length);
                }
            }
            return input;
        }
        // Function to modify a string by removing all characters after a specific index
        public static string RemoveAfterIndex(string input, int index)
        {
            //return new string(input.Select((x, i) => i < index+1 ? x: '#').Where(x => x!= '#').ToArray());
            return index < input.Length ? input.Substring(0, index) : input;
        }
        // Main method for testing
        public static void Main(string[] args)
        {
            string testString = "hello-world-hello-world";
            Console.WriteLine("Insert at Every 3rd Position: " + InsertAtEveryNthPosition(testString, '*', 3));
            Console.WriteLine("Remove All Occurrences of '-': " + RemoveAllOccurrences(testString, '-'));
            Console.WriteLine("Replace 2nd Occurrence of 'world': " + ReplaceNthOccurrence(testString, "world", "C#", 2));
            Console.WriteLine("Remove After Index 10: " + RemoveAfterIndex(testString, 10));
        }
    }
}
