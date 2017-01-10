using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лаба10
{
    class Zadacha10_1
    {
        static int[] Input()
        {
            Console.Write("Введите размерность массива:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write("a[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
                Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }
        static void Pervoe(int[] a)
        {
            Console.WriteLine("Введите интервал!");
            Console.Write("a=");
            int A = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int B = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.Length; ++i)
                if (a[i] > A && a[i] < B) a[i] = 0;
        }
        static void Vtoroe(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
                if (a[i] < 0 && a[i] % 3 != 0) a[i] = -a[i];
        }
        static void Tretee(int[] a)
        { 
            Console.Write("Заданное число:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.Length; ++i)
                if (a[i] < n) a[i] *= 2;
        }
        static double Chetvertoe(int[] a)
        {
            double s = 0;
            int k = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                ++k;
                s += a[i];
            }
            if (k != 0) return s / k;
            else return 0;
            
        }
        static double Pyatoe(int[] a)
        {
            int k=0;
            double s=0;
            for (int i=0;i<a.Length;++i)
                if (a[i] < 0) { ++k; s += a[i]; }
            if (k != 0) return s / k;
            return 0;
        }
        static int Shestoe(int[] a)
        {
            int k = 0;
            for (int i = 0; i < a.Length; ++i)
                if (a[i] < 0) ++k;
            return k;
        }
        static int Sedmoe(int[] a)
        {
            int s = 0;
            Console.WriteLine("Введите интервал:");
            Console.Write("a=");
            int A = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int B = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.Length; ++i)
                if (a[i] > A && a[i] < B) s += a[i];
            return s;
        }
        static int Vosmoe(int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; ++i)
                if (a[i] % 9 == 0) s += a[i];
            return s;
        }
        static int Devyatoe(int[] a)
        {
            int k = 0;
            Console.WriteLine("Введите заданный интрвал:");
            Console.Write("a=");
            int A = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int B = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.Length; ++i)
                if (a[i] < A || a[i] > B) ++k;
            return k;
        }
        static double Desyatoe(int[] a)
        {
            double s = 0;
            for (int i = 0; i < a.Length; ++i)
                if (a[i] % 2 == 0) s += Math.Pow(a[i], 2);
            return s;
        }
        static void Main()
        {
            int[] Massiv = Input();
            Console.WriteLine("Исходный массив:");
            Print(Massiv);
            Console.Write("Введите номер задания:");
            int oper = int.Parse(Console.ReadLine());
            switch (oper)
            {
                case 1:
                    Console.WriteLine("Заменить все элементы, попадающие в интервал [a,b], нулем.");
                    Array.Sort(Massiv);
                    Console.WriteLine("Отсортированный по возростанию массив для удобства!");
                    Print(Massiv);
                    Pervoe(Massiv);
                    Print(Massiv);
                    break;
                case 2:
                    Console.WriteLine("Заменить все отрицательные элементы, не кратные 3, противоположными им числами.");
                    Vtoroe(Massiv);
                    Print(Massiv);
                    break;
                case 3:
                    Console.WriteLine("Все элементы, меньшие заданного числа, увеличить в два раза.");
                    Tretee(Massiv);
                    Print(Massiv);
                    break;
                case 4:
                    Console.WriteLine("Подсчитать среднее арифметическое элементов.");
                    double a = Chetvertoe(Massiv);
                    Console.WriteLine(a);
                    break;
                case 5:
                    Console.WriteLine("Подсчитать среднее арифметическое отрицательных элементов.");
                    double b = Pyatoe(Massiv);
                    Console.WriteLine(b);
                    break;
                case 6:
                    Console.WriteLine("Подсчитать количество нечетных элементов.");
                    int c = Shestoe(Massiv);
                    Console.WriteLine(c);
                    break;
                case 7:
                    Console.WriteLine("Подсчитать сумму элементов, попадающих в заданный интервал.");
                    Array.Sort(Massiv);
                    Console.WriteLine("Отсортированный по возростанию массив для удобства!");
                    Print(Massiv);
                    int d = Sedmoe(Massiv);
                    Console.WriteLine(d);
                    break;
                case 8:
                    Console.WriteLine("Подсчитать сумму элементов, кратных 9.");
                    int e = Vosmoe(Massiv);
                    Console.WriteLine(e);
                    break;
                case 9:
                    Console.WriteLine("Подсчитать количество элементов, не попадающих в заданный интервал.");
                    Array.Sort(Massiv);
                    Console.WriteLine("Отсортированный по возростанию массив для удобства!");
                    Print(Massiv);
                    int f = Devyatoe(Massiv);
                    Console.WriteLine(f);
                    break;
                case 10:
                    Console.WriteLine("Подсчитать сумму квадратов четных элементов.");
                    double g = Desyatoe(Massiv);
                    Console.WriteLine(g);
                    break;
            }
        }
    }
}
