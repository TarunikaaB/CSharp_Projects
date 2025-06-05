using System;

namespace SwapIntegers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before swapping: First value = {a}, Second value = {b}");

            Swap(ref a, ref b);

            Console.WriteLine($"After swapping: First value = {a}, Second value = {b}");
        }

        public static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
