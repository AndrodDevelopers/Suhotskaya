using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba3
{
    class Triangle : Figure // треугольник
    {
        public int a, b, c;
        public Triangle(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else Console.WriteLine("Треугольник не существует!");
        }
        public override double perimeter()
        {
            return a + b + c;
        }
        public override double area()
        {
            double p = (float) (a + b + c) / 2;
            return (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public override void print()
        {
            Console.WriteLine("Треугольник с длинами сторон a = {0}, b = {1} и c = {2}", a, b, c);
        }
    }
}
