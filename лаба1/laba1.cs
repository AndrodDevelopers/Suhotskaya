using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba1
{
    class laba1
    {
        static void Main()
        {
            Console.Write("Номер задания: ");
            int oper = int.Parse(Console.ReadLine());
            switch (oper)
            {
                case 1:
                    Triangle();
                    break;
                case 2:
                    Rectangle();
                    break;
                case 3:
                    OneDimensionalArray();
                    break;
                case 4:
                    TwoDimensionalArray();
                    break;
            }
        }
        static void Triangle()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Triangle tr = new Triangle(a, b, c);
            tr.trueFalse();
            tr.Print();
            tr.perimeter();
            tr.area();
            tr.plus();
            tr.minus();
            Console.WriteLine("Выполнен ++ и --, но смысла в этом нет");
            tr.Print();
            Console.Write("Введите скаляр: ");
            int skal = int.Parse(Console.ReadLine());
            tr.multiplication(skal);
        }
        static void Rectangle()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Rectangle r = new Rectangle(a, b);
            r.print();
            Console.WriteLine("true - квадрат, false - не квадрат");
            r.trueFalse();
            r.perimeter();
            r.area();
            r.plus();
            r.minus();
            Console.WriteLine("Выполнен ++ и --, но смысла в этом нет");
            r.print();
            Console.Write("Введите скаляр: ");
            int skal = int.Parse(Console.ReadLine());
            r.multiplication(skal);
            
        }
        static void OneDimensionalArray()
        {
            Console.Write("Размерность массива: n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите отрезок [a,b] из которого брать значения!");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            OneDimensionalArray my1 = new OneDimensionalArray(n);
            OneDimensionalArray my2 = new OneDimensionalArray(n, a, b);
            OneDimensionalArray my3 = new OneDimensionalArray(n, a, b);
            Array.Sort(my3.IntArray);
            //OneDimensionalArray my3 = new OneDimensionalArray(a, b);
            //my3.n = my2.n;
            OneDimensionalArray my4 = new OneDimensionalArray();
            my1.print("первый массив");
            my2.print("второй массив");
            my3.print("третий массив");
            my4.keyboardPrint();
            my4.print("четвертый массив");

            Console.WriteLine("false - упорядочен, true - НЕ упорядочен");
            my1.trueFalse();
            my2.trueFalse();
            my3.trueFalse();
            my4.trueFalse();
            
            my2.Sort();
            my2.print("второй отсортированный массив");
            my4.Sort();
            my4.print("четвертый отсортированный массив");

            my2.plus();
            my2.minus();
            my2.print("массив 2 прошел операции ++ и --");

            Console.Write("Введите скаляр: ");
            int skalyar = int.Parse(Console.ReadLine());
            my4.multiplication(skalyar);
            my4.print("массив умноженный на скаляр");
        }
        static void TwoDimensionalArray()
        {
            Console.Write("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());
            TwoDimensionalArray t = new TwoDimensionalArray(n);
            t.print();
            TwoDimensionalArray t2 = new TwoDimensionalArray();
            Console.WriteLine("Введите элементы массива с клавиатуры: ");
            t2.keyboardPrint();
            t2.print();
            Console.WriteLine("true - квадратный, false - не квадратный");
            t2.trueFalse();
            t2.Summa();
            t2.plus();
            t2.minus();
            Console.WriteLine("массив прошел операции ++ и --");
            t2.print();
            Console.WriteLine(t2.IntArray.GetLength(0));
            if (n == t2.IntArray.GetLength(0))
            {
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        t.IntArray[i, j] += t2.IntArray[i, j];
                    }
                }
            }
            t.print();
        }
    }
}



