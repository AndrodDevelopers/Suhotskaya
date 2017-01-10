using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лаба10._2
{
    class Zadacha10_2
    {
        static int[] Input()
        {
            Console.Write("Введите размерность массива:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write("a[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
                Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }
        static int Max(int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; ++i)
                if (a[i] > max) max = a[i];
            return max;
        }
        static int Min(int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; ++i)
                if (a[i] < min) min = a[i];
            return min;
        }
        static void PERV(int[] a)
        {
            int min = Min(a);
            List<int> M = new List<int>();
            for (int i = 0; i < a.Length; ++i)
                if (min == a[i]) M.Add(i);
            for (int j = 0; j < M.Count; ++j)
                Console.Write(M[j] + " ");
            Console.WriteLine();
        }
        static void VTOR(int[] a)
        {
            int max = Max(a);
            for (int i = 0; i < a.Length; ++i)
                if (max == a[i]) a[i] = 0;
        }
        static void TRET(int[] a)
        {
            int min = Min(a);
            for (int i = 0; i < a.Length; ++i)
                if (min == a[i]) a[i] = -a[i];
        }
        static void CHETV(int[] a)
        {
            int temp = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] == Max(a)) { temp = i; }
            }
            int zam = a[0];
            a[0] = Max(a);
            a[temp] = zam;
            Print(a);
        }
        static void PYAT(int[] a)
        {
            int max = Max(a);
            List<int> M = new List<int>();
            for (int i = 0; i < a.Length; ++i)
                if (a[i] != max) M.Add(i);
            for (int j = 0; j < M.Count; j++)
                Console.Write(M[j] + " ");
            Console.WriteLine();
        }
        static void SHEST(int[] a)
        {
            int min = Min(a);
            List<int> M = new List<int>();
            for (int i = 0; i < a.Length; ++i)
                if (a[i] == min) M.Add(i);
            Console.WriteLine(M[0]);
        }
        static void SEM(int[] a)
        {
            int temp = 0;
            for (int i = 0; i < a.Length; ++i)
                if (a[i] == Max(a)) temp = i;
            Console.WriteLine(temp);
        }
        static void VOS(int[] a)
        {
            int m = 0;
            int n = 0;
            int max = a[0];
            for (int i = 0; i < a.Length; ++i)
            { if (a[i] > max) 
                { max = a[i];  m = i;} 
            }
            int min = a[0];
            for (int i = 0; i < a.Length; ++i)
            { if (a[i] < min)
                { min = a[i]; n = i; }
            }
            int sum = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (i > m && i < n) sum += a[i];
            }
            if (m > n) Console.WriteLine("Максимальный элемент находится после минимального!");
            else if (n - m == 1) Console.WriteLine("Элементы стоят рядом!");
            else Console.WriteLine("Сумма элементов = " + sum);
        }
        static void DEV(int[] a)
        {
            int n = 0;
            for (int i = 0; i < a.Length; ++i)
                if (a[i] == Max(a)) { n = i; break; }
            Console.WriteLine(n);
        }
        static void DES(int[] a)
        {
            int temp = 0;
            for (int i = 0; i < a.Length; ++i)
                if (a[i] == Min(a)) temp = i;
            Console.WriteLine(temp);
        }
        static void Main()
        {
            int[] Mas = Input();
            Console.WriteLine("Исходный массив:");
            Print(Mas);
            Console.Write("Введите номер задания:");
            int oper = int.Parse(Console.ReadLine());
            switch (oper)
            {
                case 1:
                    Console.WriteLine("Вывести на экран номера всех минимальных элементов.");
                    PERV(Mas);
                    break;
                case 2:
                    Console.WriteLine("Заменить все максимальные элементы нулями.");
                    VTOR(Mas);
                    Print(Mas);
                    break;
                case 3:
                    Console.WriteLine("Заменить все минимальные элементы на противоположные.");
                    TRET(Mas);
                    Print(Mas);
                    break;
                case 4:
                    Console.WriteLine("Поменять местами максимальный элемент и первый.");
                    CHETV(Mas);
                    break;
                case 5:
                    Console.WriteLine("Вывести на экран номера всех элементов, не совпадающих с максимальным.");
                    PYAT(Mas);
                    break;
                case 6:
                    Console.WriteLine("Найти номер первого минимального элемента.");
                    SHEST(Mas);
                    break;
                case 7:
                    Console.WriteLine("Найти номер последнего максимального элемента.");
                    SEM(Mas);
                    break;
                case 8:
                    Console.WriteLine("Подсчитать сумму элементов, расположенных между максимальным и минимальным элементами (минимальный "
                    + "и максимальный элементы в массиве единственные). Если максимальный элемент встречается позже минимального,то выдать"
                    + "сообщение об этом.");
                    VOS(Mas);                    
                    break;
                case 9:
                    Console.WriteLine("Найти номер первого максимального элемента.");
                    DEV(Mas);
                    break;
                case 10:
                    Console.WriteLine("10.Найти номер последнего минимального элемента.");
                    DES(Mas);
                    break;
            }

        }

    }
}
