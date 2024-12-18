using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E03Operatori
    {
        public static void Izvedi()
        {
            int i, j;
            i = 2; j = 3;
            i += j;
            Console.WriteLine(i);

            Console.WriteLine(i/j);
            Console.WriteLine(i/(float)j);
            Console.WriteLine(i%j);
        }
    }
}
