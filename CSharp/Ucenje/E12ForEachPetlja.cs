using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E12ForEachPetlja
    {
        public static void Izvedi()
        {
            Console.WriteLine("E12");

            Console.Write("Unesi ime grada: ");
            string grad = Console.ReadLine();

            //svako slovo grada unesi jedno ispod drugog

            for(int i = 0; i < grad.Length; i++)
            {
                Console.WriteLine(grad[i]);
            }
            Console.WriteLine("**********************");
            foreach(char znak in grad)
            {
                Console.WriteLine(znak);
            }
            Console.WriteLine("*******************************");
            for(int i = grad.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(grad[i]);
            }
            Console.WriteLine("******************");
            int[] brojevi = { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach(int i in brojevi)
                Console.Write(i+"\n");
        }
    }
}
