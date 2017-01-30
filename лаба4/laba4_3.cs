using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace Laba4_3
{
    class Program
    {
        public static void print(Hashtable di)
        {
            Console.WriteLine("Список дисков и песен: ");
            foreach (DictionaryEntry a in di)
            {
                Console.WriteLine(a.Key + "\t" + di[a]);
                foreach (DictionaryEntry aa in (Hashtable)a.Value)
                {
                    Console.WriteLine("\t" + aa.Value);
                }
            }
        }
        public static void printDisk(Hashtable di)
        {
            Console.Write("Какой диск хотите посмотреть? ");
            string disk = Console.ReadLine();
            Console.WriteLine(disk);
            char y = 'y'; char n = 'n';
            if (di.ContainsKey(disk))
            {
                foreach (DictionaryEntry p in (Hashtable)di[disk])
                {
                    Console.WriteLine("\t" + p.Value);
                }
            }
            else Console.WriteLine("Нет такого диска! Записать? ( y - да, n - нет)");
            char res = char.Parse(Console.ReadLine());
            if (y.Equals(res))
            {
                addDisk(di);
            }
            else if (n.Equals(res))
            {
                Console.WriteLine("Тогда покажу вам какие диски у вас есть!");
                print(di);
            }
            
        }
        public static void addDisk(Hashtable di)
        {
            Console.Write("Введите название нового диска: ");
            string newName = Console.ReadLine();
            Hashtable songs = new Hashtable();
            Console.Write("Введите колличество песен на новом диске: ");
            int kollNewPesen = int.Parse(Console.ReadLine());
            for (int i = 0; i < kollNewPesen; ++i)
            {
                Console.Write("Введите название " + (i + 1) + " песни: ");
                string newNamePesni = Console.ReadLine();
                songs.Add((i + 1), newNamePesni);
            }
            di.Add(newName, songs);
            print(di);
        }
        public static void deleteDisk(Hashtable di)
        {
            Console.Write("Введите название диска, который вы хотите удалить: ");
            string delete = Console.ReadLine();
            di.Remove(delete);
            print(di);
        }
        public static void addPesni(Hashtable di)
        {
            Console.Write("Введите название диска, на который хотите записать песни: ");
            string name = Console.ReadLine();
            int count = 0;
            if (di.ContainsKey(name))
            {
                Console.Write("Введите колличество песен: ");
                int koll = int.Parse(Console.ReadLine());
                for (int i = 0; i < koll; ++i)
                {
                    Console.WriteLine("Введите название песни: ");
                    string song = Console.ReadLine();
                    foreach (DictionaryEntry p in (Hashtable)di[name])
                    {
                        count++;
                    }
                    ((Hashtable)di[name]).Add((count + 1), song);
                }
                print(di);
            }
            else Console.WriteLine("Такого диска нет в списке!!!");
        }
        public static void deletePesni(Hashtable di)
        {
            Console.Write("Введите название диска, с которого хотите удалить песни: ");
            string name = Console.ReadLine();
            if (di.ContainsKey(name))
            {
                Console.Write("Введите название песни: ");
                string delete = Console.ReadLine();
                if (((Hashtable)di[name]).ContainsValue(delete))
                {
                    foreach (DictionaryEntry i in (Hashtable)di[name])
                    {
                        if (delete == (string)i.Value)
                        {
                            ((Hashtable)di[name]).Remove(i.Key);
                            break;
                        }
                    }
                    print(di);
                }
                else Console.WriteLine("Нет такой песни!");
            }
            else Console.WriteLine("Нет такого диска!");
        }
        static void Main(string[] args)
        {
            Console.Write("Введите колличество дисков: ");
            int kollDisk = int.Parse(Console.ReadLine());
            Hashtable diski = new Hashtable();
            for (int i = 0; i < kollDisk; ++i)
            {
                Hashtable songs = new Hashtable();
                Console.Write("Введите название " + (i + 1) + " диска: ");
                string name = Console.ReadLine();
                Console.Write("Введите колличесво песен на " + (i + 1) + " диске: ");
                int kollPesen = int.Parse(Console.ReadLine());
                for (int j = 0; j < kollPesen; ++j)
                {
                    Console.Write("Название " + (j + 1) + " песни: ");
                    string namePesni = Console.ReadLine();
                    songs.Add(j + 1, namePesni);
                }
                diski.Add(name, songs);
            }
            print(diski);
            addDisk(diski);
            deleteDisk(diski);
            addPesni(diski);
            deletePesni(diski);
            printDisk(diski);
        }
    }
}
