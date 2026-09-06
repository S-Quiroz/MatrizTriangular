using System;

namespace Matrices.Common
{
    public static class ConsoleExtensions
    {
        public static int ReadInt(string prompt, Func<int, bool>? validator = null)
        {
            while (true)
            {
                Console.Write(prompt);
                string? line = Console.ReadLine();
                if (int.TryParse(line, out int value) && (validator == null || validator(value)))
                    return value;

                Console.WriteLine("Entrada inválida. Intente de nuevo.");
            }
        }

        public static void WriteMatrix(this int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int width = GetColumnWidth(matrix);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(width) + " ");
                }
                Console.WriteLine();
            }
        }

        public static void WriteLowerTriangular(this int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int width = GetColumnWidth(matrix);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i >= j)
                        Console.Write(matrix[i, j].ToString().PadLeft(width) + " ");
                    else
                        Console.Write(new string(' ', width + 1));
                }
                Console.WriteLine();
            }
        }

        public static void WriteHourglass(this int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int width = GetColumnWidth(matrix);

            for (int i = 0; i < n; i++)
            {
                int minCol = Math.Min(i, n - 1 - i);
                int maxCol = Math.Max(i, n - 1 - i);

                for (int j = 0; j < n; j++)
                {
                    if (j >= minCol && j <= maxCol)
                        Console.Write(matrix[i, j].ToString().PadLeft(width) + " ");
                    else
                        Console.Write(new string(' ', width + 1));
                }
                Console.WriteLine();
            }
        }

        private static int GetColumnWidth(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int maxLen = 1;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    maxLen = Math.Max(maxLen, matrix[i, j].ToString().Length);

            return Math.Max(3, maxLen);
        }
    }
}
