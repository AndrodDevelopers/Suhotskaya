using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba1
{
    class Triangle
    {
        public int a, b, c;
        public Triangle() { }
        public Triangle(int a,int b,int c) 
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else Console.WriteLine("Треугольник не существует!");
        }
        public void plus()
        {
            a = a + 1;
            b = b + 1;
            c = c + 1;
        }
        public void minus()
        {
            a = a - 1;
            b = b - 1;
            c = c - 1;
        }
        public void trueFalse()
        {
            if (a + b > c && a + c > b && b + c > a) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
        public void multiplication(int skal)
        {
            a *= skal;
            b *= skal;
            c *= skal;
            Print();
        }
        public void Print() 
        {
            Console.WriteLine("Треугольник с длинами сторон a = {0}, b = {1}, c = {2}.", a, b, c);
        }
        public void perimeter()
        {
           int P = a + b + c;
           Console.WriteLine("Периметр = " + P);
        }
        public void area()
        {
            double p = (float) (a + b + c) / 2;
            double S = (float) Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Площадь = {0:f3}", S);
        }
    }
}
