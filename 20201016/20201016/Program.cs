using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201016
{
    class Program
    {
        static int[] szamok = { -14, 23, 1, -48, -43, 28, -77, -33, -95, 38, -9, 98, -61, 58, 21, 87, 41, -65, -22, -20, 56, -75, 80, -77, 100, 67, 22, 8, -78, -6 };
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            feladat5();
            //feladat6();
            //feladat10();
            Console.WriteLine("Enter");
            Console.ReadLine();
        }
        static void feladat1()
        {
            Console.WriteLine("1.Feladat");
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok.Length > 0)
                {
                    Console.WriteLine("Van");
                    break;
                }
                else
                {
                    Console.WriteLine("Nincs");
                    break;
                }
            }
        }
        static void feladat2()
        {
            Console.WriteLine("2.Feladat");
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine("Ennyi eleme van: {0}" ,szamok[i]);
            }
        }
        static void feladat3()
        {
            Console.WriteLine("3. Feladat");

                Console.WriteLine("A legkisebb szám: {0}" ,szamok.Min());
        }
        static void feladat4()
        {
            for (int i = 0; i < szamok.Length; i++)
            {
              if (szamok[i] %33==0)
              {
                Console.WriteLine("Ez a szám osztható 33-al: {0}", szamok[i]);
              }
            }
        }
        static void feladat5()
        {
            int atlag = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                atlag=szamok.Sum%
            }
        }
        static void feladat6()
        {
            Console.WriteLine("6.Feladat");
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] < 0)
                {
                    Console.WriteLine("Hamis");
                    break;
                }
                else
                {
                    Console.WriteLine("Igaz");
                    break;
                }
            }
        }
        static void feladat10()
        {
            Console.WriteLine("10.feladat");
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] %5==0)
                {
                    Console.WriteLine("Az 5-el osztható számok: {0}", szamok[i]);
                }
            }
        }
    }
}
