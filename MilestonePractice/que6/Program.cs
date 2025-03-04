using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que6
{
    public class StringFunctions
    {
        // Function to reverse a string
        public static string ReverseString(string input)
        {
            return string.Join("",input.Reverse().ToArray());
            // return new string(input.Reverse().ToArray());   // same syntax
        }

        // Function to check if a string is a palindrome
        public static bool IsPalindrome(string input)
        {
            return input.Equals(new string(input.Reverse().ToArray()));
        }

        // Function to count the frequency of each character in a string
        public static void CharacterFrequency(string input)
        {
            var frequency = input.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            foreach (var kvp in frequency) Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        // Function to find the first non-repeating character in a string
        public static char? FirstNonRepeatingCharacter(string input)
        {
            var characterCounts = input.GroupBy(c => c)
                                    .ToDictionary(g => g.Key, g => g.Count());

            return input.FirstOrDefault(c => characterCounts[c] == 1);
        }
        // Main method for testing
        public static void Main(string[] args)
        {
            string testString = "civic";
            Console.WriteLine("Reversed String: " + ReverseString(testString));
            Console.WriteLine("Is Palindrome: " + IsPalindrome(testString));
            Console.WriteLine("Character Frequency:");
            CharacterFrequency(testString);
            Console.WriteLine("First Non-Repeating Character: " + FirstNonRepeatingCharacter(testString));
        }
    }
}
