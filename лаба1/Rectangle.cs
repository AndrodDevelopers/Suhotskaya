using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba1
{
    class Rectangle
    {
        public int a, b;
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void plus()
        {
            a = a + 1;
            b = b + 1;
        }
        public void minus()
        {
            a = a - 1;
            b = b - 1;
        }
        public void trueFalse()
        {
            if (a==b) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
        public void multiplication(int skal)
        {
            a *= skal;
            b *= skal;
            print();
        }
        public void print()
        {
            Console.WriteLine("Длины сторон прямоугольника: a = {0}, b = {1}.", a, b);
        }
        public void perimeter()
        {
            Console.WriteLine("Периметр прямоугольника: P = {0}.", 2 * (a + b));
        }
        public void area()
        {
            Console.WriteLine("Площадь прямоугольника: S = {0}.", a * b);
        }
    }
}
