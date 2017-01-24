using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace лаба13
{
    class Program
    {
        static void record()
        {
            StreamWriter file = new StreamWriter("1.txt", false);
            Console.Write("Введите колличество чисел для записи в файл:");
            int n = int.Parse(Console.ReadLine());
            float[] Array = new float[n];
            Random r = new Random();
            for (int i = 0; i < n; ++i)
            {
                Array[i] = r.Next(-50,50);
                file.Write(Array[i] + " ");
            }
            file.Close();
        }
        static void lessN()
        {
            StreamReader fileOut = new StreamReader("1.txt");
            Console.Write("Введите заданное число: ");
            int chislo = int.Parse(Console.ReadLine());
            string line = fileOut.ReadLine();
            string[] element = line.Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < element.Length - 1; ++j)
            {
                int a = int.Parse(element[j]);
                if (a < chislo)
                {
                    sb.Append(a + " ");
                }
            }
            Console.WriteLine(sb.ToString());
            fileOut.Close();
        }
        static void moreZero()
        {
            StreamReader fileOut = new StreamReader("1.txt");
            string line = fileOut.ReadLine();
            string[] element = line.Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < element.Length - 1; ++j)
            {
                int a = int.Parse(element[j]);
                if (a > 0)
                {
                    sb.Append(a + " ");
                }
            }
            Console.WriteLine(sb.ToString());
            fileOut.Close();
        }
        static int average()
        {
            
            StreamReader fileOut = new StreamReader("1.txt");
            string line = fileOut.ReadLine();
            string[] element = line.Split(' ');
            int summ = 0;
            int koll = 0;
            for (int j = 0; j < element.Length - 1; j++)
            {
                if (j % 2 != 0)
                {
                    int a = int.Parse(element[j]);
                    summ += a;
                    koll++;
                }
            }
            if (koll != 0) return summ / koll;
            else return 0;
            fileOut.Close();
        }
        static void sentence()
        {
            StreamWriter sentence = new StreamWriter("Pred.txt", false);
            Console.WriteLine("Введите осмысленное предложение!");
            string stroka = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < stroka.Length; ++i)
            {
                if (!char.IsNumber(stroka[i]))
                {
                    sb.Append(stroka[i]);
                }
            }
            sentence.Write(sb);
            sentence.Close();
        }
        static void certainLetter()
        {
            StreamReader file = new StreamReader("text.txt");
            Console.Write("Буква, на которую начинается: ");
            char bukva = char.Parse(Console.ReadLine());
            string tetx = file.ReadLine();
            string[] slova = tetx.Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach (string s in slova)
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    if (s[0].Equals(bukva))
                    {
                        sb.Append(s + " ");
                        break;
                    }
                }
            }
            Console.WriteLine(sb.ToString());
            file.Close();

        }
        static void certainLength()
        {
            StreamReader file = new StreamReader("text.txt");
            Console.Write("Введите длинну: ");
            int ch = int.Parse(Console.ReadLine());
            string tetx = file.ReadLine();
            string[] slova = tetx.Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach (string s in slova)
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    if (s.Length==ch)
                    {
                        sb.Append(s + " ");
                        break;
                    }
                }
            }
            Console.WriteLine(sb.ToString());
            file.Close();
        }
        static void sameLetterBeginningAndEnd()
        {
            StreamReader file = new StreamReader("text.txt");
            string tetx = file.ReadLine();
            string[] slova = tetx.Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach (string s in slova)
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    if (s[0].Equals(s[s.Length-1]))
                    {
                        sb.Append(s + " ");
                        break;
                    }
                }
            }
            Console.WriteLine(sb.ToString());
            file.Close();
        }
        static void sameLetterBeginningLastWord()
        {
            StreamReader file = new StreamReader("text.txt");
            string tetx = file.ReadLine();
            string[] slova = tetx.Split(' ');
            string posl = slova[slova.Length - 1];
            StringBuilder sb = new StringBuilder();
            foreach (string s in slova)
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    if (s[0].Equals(posl[0]))
                    {
                        sb.Append(s + " ");
                        break;
                    }
                }
            }
            Console.WriteLine(sb.ToString());
            file.Close();
        }
        static void fileOne()
        {
            BinaryWriter file1 = new BinaryWriter(new FileStream("1.dat", FileMode.Create));
            Console.Write("Введите количество цифр, записываемых в первый файл: ");
            int kol = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < kol; ++i)
            {
                int t = r.Next(-100, 100);
                file1.Write(t);
            }
            file1.Close();
        }
        static void fileTwo()
        {
            BinaryWriter file1 = new BinaryWriter(new FileStream("2.dat", FileMode.Create));
            Console.Write("Введите количество цифр, записываемых во второй файл: ");
            int kol = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < kol; ++i)
            {
                int t = r.Next(-100, 100);
                file1.Write(t);
            }
            file1.Close();
        }
        static void followedByAMinimumNumber()
        {
            fileOne();
            StringBuilder sb = new StringBuilder();
            FileStream f = new FileStream("1.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(f);
            long n = f.Length / 4;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = fIn.ReadInt32();
                sb.Append(array[i] + " ");
            }
            Array.Sort(array);
            Console.WriteLine(sb.ToString());
            Console.WriteLine("Самое близкое к минимальному: " + array[1]);
            fIn.Close();
            f.Close();

        }
        static void whereMore()
        {
            fileOne();
            fileTwo();
            StringBuilder sbFOne = new StringBuilder();
            StringBuilder sbFTwo = new StringBuilder();
            FileStream fOne = new FileStream("1.dat", FileMode.Open);
            FileStream fTwo = new FileStream("2.dat", FileMode.Open);
            BinaryReader fOneIn = new BinaryReader(fOne);
            BinaryReader fTwoIn = new BinaryReader(fTwo);
            long lengthFOne = fOne.Length / 4;
            long lengthFTwo = fTwo.Length / 4;
            int[] arrayFOne = new int[lengthFOne];
            int[] arrayFTwo = new int[lengthFTwo];
            for (int i = 0; i < arrayFOne.Length; i++)
            {
                arrayFOne[i] = fOneIn.ReadInt32();
                sbFOne.Append(arrayFOne[i] + " ");
            }
            Console.Write("Числа первого файла - " + sbFOne.ToString());
            for (int j = 0; j < arrayFTwo.Length; j++)
            {
                arrayFTwo[j] = fTwoIn.ReadInt32();
                sbFTwo.Append(arrayFTwo[j] + " ");
            }
            Console.WriteLine();
            Console.Write("Числа второго файла - {0}\n", sbFTwo.ToString());
            fOne.Close();
            fTwo.Close();
            fOneIn.Close();
            fTwoIn.Close();
            int numberPositiveFOne = 0, negativeNumberFOne = 0, zeroFOne = 0;
            int numberPositiveFTwo = 0, negativeNumberFTwo = 0, zeroFTwo = 0;
            for (int i = 0; i < arrayFOne.Length; ++i)
            {
                if (arrayFOne[i] > 0) 
                { 
                    numberPositiveFOne++; 
                }
                else if (arrayFOne[i] == 0) 
                { 
                    zeroFOne++; 
                }
                else if (arrayFOne[i] < 0) 
                { 
                    negativeNumberFOne++; 
                }
            }
            for (int j = 0; j < arrayFTwo.Length; j++)
            {
                if (arrayFTwo[j] > 0) 
                { 
                    numberPositiveFTwo++; 
                }
                else if (arrayFTwo[j] == 0) 
                { 
                    zeroFTwo++; 
                }
                else if (arrayFTwo[j] < 0) 
                { 
                    negativeNumberFTwo++; 
                }
            }
            if (numberPositiveFOne > numberPositiveFTwo) Console.WriteLine("Положительных элементов больше в первом файле!");
            else if (numberPositiveFOne == numberPositiveFTwo) Console.WriteLine("Одинаковое колличество положительных элементов в двух файлах!");
            else if (numberPositiveFOne < numberPositiveFTwo) Console.WriteLine("Положительных элементов больше во втором файле!");
            if (zeroFOne > zeroFTwo) Console.WriteLine("Нулевых элементов больше в первом файле!");
            else if (zeroFOne == zeroFTwo) Console.WriteLine("Одинаковое колличество нулевых элементов в двух файлах!");
            else if (zeroFOne < zeroFTwo) Console.WriteLine("Нулевых элементов больше во втором файле!");
            if (negativeNumberFOne > negativeNumberFTwo) Console.WriteLine("Отрицательных элементов больше в первом файле!");
            else if (negativeNumberFOne == negativeNumberFTwo) Console.WriteLine("Одинаковое колличество отрицательных элементов в двух файлах!");
            else if (negativeNumberFOne < negativeNumberFTwo) Console.WriteLine("Отрицательных элементов больше во втором файле!");
        }
        static void increase()
        {
            fileOne();
            StringBuilder sb = new StringBuilder();
            FileStream f = new FileStream("1.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(f);
            long n = f.Length / 4;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = fIn.ReadInt32();
                sb.Append(array[i] + " ");
            }
            Console.WriteLine(sb.ToString());
            int probeg = 1;
            for (int i = 1; i < array.Length; ++i)
            {
                if (array[i] >= array[i - 1])
                {
                    probeg++;
                }
            }
            if (probeg == n) Console.WriteLine("Числа упорядочены по возростанию!");
            else Console.WriteLine("Числа НЕ упорядочены по возростанию!");
            f.Close();
            fIn.Close();
        }
        static void alternatingSequence()
        {
            fileOne();
            StringBuilder sb = new StringBuilder();
            FileStream f = new FileStream("1.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(f);
            long n = f.Length / 4;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = fIn.ReadInt32();
                sb.Append(array[i] + " ");
            }
            Console.WriteLine(sb.ToString());
            int probeg1 = 0, probeg2 = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (i % 2 == 0 && array[i] < 0 || i % 2 != 0 && array[i] >= 0)
                {
                    probeg1++;
                }
                else if (i % 2 == 0 && array[i] >= 0 || i % 2 != 0 && array[i] < 0)
                {
                    probeg2++;
                }
            }
            if (probeg1 == n) Console.WriteLine("Числа образуют знакопеременную последовательность!");
            else if (probeg2 == n) Console.WriteLine("Числа образуют знакопеременную последовательность!");
            else Console.WriteLine("Числа НЕ образуют знакопеременную последовательность!");
            f.Close();
            fIn.Close();
        }
        static void Main()
        {
            Console.Write("Введите операцию:");
            int oper = int.Parse(Console.ReadLine());
            switch (oper)
            {
                case 1:
                    record();
                    Console.WriteLine("Нужно вывести на экран компоненты, меньшие заданного числа!");
                    lessN();
                    Console.WriteLine("Далее нужно вывести все положительные компоненты файла");
                    moreZero();
                    Console.WriteLine("И в последнюю очередь нужно посчитать среднее арифмитическое элементов, стоящих на четных позициях!");
                    int x = average();
                    Console.WriteLine(x);
                    break;
                case 2:
                    Console.WriteLine("Найболее близкое к минимальному!");
                    followedByAMinimumNumber();
                    Console.WriteLine("В каком из файлов больше положительных, отрицательных и нулевых значений");
                    whereMore();
                    Console.WriteLine("Определить, являются ли числа в первом файле упорядоченными по возрастанию");
                    increase();
                    Console.WriteLine("Определить, образуют ли числа в первом файле знакопеременную последовательность чисел");
                    alternatingSequence();
                    break;
                case 3:
                    Console.WriteLine("Вывести все элементы, кроме чисел!");
                    sentence();
                    break;
                case 4:
                    Console.WriteLine("Вывести слова из файла, начинающиеся на определенную букву!");
                    certainLetter();
                    Console.WriteLine("Вывести на экран все слова, длина которых равна заданному числу");
                    certainLength();
                    Console.WriteLine("Вывести на экран все слова, которые начинаются и заканчиваются одной буквой");
                    sameLetterBeginningAndEnd();
                    Console.WriteLine("Вывести на экран все слова, которые начинаются на ту же букву, что и последнее слово");
                    sameLetterBeginningLastWord();
                    break;
                
            }

        }
    }
}
