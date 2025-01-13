using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E12Z2
    {
        public static void Izvedi()
        {
            Console.WriteLine("Upisi prvu rijec: ");
            string prvaRijec=Console.ReadLine();
            Console.WriteLine("Upisi drugu rijec: ");
            string drugaRijec=Console.ReadLine();

            for (int i = drugaRijec.Length - 1; i >= 0; i--)
            {
                Console.Write(drugaRijec[i]);
            }
            Console.Write(" ");
            for (int i = prvaRijec.Length - 1; i >= 0; i--)
            {
                Console.Write(prvaRijec[i]);
            }
        }
    }
}
