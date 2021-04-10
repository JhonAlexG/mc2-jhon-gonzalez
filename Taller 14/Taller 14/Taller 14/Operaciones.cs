using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_14
{
    class Operaciones
    {
        public void Gauss(double[,] matrix, int filas, int columnas)
        {
            for (int fpivot = 0; fpivot < filas; fpivot++)
            {
                double nor = matrix[fpivot, fpivot];
 
                for (int i = 0; i < columnas; i++)
                {
                    matrix[fpivot, i] = matrix[fpivot, i] / nor;
                }
 
                int f = fpivot + 1;
                if (f == filas) f = 0;
 
                for (int fila = 0; fila < filas - 1; fila++)
                {                
                    double k = matrix[f, fpivot];
 
                    for (int j = fpivot; j < columnas; j++)
                    {
                        matrix[f, j] = matrix[f, j] - (k * matrix[fpivot, j]);
                    }
                 
                    if (f == filas - 1) f = 0;
                    else f++; 
                }
            }
            
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("[" + matrix[i, j] + "]");
                }
                Console.WriteLine("");
            }
        }
    }
}
