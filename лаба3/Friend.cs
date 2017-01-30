using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba3
{
    class Friend : Phonebook
    {
        public string name, address, number, dateOfBirth;
        public Friend() { }
        public Friend(string name, string address, string number, string dateOfBirth)
        {
            this.name = name;
            this.address = address;
            this.number = number;
            this.dateOfBirth = dateOfBirth;
        }
        public override void print()
        {
            Console.WriteLine("{0} \t {1} \t {2} \t {3}", name, address, dateOfBirth, number);
        }
        public override void Search(string[] stMas, char bykva)
        {
            foreach (string x in stMas)
            {
                for (int i = 0; i < x.Length; ++i)
                {
                    if (x[0].Equals(bykva) || x.ToLower()[0].Equals(bykva))
                    {
                        Console.WriteLine("Это " + x + " и вот вся информация о нем: ");
                        break;
                    }
                }
            }
        }
    }
}
