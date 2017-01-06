using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba9
{
    class Program
    {

        static int min(int a, int b)
        {
            if (a < b) return a;
            else return b;
        }
        static int min(int a, int b, int c)
        {
            if (a < b && a < c) return a;
            else if (b < c) return b;
            else return c;
        }
        static int min(int a, int b, int c, int d)
        {
            if (a < b && a < c && a < d) return a;
            else if (b < c && b < d) return b;
            else if (c < d) return c;
            else return d;
        }
        static int max(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }
        static double func(double a)
        {
            return Math.Pow(a, 3) - Math.Sin(a);
        }
        static double func2(double a)
        {
            return Math.Cos(2 * a) + Math.Sin(a - 3);
        }
        static double func3(double x)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double y ;
            if (Math.Pow(x, 2) - (5 * x) < 0) y = a + b;
            else if ((Math.Pow(x, 2) - (5 * x)) < 10 && (Math.Pow(x, 2) - (5 * x)) >= 0) y = a - b;
            else if ((Math.Pow(x, 2) - (5 * x)) >= 10) y = a * b;
            return y;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания:");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.Write("Введите a:");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Введите b:");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("Введите c:");
                    int c = int.Parse(Console.ReadLine());
                    Console.Write("Введите d:");
                    int d = int.Parse(Console.ReadLine());
                    Console.WriteLine("Min({0},{1},{2},{3})={4}", a, b, c, d, min(a, min(b, min(c, d))));
                    break;
                case 2:
                    Console.Write("Введите a:");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Введите b:");
                    b = int.Parse(Console.ReadLine());
                    c = max(a, (2 * b) - a) + max((5 * a) + (3 * b), b);
                    Console.WriteLine("z = {0}", c);
                    break;
                case 3:
                    Console.Write("Введите a:");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Значение функции в точке а: {0}", func(a));
                    Console.Write("Введите b:");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Значение функции в точке b: {0}", func(b));
                    if (func(a) > func(b)) Console.WriteLine("Большее значение функции в точке a!");
                    else Console.WriteLine("Большее значение функции в точке b!");
                    break;
                case 4:
                    Console.Write("Введите a:");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Значение функции в точке а: {0}", func2(a));
                    Console.Write("Введите b:");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Значение функции в точке b: {0}", func2(b));
                    if (func2(a) < func2(b)) Console.WriteLine("Меньшее значение функции в точке a!");
                    else Console.WriteLine("Меньшее значение функции в точке b!");
                    break;
                case 5:
                    Console.WriteLine("Интервал от {0} до {1}",-10,30);
                    Console.Write("Введите h:");
                    int h = int.Parse(Console.ReadLine());
                    for (double i = -10; i <= 30; i += h)
                    Console.WriteLine("f({0:f2})={1:f4}", i, func3(i));
                    break;
            }
        }
    }
}
