using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200925
{
    class Program
    {
        static Random rnd=new Random();
        static void Main(string[] args)
        {
            int r = 12;
            double f = 25.378;
            string g = "gumi kacsa";
            e1();
            Console.WriteLine();
            Console.ReadLine();
        }
        static void e1()
        {
            int a = 28, b = 17, c = 6;
            Console.WriteLine("{0} * {1} = {2}",a,b,a*b);
            Console.WriteLine("{0} / {1} = {2}",b,c,b/c);
            Console.WriteLine("{0} / {1} = {2:0.00}",b,c,(double)b/c);
            Console.WriteLine("{0} / {1} = {2}",b,c,Math.Round((double)b/c, 2));
            Console.WriteLine("{0} / {1} = {2}",b,c,Math.Ceiling((double)b/c));
            Console.WriteLine("{0} / {1} = {2}",b,c,Math.Floor((double)b/c));
            Console.WriteLine("{0} % {1} = {2}",b,c,b%c);
            e2();
        }
        static void e2()
        {
            int a = 5, b = 6, c = 7;
            Console.WriteLine("A(z) {0} négyzete: {1}, köbe: {2}", a, Math.Pow(a, 2),Math.Pow(a, 3));
            Console.WriteLine("A(z) {0} négyzete: {1}, köbe: {2}", b, Math.Pow(b, 2),Math.Pow(b, 3)); 
            Console.WriteLine("A(z) {0} négyzete: {1}, köbe: {2}", c, Math.Pow(c, 2),Math.Pow(c, 3));
            n1();
        }
        static void n1()
        {
            int szam = rnd.Next(10, 20);
            if (szam < 16)
            {
                Console.WriteLine("10*{0}={1}", szam, 10 * szam);
            }
            else 
            {
                Console.WriteLine("{0} / 3 = {1:0.00}", szam, (double)szam / 3);
            }
            n2();
        }
        static void n2()
        {
            int szam = rnd.Next(1, 101);
            if (szam%2==0)
            {
                Console.WriteLine("{0}, Ez a szám páros",szam);
            }
            else
            {
                Console.WriteLine("{0}, Ez a szám páratlan",szam);
            }
            n3();
        }
        static void n3()
        {
            int szam = rnd.Next(1, 51);
            if (szam<20)
            {
                Console.WriteLine("{0}, Ez a szám a tizesek közé tartozik",szam);
            }
        }
    }
}
