using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("oper=");
            int oper = int.Parse(Console.ReadLine());
            switch (oper)
            {
                case 1:
                    {
                        for (int i = 1; i <= 4; i++, Console.WriteLine())
                        { for (int j = 0; j <= 9; j++, Console.Write(j + " ")) ;}
                    }
                    break;
                case 2:
                    {
                        for (int i = 1; i <= 5; i++, Console.WriteLine())
                        {
                            for (int j = -11; j <= 11; j++, Console.Write(j + " ")) ;
                        }
                    }
                    break;
                case 3:
                    {
                        int temp = 41;
                        for (int i = 1; i <= 4; i++)
                        {

                            for (int j = temp; j <= temp + 9; j++)
                            {
                                Console.Write(j + " ");
                            }
                            temp += 10;
                            Console.WriteLine();
                        }
                    }
                    break;
                case 4:
                    for (int i = 1; i <= 5; ++i)
                    {
                        for (int j = 1; j <= 5; ++j)
                        {
                            if (i >= j)
                                Console.Write(" " + 5);
                        }
                        Console.WriteLine();
                    }
                    break;

                case 5:
                    for (int i = 1; i <= 5; ++i)
                    {
                        for (int j = 5; j >= 1; j--)
                        {
                            if (i <= j)
                                Console.Write(" " + 1);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 6:
                    for (int i = 1; i <= 5; ++i)
                    {
                        for (int j = 1; j <= 5; j++)
                        {
                            if (i >= j)
                                Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 7:
                    for (int i = 1; i <= 5; ++i)
                    {
                        for (int j = 1; j <= 5; j++)
                        {
                            if (i >= j)
                                Console.Write(j + " ");
                        }
                        Console.WriteLine();
                    }
                    break;

            }

        }
    }
}