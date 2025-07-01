using System;
using System.Linq;
using System.Collections.Generic;

namespace MostFrequentCharacterApp
{
    public class Program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input string cannot be null or empty.");
                return;
            }

            if (input.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid input: string contains numbers.");
                return;
            }

            var charCounts = new Dictionary<char, int>();
            foreach (char c in input.ToLower().Where(c => !char.IsWhiteSpace(c)))
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                }
            }

            var maxCount = charCounts.Values.Max();
            var mostFrequentChars = charCounts.Where(kvp => kvp.Value == maxCount).Select(kvp => kvp.Key).ToList();

            if (mostFrequentChars.Count > 1)
            {
                Console.WriteLine("There are multiple characters with the highest frequency.");
            }
            else
            {
                Console.WriteLine($"The most frequent character is: {mostFrequentChars.First()}");
            }
        }
    }
}
