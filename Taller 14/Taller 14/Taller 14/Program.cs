using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones Operations = new Operaciones();
            Console.WriteLine("Resolviendo el sistema de ecuaciones:");
            Console.WriteLine("2x1 + x2 + 4x3 - 4x4 = -1");
            Console.WriteLine("5x1 + 5x2 + 3x3 - 2x4 = 3");
            Console.WriteLine("2x1 + 2x2 - 1x3 = 9");
            Console.WriteLine("5x2 - 2x3 + x4 = 11");
            int Filas = 4;
            int Columnas = 5;
            double[,] Matriz = { { 2, 1, 4, -4, -1 }, { 5, 5, 3, -2, 3 }, { 2, 2, -1, 0, 9 }, { 0, 5, -2, 1, 11 } };
            Console.WriteLine("\nMatríz del sistema de ecuaciones:");
            for (int i = 0;  i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    Console.Write("[" + Matriz[i, j] + "]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nMatríz de solución:");
            Operations.Gauss(Matriz, Filas, Columnas);

            Console.ReadKey();
        }
    }
} 
