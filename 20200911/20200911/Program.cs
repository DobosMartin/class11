using System;
using System.Collections.Generic;

namespace _20200911
{
    class Program
    {
        static int[] egeszek;
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            feltoltes();
            kivalogatas();
            szetvalogatas();
        }
        static void feltoltes()
        {
            Console.Write("Add meg az elemek számát: ");
            int n = int.Parse(Console.ReadLine());
            egeszek = new int[n];
            for (int i = 0; i < egeszek.Length; i++)
            {
                egeszek[i] = rnd.Next(-100, 200);
                for (int j = 0; j < i; j++)
                {
                    if (egeszek[j]==egeszek[i])
                    {
                        i = i - 1;
                        break;
                    }
                }
            }
            foreach (var item in egeszek)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
        static void kivalogatas()
        {
            List<int> paratlanok = new List<int>();
            foreach (var item in egeszek)
            {
                if (item%2==1)
                {
                    paratlanok.Add(item);
                }
            }
            Console.Write("Páratlanok: ");
            foreach (var item in paratlanok)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();
        }
        static void szetvalogatas()
        {
            List<int> negativ = new List<int>();
            List<int> nemnegativ = new List<int>();
            for (int i = 0; i < egeszek.Length; i++)
            {
                if (egeszek[i]<0)
                {
                    negativ.Add(egeszek[i]);
                }
                else
                {
                    nemnegativ.Add(egeszek[i]);
                }
            }
            Console.Write("Negatívok: ");
            foreach (var item in negativ)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.Write("Nemnegatívok: ");
            foreach (var item in nemnegativ)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
