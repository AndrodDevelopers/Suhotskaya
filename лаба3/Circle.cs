using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba3
{
    class Circle : Figure // круг
    {
        public int r;
        public Circle(int r)
        {
            this.r = r;
        }
        public override double area()
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public override double perimeter()
        {
            return 2 * Math.PI * r;
        }
        public override void print()
        {
            Console.WriteLine("Круг с радиусом r = {0}",r);
        }
    }
}
