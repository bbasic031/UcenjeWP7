using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E09ZimskiZadaci
    {

        // NAPOMENA vezana za AI. Korištenje AI alata je dobrodošli ako Vam pomogne u boljem razumjevanju
        // programerskih koncepata. Ako već i generirate rješenje, svakako ga testirajte i definitivno
        // u komunikaciji s AI alatom tražite da Vam se objasni kod ili linija po linija (to dobro radi)


        /*
          Zimski zadaci:

        Jednostavni
        1. Izračun površine pravokutnika:
            Napiši program koji od korisnika traži da unese duljinu i širinu pravokutnika, a zatim izračunava i ispisuje površinu pravokutnika.
        2. Provjera je li broj pozitivan, negativan ili nula:
            Napiši program koji od korisnika traži da unese broj i ispisuje je li broj pozitivan, negativan ili nula.
        3. Zbroj elemenata niza:
            Napiši program koji deklarira niz cijelih brojeva, traži od korisnika da unese vrijednosti u niz, a zatim izračunava i ispisuje zbroj svih elemenata niza.
        4. Prosjek ocjena:
            Napiši program koji od korisnika traži da unese broj ocjena, a zatim i same ocjene. Program treba izračunati i ispisati prosjek ocjena.
        5. Ispis Fibonaccijevog niza:
            Napiši program koji od korisnika traži da unese broj n, a zatim ispisuje prvih n brojeva Fibonaccijevog niza (0, 1, 1, 2, 3, 5, 8...).
        6. Preokret stringa:
            Napiši program koji od korisnika traži da unese string, a zatim ispisuje taj string naopako (npr. "zdravo" postaje "ovardz").
        7. Brojanje samoglasnika:
            Napiši program koji od korisnika traži da unese string, a zatim prebrojava i ispisuje koliko samoglasnika ima u tom stringu.
        8. Pretvorba temperature:
            Napiši program koji od korisnika traži da unese temperaturu u Celzijusima i pretvara je u Fahrenheit (°F = °C * 9/5 + 32) ili obrnuto, ovisno o odabiru korisnika.
        9. Sortiranje niza:
            Napiši program koji deklarira niz cijelih brojeva, traži od korisnika da unese vrijednosti u niz, a zatim sortira niz uzlazno i ispisuje sortirani niz.
        10. Kalkulator:
            Napiši program koji od korisnika traži da unese dva broja i operaciju (+, -, *, /), a zatim izračunava i ispisuje rezultat. Koristi switch statement za odabir operacije.


         Generator lozinki
           Program od korisnika traži unos podataka:
           Dužina lozinke
           Uključena/isključena velika slova
           Uključena/isključena mala slova
           Uključeni/isključeni brojevi
           Uključeni/isključeni interpunkcijski znakovi
           Lozinka počinje ili ne s brojem
           Lozinka počinje ili ne s interpunkcijskim znakom
           Lozinka završava ili ne s brojem
           Lozinka završava ili ne s interpunkcijskim znakom
           Lozinka ima/nema ponavljajuće znakove
           Broj lozinki koje je potrebno generirati

           Shodno unesenim pravilima program generira rezultat (jedna ili više lozinki)


       Ciklična matrica
       Napraviti osnovni zadatak prema inicijalnoj slici
       Dodatno:
       Osigurati unos brojeva redova i kolona u rasponu 2 do 50
       Napraviti da nakon završetka generiranja jedne matrice pita želite li napraviti još jednu i tako sve dok ne unese NE
       Napraviti opcije programa o smjeru kretanja brojeva:
       1. dolje desno početak u smjeru kazaljke na satu (inicijalni zadatak)
       2. dolje lijevo početak u smjeru kazaljke na satu
       3. gore lijevo početak u smjeru kazaljke na satu
       4. gore desno početak u smjeru kazaljke na satu

       5. dolje desno početak u kontra smjeru kazaljke na satu 
       6. dolje lijevo početak u kontra smjeru kazaljke na satu
       7. gore lijevo početak u kontra smjeru kazaljke na satu
       8. gore desno početak u kontra smjeru kazaljke na satu

       19. sredina (ono što je bio kraj u prvih 8 primjera) lijevo u smjeru kazaljke na satu
       10. sredina (ono što je bio kraj u prvih 8 primjera) desno u smjeru kazaljke na satu
       11. sredina (ono što je bio kraj u prvih 8 primjera) gore u smjeru kazaljke na satu
       12. sredina (ono što je bio kraj u prvih 8 primjera) dolje u smjeru kazaljke na satu

       13. sredina (ono što je bio kraj u prvih 8 primjera) lijevo u kontra smjeru kazaljke na satu
       14. sredina (ono što je bio kraj u prvih 8 primjera) desno u kontra smjeru kazaljke na satu
       15. sredina (ono što je bio kraj u prvih 8 primjera) gore u kontra smjeru kazaljke na satu
       16. sredina (ono što je bio kraj u prvih 8 primjera) dolje u kontra smjeru kazaljke na satu

       Formatirati brojeve da budu potpisati po pravilima matematike: jedinica ispod jedinice, desetica ispod desetice, stotica ispod stotice




       Kada završite sve zadatke s svim opcijama javite se na email pa ću poslati nove :)



         */
        public static void povrsinaPravokutnika()
        {
            double duljina, sirina;
            Console.WriteLine("Unesite duljinu pravokutnika u cm: ");
            duljina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesite širinu pravokutnika u cm: ");
            sirina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Površina pravokutnika iznosi: " + duljina * sirina + "cm");
        }

        public static void provjeraNegativnosti()
        {
            Console.WriteLine("Unesite broj: ");
            double broj = Convert.ToDouble(Console.ReadLine());
            if (broj == 0)
                Console.WriteLine("Vaš broj je 0");
            else if (broj < 0)
                Console.WriteLine("Vaš broj je negativan");
            else
                Console.WriteLine("Vaš broj je pozitivan");
        }

        public static void zbrojElemenataNiza()
        {
            Console.WriteLine("Unesite broj elemenata niza: ");
            int n = int.Parse(Console.ReadLine());
            int[] niz = new int[n];
            Console.WriteLine("Unesite elemente niza: ");
            int zbroj = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Element " + (i + 1) + ": ");
                niz[i] = int.Parse(Console.ReadLine());
                zbroj += niz[i];
            }
            Console.WriteLine("Zbroj elemenata niza je: " + zbroj);
        }

        public static void prosjekOcjena()
        {
            Console.WriteLine("Unesite broj ocjena: ");
            int n = int.Parse(Console.ReadLine());
            float[] niz = new float[n];
            Console.WriteLine("Unesite ocjene: ");
            float zbroj = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ocjena broj " + (i + 1) + ": ");
                niz[i] = int.Parse(Console.ReadLine());
                zbroj += niz[i];
            }
            Console.WriteLine("Prosjek ocjena je: " + (zbroj / n).ToString("0.00"));
        }

        public static void fibonacciNiz()
        {
            Console.WriteLine("Koliko elemenata fibonaccijevog niza želite?");
            int n = int.Parse(Console.ReadLine());
            int[] niz = new int[n];
            niz[0] = 0;
            niz[1] = 1;
            for (int i = 2; i < n; i++)
            {
                niz[i] = niz[i - 2] + niz[i - 1];
            }
            Console.WriteLine("Fibonaccijev niz s " + n + " elemenata: ");
            foreach (int x in niz)
                Console.Write(x + " ");
        }

        public static void izvrnutiString()
        {
            Console.WriteLine("Unesite string: ");
            string unos = Console.ReadLine();
            char[] nizZnakova = unos.ToCharArray();
            Array.Reverse(nizZnakova);
            string naopako = new string(nizZnakova);
            Console.WriteLine("Preokrenuti string glasi: " + naopako);
        }

        public static void samoglasnici()
        {
            Console.WriteLine("Upisite trazenu rijec: ");
            string unos = Console.ReadLine();
            string samoglasnici = "aeiou";
            char[] chars = samoglasnici.ToCharArray();
            int brojac = 0;
            foreach (char c in unos)
            {
                if (samoglasnici.Contains(c))
                    brojac++;
            }
            Console.WriteLine("Broj samoglasnika: " + brojac);
        }

        public static void tempConverter()
        {
            Console.WriteLine("Upisujete li temperaturu u C ili F? (upisite samo c ili f)");
            string unos = Console.ReadLine();
            Console.WriteLine("Unesite iznos temperature u " + unos + " : ");
            float iznos = float.Parse(Console.ReadLine());
            if (unos == "c")
            {
                Console.WriteLine("Temperatura pretvorena u F glasi: " + ((iznos * 9 / 5) + 32).ToString("0.00") + "F");
            }
            else if (unos == "f")
            {
                Console.WriteLine("Temperatura pretvorena u C glasi: " + ((iznos - 32) * 5 / 9).ToString("0.00") + "C");
            }
        }        
    }
}
