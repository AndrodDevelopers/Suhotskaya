using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace лаба11
{
    class laba11
    {
        static void deleteSymbol() // удаляет символы из строки
        {
            Console.Write("Введите строку: ");
            string stroka = Console.ReadLine();
            Console.Write("Введите удаляемый символ: ");
            string symbol = Console.ReadLine();
            string result = stroka.Replace(symbol, string.Empty);
            Console.Write("\nРезультат: {0}", result);
        }
        static void swaps() // меняет первый со вторым, второй с третим
        {
            Console.Write("Введите строку: ");
            string stroka = Console.ReadLine();
            char[] str = stroka.ToCharArray();
            for (int i = 0; i < str.Length - 1; i+=2)
            {
                char zam = str[i];
                str[i] = str[i + 1];
                str[i + 1] = zam;
            }
            Console.WriteLine(str);
        }
        static void howOften() // какой символ встречается чаще
        {
            Console.Write("Введите строку: ");
            string stroka = Console.ReadLine();
            Console.Write("первый символ: ");
            char symbol1 = char.Parse(Console.ReadLine());
            Console.Write("второй символ: ");
            char symbol2 = char.Parse(Console.ReadLine());
            int kolSymbol1 = 0;
            int kolSymbol2 = 0;
            for (int i = 0; i < stroka.Length; ++i)
            {
                if (stroka[i] == symbol1) 
                {
                    kolSymbol1++;
                }
                else if (stroka[i] == symbol2)
                {
                    kolSymbol2++;
                }
            }
            if (kolSymbol1 > kolSymbol2)
            {
                Console.WriteLine("Первый символ встречается чаще! Целых {0} раз!!!", kolSymbol1);
            }
            else Console.WriteLine("Второй символ встречается чаще! Целых {0} раз!!!", kolSymbol2);
        }
        static void totalNumber() // количество вхождений x и y
        {
            Console.Write("Введите строку: ");
            string stroka = Console.ReadLine();
            char symbol1 = 'x';
            char symbol2 = 'y';
            int kolSymbols = 0;
            for (int i = 0; i < stroka.Length; ++i)
            {
                if (stroka[i] == symbol1 || stroka[i] == symbol2)
                {
                    kolSymbols++;
                }
            }
            Console.WriteLine("Количество вхождений символов x и y: " + kolSymbols);
        }
        static void kollLetter() // считает количество букв
        {
            Console.Write("Введите строку: ");
            string stroka = Console.ReadLine();
            int koll = 0;
            for (int i = 0; i < stroka.Length; ++i)
            {
                if (char.IsLetter(stroka[i]))
                {
                    koll++;
                }
            }
            Console.Write("Количество букв: {0}\n\r", koll);
        }
        static void messageSizeN() // выводит слова опредленной длинны
        {
            Console.Write("Введите строку: ");
            string stroka = Console.ReadLine();
            char [] div = { ' ',',','!','.' };
            string[] str = stroka.Split(div);
            Console.Write("Введите длинну N: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i].Length < N && !str[i].Equals(""))
                {

                    Console.WriteLine(str[i]);
                }
            }
        }
        static void uppercase() // начинаются с прописной
        {
            StringBuilder sb = new StringBuilder();
            Console.Write("Введите строку: ");
            string strochka = Console.ReadLine();
            string[] stroka = strochka.Split(' ');
            foreach (string str in stroka)
            {
                if (str[0].Equals(str.ToUpper()[0]))
                {
                    sb.Append(str);
                    sb.Append(" ");
                }
            }
            Console.WriteLine(sb.ToString());
        }
        static void containsANumber() // есть хоть одна цифра в слове
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Введите строку: ");
            string stroka = Console.ReadLine();
            string[] slova = stroka.Split(' ');
            foreach (string s in slova)
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    if (char.IsDigit(s[i]))
                    {
                        sb.Append(s);
                        sb.Append(" ");
                        break;
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
        static void deleteWord() // удалить слова с символом
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Введите строку: ");
            string stroka = Console.ReadLine();
            sb.Append(stroka);
            Console.Write("Введите символ: ");
            char symbol = char.Parse(Console.ReadLine());
            string[] slova = stroka.Split(' ');
            foreach (string s in slova)
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    if (s[i].Equals(symbol))
                    {
                        sb.Replace(s, string.Empty);
                        break;
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
        static void deleteWordSymbol() // удалить слова заканчивающиеся на символ
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Введите строку: ");
            string stroka = Console.ReadLine();
            sb.Append(stroka);
            Console.Write("Введите символ: ");
            char symbol = char.Parse(Console.ReadLine());
            string[] slova = stroka.Split(' ');
            foreach (string s in slova)
            {
                for (int i = 0; i < s.Length - 1; ++i)
                {
                    if (s[s.Length - 1].Equals(symbol))
                    {
                        sb.Replace(s, string.Empty);
                        break;
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
        static int code()
        {
            int code = 0;
            Console.WriteLine("Введите ФИО: ");
            string fio = Console.ReadLine();
            string [] slova = fio.Split(' ');
            char[] Array = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            foreach (string s in slova)
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    for (int j = 0; j < Array.Length; ++j)
                    {
                        if (s[i].Equals(Array[j]))
                        {
                            code += j + 1;
                        }
                    }
                }
            }
            code = (code / 100) + ((code % 100) % 10) + ((code % 100) / 10);
            code = (code / 10) + (code % 10);
            return code;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    deleteSymbol();
                    break;
                case 2:
                    swaps();
                    break;
                case 3:
                    howOften();
                    break;
                case 4:
                    totalNumber();
                    break;
                case 5:
                    kollLetter();
                    break;
                case 6:
                    messageSizeN();
                    break;
                case 7:
                    uppercase();
                    break;
                case 8:
                    containsANumber();
                    break;
                case 9:
                    deleteWord();
                    break;
                case 10:
                    deleteWordSymbol();
                    break;
                case 11:
                    int result = code();
                    Console.WriteLine(result);
                    break;

            }
        }
    }
}