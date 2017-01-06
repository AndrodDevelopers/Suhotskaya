using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: int i = 25;
                    while (i <= 35)
                    {
                        Console.WriteLine("{0}  {1}  {2}", i, i + 0.5, i - 0.2);
                        i++;
                    }
                    break;
                case 2: int a = 25;
                    do { Console.WriteLine("{0}  {1}  {2}", a, a + 0.5, a - 0.2); a++; }
                    while (a <= 35);
                    break;
                case 3: int b;
                    for (b = 25; b <= 35; ) { Console.WriteLine("{0}  {1}  {2}", b, b + 0.5, b - 0.2); b++; }
                    break;
                case 4: int A = 10;
                    int B = 30;
                    while (B >= A)
                    {
                        Console.WriteLine(Math.Pow(B, 3));
                        B--;
                    }

                    B = 30;
                    do { Console.WriteLine(Math.Pow(B, 3)); B--; }
                    while (B >= A);


                    for (B = 30; B >= A; ) { Console.WriteLine(Math.Pow(B, 3)); B--; }
                    break;
                case 5: a = 10;
                    b = 30;
                    int x = int.Parse(Console.ReadLine());
                    int y = int.Parse(Console.ReadLine());
                    while (a <= b) { if (a % 10 == x || a % 10 == y) Console.WriteLine(a); a++; }
                    a = 10;
                    b = 30;
                    do { if (a % 10 == x || a % 10 == y) Console.WriteLine(a); a++; } while (a <= b);
                    b = 30;
                    for (a = 10; a <= b; ) { if (a % 10 == x || a % 10 == y) Console.WriteLine(a); a++; }
                    break;
                case 6:
                    a = 100;
                    b = 999;
                    while (a <= b) { if (a / 100 == a % 10)  Console.WriteLine(a); a++; }
                    break;
                case 7:
                    a = 10;
                    b = 60;
                    while (b >= a) { Console.WriteLine(" " + b); b -= 2; }
                    a = 10;
                    b = 60;
                    do { Console.WriteLine(" " + b); b -= 2; } while (b >= a);
                    for (b = 60; b >= a; ) { Console.WriteLine(" " + b); b -= 2; }
                    break;

            }


        }
    }
}
          