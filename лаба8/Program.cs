using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nomer zadaniya:");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: int m = int.Parse(Console.ReadLine());
                    int col = 0;
                    for (int i = 1; i <= m; ++i)
                    {
                        for (int j = 1; j <= m; j++)
                        {
                            if ((i + j) % 2 == 0) col++;

                        }

                    }
                    Console.WriteLine(col);
                    break;
                case 2:
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    if ((b + a) % 2 == 0) Console.WriteLine("chernoe");
                    else Console.WriteLine("beloe");

                    break;
                case 3:
                    int k1 = int.Parse(Console.ReadLine());
                    int s1 = int.Parse(Console.ReadLine());
                    int k2 = int.Parse(Console.ReadLine());
                    int s2 = int.Parse(Console.ReadLine());
                    if ((k1 + s1) % 2 == 0 && (k2 + s2) % 2 == 0) Console.WriteLine("da");
                    else Console.WriteLine("net");
                    break;
                
            }
        }
    }
}
