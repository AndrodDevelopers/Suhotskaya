using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba3
{
    class Person : Phonebook
    {
        public string name, address, number;
        public Person() { }
        public Person(string name, string address, string number)
        {
            this.name = name;
            this.address = address;
            this.number = number;
        }
        public override void print()
        {
            Console.WriteLine("{0} \t {1} \t {2}", this.name, this.address, this.number);
        }
        public override void Search(string[] stMas, char bykva)
        {
            foreach (string x in stMas)
            {
                for (int i = 0; i < x.Length; ++i)
                {
                    if (x[0].Equals(bykva)||x.ToLower()[0].Equals(bykva))
                    {
                        Console.WriteLine("Это " + x);
                        break;
                    }
                }
            }
        }
    }
}
