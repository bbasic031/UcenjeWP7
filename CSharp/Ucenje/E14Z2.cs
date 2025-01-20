using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Z2
    {
        public static void Punoljetna()
        {
            int dob = E14Metode.UcitajBroj("Upišite svoju dob: ",1,120);
            if(dob<18)
                Console.WriteLine("Maloljetni ste");
            else
                Console.WriteLine("Punoljetni ste");

            Console.WriteLine((E14Metode.UcitajBroj("Unesi svoju dob: ",1,120)<18?"Maloljetna":"Punoljetna")+"osoba");
        }
    }
}
