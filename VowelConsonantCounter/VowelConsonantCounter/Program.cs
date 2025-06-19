using System;

namespace VowelConsonantCounter
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Error: Input string is empty.");
                return;
            }

            if (ContainsNumbers(input))
            {
                Console.WriteLine("Error: Input string contains numbers, which is invalid.");
                return;
            }

            if (ContainsSpecialCharacters(input))
            {
                Console.WriteLine("Error: Input string contains special characters, which are invalid.");
                return;
            }

            int vowelCount = 0, consonantCount = 0;
            foreach (char c in input.ToLower())
            {
                if ("aeiou".Contains(c))
                {
                    vowelCount++;
                }
                else if (char.IsLetter(c))
                {
                    consonantCount++;
                }
            }

            Console.WriteLine($"Vowels: {vowelCount}");
            Console.WriteLine($"Consonants: {consonantCount}");
        }

        static bool ContainsNumbers(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        static bool ContainsSpecialCharacters(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)) 
                {
                    return true;
                }
            }
            return false;
        }
    }
}
