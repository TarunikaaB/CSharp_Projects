using System;

namespace MatrixApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int attempts = 0;
                    while (true)
                    {
                        if (attempts >= 3)
                        {
                            Console.WriteLine("Error: Too many invalid attempts.");
                            return;
                        }

                        Console.Write($"Enter value for matrix[{i}][{j}]: ");
                        string input = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine("Error: Input cannot be empty or whitespace.");
                        }
                        else if (!int.TryParse(input, out int value))
                        {
                            Console.WriteLine("Error: Input must be a valid integer.");
                        }
                        else
                        {
                            matrix[i, j] = value;
                            break;
                        }
                        attempts++;
                    }
                }
            }

            // Display the matrix
            Console.WriteLine("Matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
