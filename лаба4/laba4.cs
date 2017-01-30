using System;
using System.Text;
using System.IO;
using System.Collections;

namespace laba43
{
    class MainClass
    {
        static void vibor(Hashtable diski)
        {
            Console.Write("Выбери номер задачи:");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1: AddDisk(diski); break;
                case 2: Show(diski); break;
                case 3: DeleteDisk(diski); break;
                case 4: AddSong(diski); break;
                case 5: DeleteSong(diski); break;
            }
        }

        static void AddDisk(Hashtable diski)
        {
            Console.Write("Введите название диска, который хотите добавить:");
            string name = Console.ReadLine();
            Hashtable songs = new Hashtable();
            Console.Write("Введите количество песен в новом диске: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите название песени: ");
                string songname = Console.ReadLine();
                songs.Add((i + 1), songname);
            }
            diski.Add(name, songs);
            vibor(diski);
        }
        static void Show(Hashtable diski)
        {
            Console.WriteLine("Список дисков и песен: ");
            foreach (DictionaryEntry a in diski)
            {
                Console.WriteLine(a.Key + " ");
                foreach (DictionaryEntry aa in (Hashtable)a.Value)
                {
                    Console.WriteLine(" " + aa.Key + " " + aa.Value);
                }
            }
            vibor(diski);
        }
        static void DeleteDisk(Hashtable diski)
        {
            Console.Write("Введите название диска, который надо удалить: ");
            string delname = Console.ReadLine();
            diski.Remove(delname);
            vibor(diski);
        }
        static void AddSong(Hashtable diski)
        {
            Console.Write("Введите название диска, в который нужно добавить песню: ");
            string findDisk = Console.ReadLine();
            int count = 0;
            if (diski.ContainsKey(findDisk))
            {
                Console.WriteLine("Введите название песни: ");
                string newSong = Console.ReadLine();
                foreach (DictionaryEntry p in (Hashtable)diski[findDisk])
                {
                    count++;
                }
                ((Hashtable)diski[findDisk]).Add((count + 1), newSong);
            }
            else Console.WriteLine("Нет такого диска!");
            vibor(diski);
        }
        static void DeleteSong(Hashtable diski)
        {
            Console.WriteLine("Введите диск, с которого будем удалять трек: ");
            string disk = Console.ReadLine();
            if (diski.ContainsKey(disk))
            {
                Console.WriteLine("Введите песню, которую будем удалять: ");
                string delsong = Console.ReadLine();
                if (((Hashtable)diski[disk]).ContainsValue(delsong))
                {
                    foreach (DictionaryEntry i in (Hashtable)diski[disk])
                    {
                        if (delsong == (string)i.Value)
                        {
                            ((Hashtable)diski[disk]).Remove(i.Key);
                            break;
                        }
                    }
                }
                else Console.WriteLine("Нет такой песни!");
            }
            else Console.WriteLine("Нет такого диска!");
            vibor(diski);
        }

        public static void Main(string[] args)
        {
            Console.Write("Введите количество дисков: ");
            int kol = int.Parse(Console.ReadLine());
            Hashtable diski = new Hashtable();
            for (int i = 0; i < kol; i++)
            {
                Hashtable songs = new Hashtable();
                Console.Write("Введите название диска №" + (i + 1) + ":");
                string name = Console.ReadLine();
                Console.Write("Введите количество песен на этом диске: ");
                int n = int.Parse(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Введите название песни №" + (j + 1) + ":");
                    string songname = Console.ReadLine();
                    songs.Add((j + 1), songname);
                }
                diski.Add(name, songs);
            }
            vibor(diski);
        }
    }
}