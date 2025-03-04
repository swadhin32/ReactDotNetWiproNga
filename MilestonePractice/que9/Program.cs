using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que9
{
    public class AdvancedStringModification
    {
        // Function to insert a substring at every position where a specific character is found
        public static string InsertAfterCharacter(string input, char target, string toInsert)
        {
            return string.Concat(input.Select(c => c == target ? c + toInsert : c.ToString()));
        }

        // Function to remove the first n characters from a string
        public static string RemoveFirstNCharacters(string input, int n)
        {
            return input.Length > n ? input.Substring(n) : string.Empty;
        }

        // Function to replace all vowels in a string with a specified character
        public static string ReplaceVowels(string input, char replacement)
        {
            return new string(input.Select(c => "AEIOUaeioui".Contains(c)? replacement: c).ToArray());
        }

        // Function to reverse only the words in a sentence while preserving spaces
        public static string ReverseWords(string input)
        {
            // Implement logic here
            return string.Join(" ", input.Split(' ').Select(word => new string(word.Reverse().ToArray())));
        }
        // Main method for testing
        public static void Main(string[] args)
        {
            string testString = "hello world this is C#";
            Console.WriteLine("Insert After Character 'o': " + InsertAfterCharacter(testString, 'o', "-inserted"));
            Console.WriteLine("Remove First 5 Characters: " + RemoveFirstNCharacters(testString, 5));
            Console.WriteLine("Replace Vowels with '*': " + ReplaceVowels(testString, '*'));
            Console.WriteLine("Reverse Words: " + ReverseWords(testString));
        }
    }
}
