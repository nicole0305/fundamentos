using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem15_ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese # matriz ");
            int num = int.Parse(Console.ReadLine());

            int[,] matriz = new int[num, num];
            int[,] transpuesta = new int[num, num];
            Random rnd = new Random();

            Console.WriteLine("\nMATRIZ ORIGINAL");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rnd.Next(30, 51);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMATRIZ TRANSPUESTA");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    transpuesta[j, i] = matriz[i, j];
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(transpuesta[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
