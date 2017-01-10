using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace лаба12
{
    class Lab12
    {
        static int[,] Input()
        {
            Console.Write("Введите размерность марицы:");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            Random r = new Random();
            for (int i = 0; i < a.GetLength(0); ++i)
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    //Console.Write("a[{0},{1}]=", i, j);
                    //a[i, j] = int.Parse(Console.ReadLine());
                    a[i, j] = r.Next(1,10);
                }
            return a;
        }
        static void Print(int [,]a)
        {
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j) Console.Write("{0} ", a[i, j]);
                Console.WriteLine();
            }
        }
        static int zadacha1_1(int[,] a)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(0); ++j)
                {
                    if ((j >= i && j <= a.GetLength(0)-i-1) || (i >= j && j >= a.GetLength(0)-i-1))
                    {
                        if (a[i, j] > max) max = a[i, j];
                    }
                }
            }
            return max;
                
        }
        static int zadacha1_2(int[,] a)
        {
            int s = 0;
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(0); ++j)
                {
                    if ((i >= j && j <= a.GetLength(0) - i - 1) || (i <= j && j >= a.GetLength(0) - i - 1))
                    {
                        s += a[i, j];
                    }
                }
            }
            return s;
            
        }
        static void Main(string[] args)
        {
            int[,] Mas = Input();
            Console.WriteLine("\nИсходная матрица:\n");
            Print(Mas);
            int max = zadacha1_1(Mas);
            Console.WriteLine("\nМаксимальный элемент из заштрихованной области = {0}\n", max);
            int sr = zadacha1_2(Mas);
            Console.WriteLine("\nСумма элементов из заштрихованной области = {0}\n", sr);
        }
    }
}
