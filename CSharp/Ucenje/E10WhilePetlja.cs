using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10WhilePetlja
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E10");
            while (true)
            {
                break;
            }
            int i = 0;
            while (i++ < 10)
            {
                Console.WriteLine(i);
            }
            int j = 0;
            while (i >= 10 && j++ < 10)
            {
                Console.WriteLine(i*j);
            }

            Console.WriteLine("--------------------");

            int odBroja = 0;
            int doBroja = 10;
            for(int x=odBroja; x<doBroja; x++)
            {
                Console.WriteLine(x);
            }
        }
    }
}
