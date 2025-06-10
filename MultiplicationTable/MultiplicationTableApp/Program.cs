using System;

namespace MultiplicationTable
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
    }
}
