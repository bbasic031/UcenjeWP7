using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E11DoWhilePetlja
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E11");
            do
            {
                Console.WriteLine("Izvede se jednom");
            } while (false);

            int i = 2;
            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i < 28);
        }
    }
}
