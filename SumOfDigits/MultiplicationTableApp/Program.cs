using System;

namespace SumOfDigits {
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a positive integer:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number > 0)
        {
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;

                // Skip processing if digit is zero
                if (digit == 0)
                {
                    number /= 10;
                    continue;
                }

                sum += digit;
                number /= 10;
            }

            Console.WriteLine($"The sum of digits is: {sum}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }
}
}
