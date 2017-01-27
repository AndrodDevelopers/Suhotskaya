using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba1
{
    class TwoDimensionalArray
    {
        public int n;
        public int[,] IntArray;
        public TwoDimensionalArray() { }
        public TwoDimensionalArray(int n)
        {
            this.n = n;
            IntArray = new int[n, n];
            Random r = new Random();
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    IntArray[i,j] = r.Next(0,10);
                }
            }
        }
        public void plus()
        {
            for (int i = 0; i < IntArray.GetLength(0); ++i)
            {
                for (int j = 0; j < IntArray.GetLength(1); ++j)
                {
                    IntArray[i, j] += 1;
                }
            }
        }
        public void minus()
        {
            for (int i = 0; i < IntArray.GetLength(0); ++i)
            {
                for (int j = 0; j < IntArray.GetLength(1); ++j)
                {
                    IntArray[i, j] -= 1;
                }
            }
        }
        public void print()
        {
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write(IntArray[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void trueFalse()
        {
            if (IntArray.GetLength(0) == IntArray.GetLength(1)) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
        public int[,] keyboardPrint()
        {
            Console.Write("Размерность массива:");
            n = int.Parse(Console.ReadLine());
            IntArray = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("a[{0}] = ", i);
                    IntArray[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return IntArray;
        }
        public int Summa()
        {
            int summa = 0;
            Console.Write("Введите номер столбца: ");
            int nomer = int.Parse(Console.ReadLine());
            Console.Write("Сумма " + nomer + " столбца равна: ");
            for (int i = 0; i < n; ++i)
            {
                summa += IntArray[i, nomer - 1];
            }
            Console.WriteLine(summa);
            return summa;
        }
    }
}
