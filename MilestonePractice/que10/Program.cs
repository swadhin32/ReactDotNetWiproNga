using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que10
{
    public class ComplexStringModification
    {
        // Function to insert a sequence of characters in between each character of the string
        public static string InsertBetweenCharacters(string input, string toInsert)
        {
            // Implement logic here
            return string.Empty;
        }
        // Function to remove all duplicate characters from a string
        public static string RemoveDuplicates(string input)
        {
            // Implement logic here
            return string.Empty;
        }
        // Function to replace the last occurrence of a substring with another substring
        public static string ReplaceLastOccurrence(string input, string toReplace, string replacement)
        {
            // Implement logic here
            return string.Empty;
        }
        // Function to modify a string by keeping only unique words
        public static string KeepUniqueWords(string input)
        {
            // Implement logic here
            return string.Empty;
        }
        // Main method for testing
        public static void Main(string[] args)
        {
            string testString = "hello world hello universe";
            Console.WriteLine("Insert Between Characters: " + InsertBetweenCharacters(testString, "-"));
            Console.WriteLine("Remove Duplicates: " + RemoveDuplicates(testString));
            Console.WriteLine("Replace Last Occurrence of 'hello': " + ReplaceLastOccurrence(testString, "hello", "hi"));
            Console.WriteLine("Keep Unique Words: " + KeepUniqueWords(testString));
        }
    }
}
