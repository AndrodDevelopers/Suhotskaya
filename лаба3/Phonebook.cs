using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba3
{
    abstract class Phonebook
    {
        abstract public void print();
        abstract public void Search(string[] stMas, char bykva);
    }
}
