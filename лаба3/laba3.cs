using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace laba3
{
    class laba3
    {
        static void abstractFigure()
        {
            StreamReader triangle = new StreamReader("Triangle.txt");
            string lineTriangle = triangle.ReadLine();
            string[] elemTriangle = lineTriangle.Split(' ');
            int[] elementIntTriangle = elemTriangle.Select(element1 => int.Parse(element1)).ToArray();
            triangle.Close();

            StreamReader rectangle = new StreamReader("Rectangle.txt");
            string lineRectangle = rectangle.ReadLine();
            string[] elemRectangle = lineRectangle.Split(' ');
            int[] elementIntRectangle = elemRectangle.Select(element2 => int.Parse(element2)).ToArray();
            rectangle.Close();

            StreamReader circle = new StreamReader("Circle.txt");
            int radCircle = int.Parse(circle.ReadLine());
            circle.Close();


            Figure[] figura = new Figure[3]; // массив ссылок
            figura[0] = new Triangle(elementIntTriangle[0], elementIntTriangle[1], elementIntTriangle[2]);
            figura[1] = new Rectangle(elementIntRectangle[0], elementIntRectangle[1]);
            figura[2] = new Circle(radCircle);
            foreach (Figure x in figura)
            {
                x.print();
                double perimeter = x.perimeter();
                double area = x.area();
                Console.WriteLine("Периметр: {0}", perimeter);
                Console.WriteLine("Площадь: {0}", area);
            }
        }
        public struct person
        {
            public string name;
            public string address;
            public int number;
        }
        public struct organization
        {
            public string name;
            public string address;
            public int number;
            public int fax;
            public string contentPerson;
        }
        public struct friend
        {
            public string name;
            public string address;
            public string data;
            public int number;
        }
        static void abstractPhonebook()
        {
            StreamReader person = new StreamReader("Person.txt", Encoding.GetEncoding(1251));
            string line;
            StreamReader organization = new StreamReader("Organization.txt", Encoding.GetEncoding(1251));
            string line2;
            StreamReader friend = new StreamReader("Friend.txt", Encoding.GetEncoding(1251));
            string line3;
            person a;
            organization b;
            friend c;
            Console.WriteLine("СЕЙЧАС БУДЕТ ПОИСК!");
            Console.Write("Введите букву: ");
            char bykva = char.Parse(Console.ReadLine());
            while ((line = person.ReadLine()) != null)
            {
                string[] elementP = line.Split(' ');
                a.name = elementP[0];
                a.address = elementP[1];
                a.number = int.Parse(elementP[2]);
                if (a.name[0].Equals(bykva)||a.name.ToLower()[0].Equals(bykva))
                {
                    Console.WriteLine(a.name + "\t" + a.address + "\t" + a.number);
                }
            }
            while ((line2 = organization.ReadLine()) != null)
            {
                string[] elementO = line2.Split(' ');
                b.name = elementO[0];
                b.address = elementO[1];
                b.number = int.Parse(elementO[2]);
                b.fax = int.Parse(elementO[3]);
                b.contentPerson = elementO[4];
                if (b.name[0] == bykva||b.name.ToLower()[0].Equals(bykva))
                {
                    Console.WriteLine(b.name + "\t" + b.address + "\t" + b.number + "\t" + b.fax + "\t" + b.contentPerson);
                }
            }
            while ((line3 = friend.ReadLine()) != null)
            {
                string[] elementF = line3.Split(' ');
                c.name = elementF[0];
                c.address = elementF[1];
                c.data = elementF[2];
                c.number = int.Parse(elementF[3]);
                if (c.name[0] == bykva||c.name.ToLower()[0].Equals(bykva))
                {
                    Console.WriteLine(c.name + "\t" + c.address + "\t" + c.data + "\t" + c.number);
                }
            }
            friend.Close();
            organization.Close();
            person.Close();
                        
            /*Phonebook[] phonebook = new Phonebook[8];
            phonebook[0] = new Person(line[0], line[1], line[2]);
            phonebook[1] = new Person(line[3], line[4], line[5]);
            phonebook[2] = new Person(line[6], line[7], line[8]);
            /*phonebook[3] = new Organization(lineOrganization[0],lineOrganization[1],lineOrganization[2],lineOrganization[3],lineOrganization[4]);
            phonebook[4] = new Organization(lineOrganization[5], lineOrganization[6], lineOrganization[7], lineOrganization[8], lineOrganization[9]);
            phonebook[5] = new Organization(lineOrganization[10], lineOrganization[11], lineOrganization[12], lineOrganization[13], lineOrganization[14]);
            phonebook[6] = new Organization(lineOrganization[15], lineOrganization[16], lineOrganization[17], lineOrganization[18], lineOrganization[19]);
            phonebook[7] = new Friend(lineFriend[0], lineFriend[1], lineFriend[2], lineFriend[3]);
            
             */
        }
        static void Main()
        {
            Console.Write("Введите номер задания: ");
            int oper = int.Parse(Console.ReadLine());
            switch (oper)
            {
                case 1:
                    abstractFigure();
                    break;
                case 2:
                    abstractPhonebook();
                    break;
            }
            
        }
    }
}
