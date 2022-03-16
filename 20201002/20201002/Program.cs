using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201002
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //f1();
            //f2();
            f3();
            Console.WriteLine("Enter");
            Console.ReadLine();
        }
        static void f1()
        {
            int[] sporolas = new int[13];
            int osszeg = 0;
            for (int i = 0; i < sporolas.Length; i++)
            {
                sporolas[i] = rnd.Next(1, 10001);
                Console.WriteLine(sporolas[i]);
                osszeg = sporolas[i] + osszeg;
            }
            Console.WriteLine("Ennyit sporoltunk: {0} ", osszeg);
        }
        static void f2()
        {
            int[] pont = new int[10];
            int eredmeny = 0;
            for (int i = 0; i < pont.Length; i++)
            {
                pont[i] = rnd.Next(0, 10);
                Console.WriteLine(pont[i]);
                eredmeny = pont[i] + eredmeny;
            }
            Console.WriteLine("Össz. eredmény: {0}", eredmeny);
        }
        static void f3()
        {
            int csapatok;
            int pontok = 0;
            Console.WriteLine("Hány csapat legyen?");
            csapatok=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < csapatok ; i++)
            {
                pontok = rnd.Next(1,4);
            }
        }
    }
}
