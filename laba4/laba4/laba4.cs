using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace laba4
{
    class laba4
    {
        static void setOfNumbers()
        {
            StreamWriter file = new StreamWriter("setOfNumbers.txt", false);
            Random r = new Random();
            for (int i = 0; i < 10; ++i)
            {
                file.Write(r.Next(-50,50) + " ");
            }
            file.Close();
            StreamReader fileIn = new StreamReader("setOfNumbers.txt");
            string line = fileIn.ReadToEnd();
            fileIn.Close();
            Console.WriteLine("Числа из файла: " + line);
            string[] element = line.Trim().Split(' ');
            int[] elementInt = element.Select(element1 => int.Parse(element1)).ToArray();
            Stack chisla = new Stack();
            for (int i = 0; i < elementInt.Length; ++i)
            {
                chisla.Push(elementInt[i] + " ");
            }
            Console.Write("Числа в обратном порядке: ");
            for (int i = 0; i < elementInt.Length; ++i)
            {
                Console.Write(chisla.Pop());
            }
            Console.WriteLine();
        }
        static void txtFile()
        {
            StreamWriter file = new StreamWriter("t.txt",false);
            Console.Write("Введите строку, с которой мы будем работать: ");
            string str = Console.ReadLine();
            file.Write(str);
            file.Close();
            StreamReader fileIn = new StreamReader("t.txt");
            string strokaIn = fileIn.ReadToEnd();
            fileIn.Close();
            Stack st = new Stack();
            char[] strokaArray = strokaIn.ToCharArray();
            char[] glasnye = {'а','о','у','ы','э','е','и','ё','ю','я'};
            for (int i = 0; i < strokaArray.Length; ++i)
            {
                for (int j = 0; j < glasnye.Length; ++j)
                {
                    if (strokaArray[i] == glasnye[j]) st.Push(strokaArray[i]);
                }
            }
            Console.Write("Гласные в обратном порядке: ");
            while (st.Count != 0)
            {
                Console.Write(st.Pop() + " ");
            }
            Console.WriteLine();
        }
        public struct one
        {
            public string f;
            public string i;
            public string o;
            public string pol;
            public int age;
            public int zp;
        }
        static void employees()
        {
            StreamReader fileIn = new StreamReader("employees.txt", Encoding.GetEncoding(1251));
            string line;
            Queue people = new Queue();
            one a;
            Console.WriteLine("Возраст менее 30 лет");
            while ((line = fileIn.ReadLine()) != null)
            {
                string[] temp = line.Split(' ');
                a.f = temp[0];
                a.i = temp[1];
                a.o = temp[2];
                a.pol = temp[3];
                a.age = int.Parse(temp[4]);
                a.zp = int.Parse(temp[5]);
                if (a.age < 30)
                    Console.WriteLine(a.f + "\t" + a.i + "\t" + a.o + "\t" + a.pol + "\t" + a.age + "\t" + a.zp);
                else people.Enqueue(a);
            }
            fileIn.Close();

            Console.WriteLine("Возраст 30 лет и старше");
            while (people.Count != 0)
            {
                a = (one)people.Dequeue();
                Console.WriteLine(a.f + "\t" + a.i + "\t" + a.o + "\t" + a.pol + "\t" + a.age + "\t" + a.zp);

            }
        }
        static void chisla()
        {
            StreamWriter file = new StreamWriter("chisla.txt", false);
            Random r = new Random();
            for (int i = 0; i < 25; ++i)
            {
                file.Write(r.Next(-50, 50) + " ");
            }
            file.Close();
            StreamReader fileIn = new StreamReader("chisla.txt");
            string line = fileIn.ReadToEnd();
            string[] lineEl = line.Trim().Split(' ');
            int[] elementInt = lineEl.Select(element1 => int.Parse(element1)).ToArray();
            fileIn.Close();
            Console.Write("Наши числа: ");
            for (int i = 0; i < elementInt.Length; ++i)
            {
                Console.Write(elementInt[i] + " ");
            }
            Console.WriteLine("\nВведите диапазон:");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Queue diapazon = new Queue();
            Queue mensheA = new Queue();
            Queue bolsheB = new Queue();
            for (int i = 0; i < elementInt.Length; ++i)
            {
                if (elementInt[i] >= a && elementInt[i] <= b)
                {
                    diapazon.Enqueue(elementInt[i]);
                }
                else if (elementInt[i] < a)
                {
                    mensheA.Enqueue(elementInt[i]);
                }
                else if (elementInt[i] > b)
                {
                    bolsheB.Enqueue(elementInt[i]);
                }
            }
            Console.Write("В диапазоне: ");
            for (int i = 0; i < diapazon.Count; ++i)
            {
                Console.Write(diapazon.Dequeue() + " ");
            }
            Console.Write("\nМеньше a: ");
            for (int i = 0; i < mensheA.Count; ++i)
            {
                Console.Write(mensheA.Dequeue() + " ");
            }
            Console.Write("\nБольше b: ");
            for (int i = 0; i < bolsheB.Count; ++i)
            {
                Console.Write(bolsheB.Dequeue() + " ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            Console.Write("Введите номер задания: ");
            int oper = int.Parse(Console.ReadLine());
            switch (oper)
            {
                case 1: setOfNumbers(); break;
                case 2: txtFile(); break;
                case 3: employees(); break;
                case 4: chisla(); break;
            }
        }
    }
}