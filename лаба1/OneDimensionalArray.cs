using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba1
{
    class OneDimensionalArray
    {
        public int n;
        public int[] IntArray;
        public OneDimensionalArray() { }
        public OneDimensionalArray(int n)
        {
            this.n = n;
            IntArray = new int[n];
            for (int i = 0; i < n; ++i)
            {
                IntArray[i] = 0;
            }
        }
        public OneDimensionalArray(int n,int a,int b)
        {
            this.n = n;
            IntArray = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; ++i)
            {
                IntArray[i] = r.Next(a, b);
            }
        }
        public OneDimensionalArray(int a, int b)
        {
            Random r = new Random();
            Console.WriteLine(this.n);
            IntArray = new int[this.n];
            for (int i = 0; i < this.n; ++i)
            {
                IntArray[i] = r.Next(a, b);
                Console.WriteLine(IntArray[i] + " ");
            }
            //Array.Sort(IntArray);
        }
        public void plus()
        {
            for (int i = 0; i < IntArray.Length; ++i)
            {
                IntArray[i] += 1;
            }
        }
        public void minus()
        {
            for (int i = 0; i < IntArray.Length; ++i)
            {
                IntArray[i] -= 1;
            }
        }
        public void trueFalse()
        {
            int probeg = 1;
            for (int i = 1; i < IntArray.Length; ++i)
            {
                if (IntArray[i] >= IntArray[i - 1])
                {
                    probeg++;
                }
            }
            if (probeg == IntArray.Length) Console.WriteLine("false");
            else Console.WriteLine("true");
        }
        public void multiplication(int skal)
        {
            for (int i = 0; i < IntArray.Length; ++i)
            {
                IntArray[i] *= skal;
            }
        }
        public void print(string name)
        {
            Console.Write(name + ": ");
            for (int i = 0; i < IntArray.Length; ++i)
            {
                Console.Write("{0} ", IntArray[i]);
            }
            Console.WriteLine();
        }
        public int[] keyboardPrint()
        {
            Console.Write("Размерность массива:");
            n = int.Parse(Console.ReadLine());
            IntArray = new int[n];
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.Write("a[{0}] = ", i);
                IntArray[i] = int.Parse(Console.ReadLine());
            }
            return IntArray;
        }
        public void Sort()
        {
            Array.Sort(IntArray);
        }
    }
}
