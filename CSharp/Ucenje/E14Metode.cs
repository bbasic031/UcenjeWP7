using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Metode
    {
        public static void Izvedi()
        {
            Console.WriteLine("E14");
            Tip1();
            Tip2(7);
            Tip2(11,"matej");
            Console.WriteLine(Tip3());
            for(int i = 0; i < 100; i++)
            {
                if(Tip4(i))
                    Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Metoda tipa 1: Ne vraća vrijednost, ne prima vrijednost
        /// ne vraća vrijednost - void
        /// mora trenutno biti static
        /// ne piše public ili nešto drugo
        /// </summary>
        static void Tip1()
        {
            Console.WriteLine("Ispis iz metode Tip 1");
        }

        static void Tip2(int i)
        {
            Console.WriteLine("Primio sam broj {0}",i);
            Console.WriteLine("Uvecan za 10 on iznosi {0}",i+10);
        }

        protected static void Tip2(int i, string s)
        {
            Console.WriteLine(s);
            Console.WriteLine("Primio sam {0}",i);
        }

        public static string Tip3()
        {
            return "Web programiranje";
        }

        public static bool Tip4(int broj)
        {
            if (broj == 0)
                return false;
            for(int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                    return false;
            }
            return true;
        }

        public static int UcitajBroj(string poruka)
        {
            while (true)
            {
                Console.WriteLine(poruka+": ");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj");
                }
            }
        }

        public static int UcitajBroj(string poruka, int min, int max)
        {
            var i = 0;
            for(; ; )
            {
                Console.Write(poruka+": ");
                try
                {
                    i=int.Parse(Console.ReadLine());
                    if (i < min || i > max)
                    {
                        Console.WriteLine("Broj nije u danom rasponu {0} i {1}", min, max);
                        continue;
                    }
                    return i;
                }
                catch
                {
                    Console.WriteLine("Nisi unio broj!");
                }
            }
        }

        public static string UcitajString(string poruka, string greska)
        {
            string s;
            while (true)
            {
                Console.WriteLine(poruka+": ");
                s= Console.ReadLine();
                if (s.Trim().Length == 0)
                {
                    Console.WriteLine(greska);
                    continue;
                }
                return s;
            }
        }
    }
}
