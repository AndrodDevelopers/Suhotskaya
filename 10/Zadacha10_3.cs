using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лаба10_3
{
    class Zadacha10_3
    {
        static int[,] Input()
        {
            Console.Write("Введите размерность массива:");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            Random r = new Random();
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    //a[i, j] = int.Parse(Console.ReadLine());
                    a[i,j] = r.Next(0, 10);
                    //Console.WriteLine("a[{0},{1}]={2}", i,j, a[i,j]);
                }
            }
            return a;
        }
        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0} ", a[i, j]);
                Console.WriteLine();
            }
        }
        static double P(int[,] a)
        {
            int k = 0;
            double s = 0;
            for (int i = 0; i < a.GetLength(0); ++i)
                for (int j = 0; j < a.GetLength(1); ++j)
                    if (i > j && a[i, j] % 2 == 0)
                    {
                        ++k;
                        s += a[i, j];
                    }
            if (k != 0) return s / k;
            else return 0;
        }
        static int V(int[,] a)
        {
            int s = 0;
            for (int i = 0; i < a.GetLength(0); ++i)
                s += a[i, a.GetLength(0) - i - 1];
            return s;
        }
        static double T(int[,] a)
        {
            double s = 0;
            int k = 0;
            for (int i=0;i<a.GetLength(0);++i)
                for (int j=0;j<a.GetLength(1);++j)
                    if (j < a.GetLength(0) - i - 1 && a[i, j] != 0) { ++k; s += a[i, j]; }
            if (k != 0) return s / k;
            else return 0;
        }
        static double CH(int[,] a)
        {
            int k = 0;
            double s = 0;
            for (int i=0;i<a.GetLength(0);++i)
                for (int j=0;j<a.GetLength(1);++j)
                    if (j > a.GetLength(0) - i - 1) { ++k; s += a[i, j]; }
            if (k != 0) return s / k;
            else return 0;
        }
        static void PY(int[,] a)
        {
            int x = 0;
            for (int i = 0; i < a.GetLength(0); ++i)
                for (int j = 0; j <a.GetLength(1)/2; ++j)
                {
                    x = a[i, j];
                    a[i, j] = a[i, (a.GetLength(1) - 1) - j];
                    a[i, (a.GetLength(1) - 1) - j] = x;           
                }
        }
        static void S(int[,] a)
        {
            int x = 0;
            for (int i = (a.GetLength(0) / 2) - 1; i < a.GetLength(0) / 2; ++i)
                for (int j = 0; j < a.GetLength(1); ++j)
                    if (a.GetLength(0) % 2 == 0) 
                    {
                        x = a[(a.GetLength(0) / 2) - 1, j];
                        a[(a.GetLength(0) / 2) - 1, j] = a[a.GetLength(0) / 2, j];
                        a[a.GetLength(0) / 2, j] = x;
                    }
                    else 
                    {
                        x = a[0, j];
                        a[0, j] = a[(a.GetLength(0) - 1) / 2, j];
                        a[(a.GetLength(0) - 1) / 2, j] = x;
                    }
        }
        static void SE(int[,] a)
        {
            int x = 0;
            for (int i=0;i<a.GetLength(0);++i)
                for (int j=(a.GetLength(0)-(a.GetLength(0)/2))-1;j<a.GetLength(0)-(a.GetLength(0)/2);++j)
                    if (a.GetLength(0) % 2 == 0)
                    {
                        x = a[i, j];
                        a[i, j] = a[i, a.GetLength(0) - (a.GetLength(0) / 2)];
                        a[i, a.GetLength(0) - (a.GetLength(0) / 2)] = x;
                    }
                    else
                    {
                        x = a[i, 0];
                        a[i, 0] = a[i, (a.GetLength(0) - 1) / 2];
                        a[i, (a.GetLength(0) - 1) / 2] = x;
                    }
        }
        static void VO(int[,] a)
        {
            int x = 0;
            for (int i = 0; i < a.GetLength(0); ++i)
                for (int j = 0; j < a.GetLength(1)/2; ++j)
                    if (i % 2 != 0)
                    {
                        x = a[i, j];
                        a[i, j] = a[i, (a.GetLength(1) - 1) - j];
                        a[i, (a.GetLength(1) - 1) - j] = x; 
                    }
                    
        }
        static void D(int[,] a)
        {
            int x = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j+=2)
                    if (a.GetLength(0) % 2 == 0)
                    {
                        x = a[i, j];
                        a[i, j] = a[i, j + 1];
                        a[i, j + 1] = x;
                    }
        }
        static void DE(int[,] a)
        {
                int x = 0;
                for (int i = 0; i < a.GetLength(0); i += 2)
                    for (int j = 0; j < a.GetLength(1); ++j)
                        if (a.GetLength(0) % 2 == 0)
                        {
                            x = a[i, j];
                            a[i, j] = a[i + 1, j];
                            a[i + 1, j] = x;
                        }
        }
        static void Main(string[] args)
        {
            int[,] Mas = Input();
            Console.WriteLine("Исходный массив:");
            Print(Mas);
            Console.Write("Введите номер задания:");
            int oper = int.Parse(Console.ReadLine());
            switch (oper)
            {
                case 1:
                    Console.WriteLine("\nПодсчитать среднее арифметическое четных элементов, расположенных ниже главной диагонали.\n");
                    double a = P(Mas);
                    Console.WriteLine(a);
                    break;
                case 2:
                    Console.WriteLine("\nПодсчитать сумму элементов, расположенных на побочной диагонали.\n");
                    int sum = V(Mas);
                    Console.WriteLine(sum);
                    break;
                case 3:
                    Console.WriteLine("\nПодсчитать среднее арифметическое ненулевых элементов, расположенных над побочной диагональю.\n");
                    double sr = T(Mas);
                    Console.Write("Среднее арифмитическое = {0:f3}\n\r", sr);
                    break;
                case 4:
                    Console.WriteLine("\nПодсчитать среднее арифметическое элементов, расположенных под побочной диагональю.\n");
                    sr = CH(Mas);
                    Console.WriteLine("Среднее арифмитическое = {0:f3}\n\r", sr);
                    break;
                case 5:
                    Console.WriteLine("\nПоменять местами столбцы по правилу: первый с последним, второй с предпоследним и т.д.\n");
                    PY(Mas);
                    Print(Mas);
                    break;
                case 6:
                    Console.WriteLine("\nПоменять местами две средних строки, если количество строк четное, и первую" + 
                        "со средней строкой, если количество строк нечетное.\n");
                    S(Mas);
                    Print(Mas);
                    break;
                case 7:
                    Console.WriteLine("\nПоменять местами два средних столбца, если количество столбцов четное, и" +
                        "первый со средним столбцом, если количество столбцов нечетное.\n");
                    SE(Mas);
                    Print(Mas);
                    break;
                case 8:
                    Console.WriteLine("\nВывести элементы матрицы в следующем порядке:\n1 2 3 4\n8 7 6 5\n9 10 11 12\n16 15 14 13\n");
                    VO(Mas);
                    Print(Mas);
                    break;
                case 9:
                    Console.WriteLine("\nЕсли количество столбцов в массиве четное, то поменять столбцы местами по" +
                                        "правилу: первый столбец со вторым, третий - с четвертым и т.д. Если количество" +
                                        "столбцов в массиве нечетное, то оставить массив без изменений.\n");
                    D(Mas);
                    Print(Mas);
                    break;
                case 10:
                    Console.WriteLine("\nЕсли количество строк в массиве четное, то поменять строки местами по" +
                                        "правилу: первую строку со второй, третью - с четвертой и т.д. Если количество" +
                                        "строк в массиве нечетное, то оставить массив без изменений.\n");
                    DE(Mas);
                    Print(Mas);
                    break;

            }
        }
    }
}
