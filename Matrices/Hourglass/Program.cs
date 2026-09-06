using System;
using Matrices.Common;

namespace Hourglass;

internal class Program
{
    static void Main(string[] args)
    {

        int N = ConsoleExtensions.ReadInt("Ingrese orden de la matriz: ", n => n > 0 && n % 2 == 1);


        int[,] matriz = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = (2 * i) + j;
            }
        }
        Console.WriteLine("MATRIZ COMPLETA");
        matriz.WriteMatrix();

        Console.WriteLine();

        Console.WriteLine("RELOJ DE ARENA");
        matriz.WriteHourglass();

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
