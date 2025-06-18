using System;

namespace MusicAcademyApp
{
    public class Program
    {
        public static void Main()
        {
            int[][] studentScores = new int[3][];
            studentScores[0] = new int[2];
            studentScores[1] = new int[3];
            studentScores[2] = new int[4];

            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    int score;
                    int attempts = 0;
                    while (true)
                    {
                        Console.Write($"Enter score for Student {i + 1}, Instrument {j + 1}: ");
                        string input = Console.ReadLine();
                        if (int.TryParse(input, out score) && score >= 0 && score <= 100)
                        {
                            studentScores[i][j] = score;
                            break;
                        }
                        else
                        {
                            attempts++;
                            if (attempts >= 3)
                            {
                                Console.WriteLine("Too many invalid attempts. Exiting...");
                                return;
                            }
                            Console.WriteLine("Invalid input. Please enter a valid score between 0 and 100.");
                        }
                    }
                }
            }

            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.Write($"Scores for Student {i + 1}: ");
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write($"Instrument {j + 1}: {studentScores[i][j]}");
                    if (j < studentScores[i].Length - 1)
                        Console.Write(", ");
                }
                Console.WriteLine();
            }
        }
    }
}
