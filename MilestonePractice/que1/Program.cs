using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements of the array separated by spaces:");
            string[] inputArray = Console.ReadLine().Split(' ');

            string concatenatedString = string.Join("", inputArray);
            Console.WriteLine($"{concatenatedString}");

            List<int> extractedNumber = new List<int>();
            string currentNumber = "";

            foreach (char c in concatenatedString)
            {
                if (char.IsDigit(c))
                {
                    currentNumber += c;
                }
                else if (currentNumber.Length >0)
                {
                    extractedNumber.Add(int.Parse(currentNumber));
                    currentNumber = "";
                }
            }

            if (currentNumber.Length > 0)
            {
                extractedNumber.Add(int.Parse(currentNumber));
            }

            Console.WriteLine("Extracted Numbers: " + string.Join(" ", extractedNumber));

            if (extractedNumber.Count > 0)
            {
                int maximumNumber = extractedNumber.Max();
                int minimumNumber = extractedNumber.Min();

                Console.WriteLine($"Maximum Number: {maximumNumber}");
                Console.WriteLine($"Minimum Number: {minimumNumber}");
                Console.WriteLine($"Difference: {maximumNumber - minimumNumber}");
            }
            else
            {
                Console.WriteLine("Maximum Number: 0");
                Console.WriteLine("Minimum Number: 0");
                Console.WriteLine("Difference: 0");
            }

        }
    }
}
