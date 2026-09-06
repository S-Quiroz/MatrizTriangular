using System;
using Matrices.Common;

namespace MatrizTriangularInferior;

internal class Program
{
    static void Main(string[] args)
    {
        int N = ConsoleExtensions.ReadInt("Ingrese orden de la matriz: ", n => n > 0);


        int[,] matriz = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = i + j;
            }
        }
        matriz.WriteMatrix();
        Console.WriteLine();
        matriz.WriteLowerTriangular();
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
