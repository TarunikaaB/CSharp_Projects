using System;
using System.Text;

namespace SentenceModifierApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence:");
            string sentence = Console.ReadLine();

            Console.WriteLine("Enter the word to replace:");
            string oldWord = Console.ReadLine();

            Console.WriteLine("Enter the new word:");
            string newWord = Console.ReadLine();

           if (string.IsNullOrWhiteSpace(sentence) || string.IsNullOrWhiteSpace(oldWord) || string.IsNullOrWhiteSpace(newWord))
            {
                Console.WriteLine("Error: Arguments cannot be null, empty, or whitespace");
            }
            else
            {
                StringBuilder sb = new StringBuilder(sentence);
                sb.Replace(oldWord, newWord);
                string modifiedSentence = sb.ToString();
                Console.WriteLine("Modified Sentence: " + modifiedSentence);
            }
        }
    }
}
