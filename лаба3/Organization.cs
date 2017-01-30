using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba3
{
    class Organization : Phonebook 
    {
        public string name, address, contactPerson, number, fax;
        public Organization() { }
        public Organization(string name, string address, string number, string fax, string contactPerson)
        {
            this.name = name;
            this.address = address;
            this.number = number;
            this.fax = fax;
            this.contactPerson = contactPerson;
        }
        public override void print()
        {
            Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", name, address, number, fax, contactPerson);
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
