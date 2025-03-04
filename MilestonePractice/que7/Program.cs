using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que7
{
    public class AdvancedStringFunctions
    {
        // Function to find the longest substring without repeating characters
        public static string LongestUniqueSubstring(string input)
        {
            Dictionary<char, int> lastIndex = new Dictionary<char, int>();
            int start = 0, maxLength = 0, startIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (lastIndex.ContainsKey(input[i]) && lastIndex[input[i]] >= start)
                {
                    start = lastIndex[input[i]] + 1;
                }
                lastIndex[input[i]] = i;

                if (i - start + 1 > maxLength)
                {
                    maxLength = i - start + 1;
                    startIndex = start;
                }
            }
            return input.Substring(startIndex, maxLength);
        }
        // Function to check if two strings are anagrams
        public static bool AreAnagrams(string str1, string str2)
        {
            // Implement logic here
            return str1.OrderBy(x => x).SequenceEqual(str2.OrderBy(x => x));
        }
        // Function to capitalize the first letter of each word in a string
        public static string CapitalizeWords(string input)
        {
            // Implement logic here
            return string.Join(" ", input.Split(' ').Select(word => char.ToUpper(word[0]) + word.Substring(1)));
        }
        // Function to count the number of vowels and consonants in a string
        public static (int vowels, int consonants) CountVowelsAndConsonants(string input)
        {
            // Implement logic here
            string vowelsList = "AEIOUaeiou";
            int vowels = input.Count(c => vowelsList.Contains(c));
            int consonants = input.Count(c => !vowelsList.Contains(c) && char.IsLetter(c));
            return (vowels, consonants);
        }
        // Main method for testing
        public static void Main(string[] args)
        {
            string testString = "programming";
            string testString2 = "silenttkhh";
            Console.WriteLine("Longest Unique Substring: " + LongestUniqueSubstring(testString));
            Console.WriteLine("Are Anagrams: " + AreAnagrams(testString, testString2));
            Console.WriteLine("Capitalized Words: " + CapitalizeWords("hello world from csharp"));
            var counts = CountVowelsAndConsonants(testString);
            Console.WriteLine("Vowels: " + counts.vowels + ", Consonants: " + counts.consonants);
        }
    }
}
