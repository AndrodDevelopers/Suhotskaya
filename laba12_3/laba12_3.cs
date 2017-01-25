using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace laba12_3
{
    class laba12_3
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("text.txt");
            string sizeArray = file.ReadLine();
            int size = int.Parse(sizeArray);
            int[,] Array = new int[size, size];
            string line = file.ReadToEnd();
            string[] element = line.Split(' ', '\n');
            int[] elementInt = element.Select(element1 => int.Parse(element1)).ToArray();
            for (int i = 0; i < elementInt.Length; i++)
            {
                for (int a = 0; a < size; a++)
                {
                    for (int b = 0; b < size; b++)
                    {
                        Array[a, b] = elementInt[i++];
                    }
                }
            }
            int Max = zadacha1(Array);
            StreamWriter file1 = new StreamWriter("text1.txt", false);
            file1.Write(Max);
            int s = zadacha2(Array);
            StreamWriter file2 = new StreamWriter("text2.txt", false);
            file2.Write(s);
            file.Close();
            file1.Close();
            file2.Close();
        }
        static int zadacha1(int[,]a)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(0); ++j)
                {
                    if ((j >= i && j <= a.GetLength(0) - i - 1) || (i >= j && j >= a.GetLength(0) - i - 1))
                    {
                        if (a[i, j] > max) max = a[i, j];
                    }
                }
            }
            return max;
        }
        static int zadacha2(int[,]a)
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
    }
}
