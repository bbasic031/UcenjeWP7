using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class PasswordGenerator
    {
        public static void Generate()
        {
            int duljina, kolicina;
            bool velika = new bool();
            bool mala = new bool();
            bool brojevi = new bool();
            bool znakovi = new bool();
            bool brojPocetak = new bool();
            bool interpunkcijskiPocetak = new bool();
            bool brojKraj = new bool();
            bool interpunkcijskiKraj = new bool();
            bool ponavljanje = new bool();
            Random random = new Random();
            StringBuilder lozinka = new StringBuilder();
            string popisZnakova = "!#$%&/()=?*<>|{}^";
            string popisBrojeva = "0123456789";
            string malaSlova = "abcdefghijklmnopqrstuvwxyz";
            string velikaSlova = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            List<char> trenutneOpcije = new List<char>();
            int j;
            Console.WriteLine("Unesite duljinu lozinke: ");
            while (true)
            {
                try
                {
                    duljina = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj!");
                }
            }
            Console.WriteLine("Želite li velika slova? (True ili False)");
            while (true)
            {
                try
                {
                    velika = bool.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli True ili False!");
                }
            }
            Console.WriteLine("Želite li mala slova? (True ili False)");
            while (true)
            {
                try
                {
                    mala = bool.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli True ili False!");
                }
            }
            Console.WriteLine("Želite li brojeve? (True ili False)");
            while (true)
            {
                try
                {
                    brojevi = bool.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli True ili False!");
                }
            }
            Console.WriteLine("Želite li znakove? (True ili False)");
            while (true)
            {
                try
                {
                    znakovi = bool.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli True ili False!");
                }
            }
            Console.WriteLine("Želite li početi lozinku s brojem? (True ili False)");
            while (true)
            {
                try
                {
                    brojPocetak = bool.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli True ili False!");
                }
            }
            while (true)
            {
                if (brojPocetak == true)
                    break;
                else
                {
                    Console.WriteLine("Želite li početi lozinku s interpunkcijskim? (True ili False)");
                    try
                    {
                        interpunkcijskiPocetak = bool.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Niste unijeli True ili False!");
                    }
                }
            }
            Console.WriteLine("Želite li završiti lozinku s brojem? (True ili False)");
            while (true)
            {
                try
                {
                    brojKraj = bool.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli True ili False!");
                }
            }
            while (true)
            {
                if (brojKraj == true)
                    break;
                else
                {
                    Console.WriteLine("Želite li završiti lozinku s interpunkcijskim? (True ili False)");
                    try
                    {
                        interpunkcijskiKraj = bool.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Niste unijeli True ili False!");
                    }
                }
            }
            Console.WriteLine("Želite li lozinka ima ponavljajuće znakove? (True ili False)");
            while (true)
            {
                try
                {
                    ponavljanje = bool.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli True ili False!");
                }
            }
            Console.WriteLine("Koliko lozinki želite generirati?");
            while (true)
            {
                try
                {
                    kolicina = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj!");
                }
            }
            for (int i = 0; i < kolicina; i++)
            {
                j = 0;
                trenutneOpcije = new List<char>();
                Console.WriteLine("Lozinka broj {0}: ", i + 1);
                if (brojPocetak)
                {
                    lozinka.Append(popisBrojeva[random.Next(popisBrojeva.Length)].ToString());
                    j++;
                }
                else if (interpunkcijskiPocetak)
                {
                    lozinka.Append(popisZnakova[random.Next(popisZnakova.Length)].ToString());
                    j++;
                }
                if (velika == true)
                    trenutneOpcije.AddRange(velikaSlova);
                if (mala == true)
                    trenutneOpcije.AddRange(malaSlova);
                if (brojevi == true)
                    trenutneOpcije.AddRange(popisBrojeva);
                if (znakovi == true)
                    trenutneOpcije.AddRange(popisZnakova);
                for (; j < duljina - (brojKraj || interpunkcijskiKraj ? 1 : 0); j++)
                {                    
                    if (trenutneOpcije.Count > 0)
                    {
                        char temp = trenutneOpcije[random.Next(trenutneOpcije.Count)];
                        lozinka.Append(temp);
                        if (!ponavljanje)
                        {
                            trenutneOpcije.Remove(temp);
                            //Console.WriteLine("Removed {0} from trenutneOpcije",temp);
                        }                   
                    }                        
                    else
                    {
                        lozinka.Append((char)('a' + random.Next(26)));
                    }
                }
                if (brojKraj)
                {
                    lozinka.Append(popisBrojeva[random.Next(popisBrojeva.Length)].ToString());
                }
                else if (interpunkcijskiKraj)
                {
                    lozinka.Append(popisZnakova[random.Next(popisZnakova.Length)].ToString());
                }
                Console.WriteLine(lozinka.ToString());
                lozinka.Clear();
            }
        }
    }
}
