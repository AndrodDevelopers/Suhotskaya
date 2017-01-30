using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba3
{
    class Rectangle : Figure // прямоугольник
    {
        public int a, b;
        public Rectangle(int a, int b)
        {
            this.a = a; this.b = b;
        }
        public override double perimeter()
        {
            return (a + b) * 2;
        }
        public override double area()
        {
            return a * b;
        }
        public override void print()
        {
            Console.WriteLine("Прямоугольник с длинами сторон a = {0} и b = {1}", a, b);
        }
    }
}
