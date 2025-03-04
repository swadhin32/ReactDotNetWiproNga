using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Input 1: Main String
        string mainString = GetInput("Enter the main tring:");
        // Input 2: Substring
        string substring = GetInput("Enter the substring to chec:");
        // Input 3: Character to be replaced
        char charToReplace = GetInput("Enter the character to replace:")[0];
        // Input 4: Character to replace with
        char replacementChar = GetInput("Enter the replacement character:")[0];

        bool substringExists = CheckSubstringExists(mainString, substring);
        string replacedString = ReplaceCharacter(mainString, charToReplace, replacementChar);
        string caseSwapped = SwapCase(mainString);
        string noSpaces = RemoveWhitespace(mainString);
        Dictionary<char, int> letterCount = CountLetters(mainString);

        Console.WriteLine($"Substring Exists: {(substringExists ? "Yes" : "No")}");
        Console.WriteLine($"Replaced: {replacedString}");
        Console.WriteLine($"Case Swapped: {caseSwapped}");
        Console.WriteLine($"No Spaces: {noSpaces}");
        Console.WriteLine($"Letter Count: {string.Join(", ", letterCount.Select(kvp => $"{kvp.Key}: {kvp.Value}"))}");
    }

    static string GetInput(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }

    static bool CheckSubstringExists(string main, string sub)
    {
        return main.Contains(sub);
    }

    static string ReplaceCharacter(string input, char oldChar, char newChar)
    {
        return input.Replace(oldChar, newChar);
    }

    static string SwapCase(string input)
    {
        return new string(input.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)) : c).ToArray());
    }

    static string RemoveWhitespace(string input)
    {
        return string.Concat(input.Where(c => !char.IsWhiteSpace(c)));
    }

    static Dictionary<char, int> CountLetters(string input)
    {
        Dictionary<char, int> letterCounts = new Dictionary<char, int>();
        foreach (char c in input.ToLower())
        {
            if (char.IsLetter(c))
            {
                if (letterCounts.ContainsKey(c))
                    letterCounts[c]++;
                else
                    letterCounts[c] = 1;
            }
        }
        return letterCounts;
    }
}
