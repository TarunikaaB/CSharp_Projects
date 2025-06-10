using System;

namespace GradeFeedbackApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a single letter grade (A, B, C, D, or F):");
            string input = Console.ReadLine().ToUpper();

            if (input.Length != 1 || !"ABCDF".Contains(input))
            {
                Console.WriteLine("Invalid grade entered.");
            }
            else
            {
                switch (input)
                {
                    case "A":
                        Console.WriteLine("Excellent");
                        break;
                    case "B":
                        Console.WriteLine("Good");
                        break;
                    case "C":
                        Console.WriteLine("Average");
                        break;
                    case "D":
                        Console.WriteLine("Below Average");
                        break;
                    case "F":
                        Console.WriteLine("Fail");
                        break;
                    default:
                        Console.WriteLine("Invalid grade entered.");
                        break;
                }
            }
        }
    }
}
