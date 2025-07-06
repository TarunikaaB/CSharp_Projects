using System;
using System.Text;

namespace CharacterCounterApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            if (string.IsNullOrEmpty(sentence))
            {
                Console.WriteLine("Error: The sentence cannot be null or empty.");
                return;
            }

            Console.WriteLine("Enter a character to count:");
            char character = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsWhiteSpace(character))
            {
                Console.WriteLine("Error: The character cannot be whitespace.");
                return;
            }

            StringBuilder sb = new StringBuilder(sentence);
            int count = 0;


         if (!string.IsNullOrEmpty(sentence) && !char.IsWhiteSpace(character))
            {
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == character)
                {
                    count++;
                }
            }
            }

            Console.WriteLine($"The character '{character}' occurs {count} times in the sentence.");
        }
    }
}
