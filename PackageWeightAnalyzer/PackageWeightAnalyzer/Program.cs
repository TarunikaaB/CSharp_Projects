using System;

namespace PackageWeightAnalyzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of packages: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be null or empty.");
                return;
            }

            if (!int.TryParse(input, out int n) || n <= 0)
            {
                Console.WriteLine("Number of packages should be a positive integer.");
                return;
            }

            double[] weights = new double[n];
            Console.WriteLine("Enter the weights of the packages: ");
            for (int i = 0; i < n; i++)
            {
                string weightInput = Console.ReadLine();
                if (string.IsNullOrEmpty(weightInput) || !double.TryParse(weightInput, out double weight))
                {
                    Console.WriteLine("Invalid weight input. Please enter a valid number.");
                    return;
                }
                weights[i] = weight;
            }

            double maxWeight = weights[0];
            double minWeight = weights[0];

            for (int i = 1; i < n; i++)
            {
                if (weights[i] > maxWeight)
                {
                    maxWeight = weights[i];
                }
                if (weights[i] < minWeight)
                {
                    minWeight = weights[i];
                }
            }

            Console.WriteLine($"Maximum weight: {maxWeight}");
            Console.WriteLine($"Minimum weight: {minWeight}");
        }
    }
}
