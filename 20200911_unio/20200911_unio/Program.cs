using System;
using System.Collections.Generic;

namespace _20200911_unio
{
    class Program
    {
        static int[] egyik = new int[15];
        static List<int> masik = new List<int>();
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            feltolt();
            unio();
        }
        static void feltolt()
        {
            for (int i = 0; i < egyik.Length; i++)
            {
                egyik[i] = rnd.Next(0, 50);
                for (int j = 0; j < i; j++)
                {
                    if (egyik[i]==egyik[j])
                    {
                        i = i - 1;
                        break;
                    }
                }
            }
            Console.Write("A: ");
            foreach (var item in egyik)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            int gen;
            for (int i = 0; i < 30; i++)
            {
                gen = rnd.Next(0, 100);
                if (masik.Contains(gen))
                {
                    i = i - 1;
                }
                else
                {
                    masik.Add(gen);
                }
            }
            Console.Write("B: ");
            foreach (var item in masik)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
        static void unio()
        {
            List<int> unios = new List<int>();
            foreach (var item in egyik)
            {
                unios.Add(item);
            }
            foreach (var item in masik)
            {
                if (!unios.Contains(item))
                {
                    unios.Add(item);
                }
            }
            Console.Write("Unió: ");
            foreach (var item in unios)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
