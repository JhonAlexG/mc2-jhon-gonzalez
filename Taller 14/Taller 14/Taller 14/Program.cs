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
            int Filas = 3;
            int Columnas = 4;
            double[,] Matriz = new double[Filas, Columnas];
            Console.WriteLine("Coloque los números de la matriz");
            for (int i = 0;  i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    Matriz[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Operations.Gauss(Matriz, Filas, Columnas);
            Console.ReadKey();
        }
    }
} 
