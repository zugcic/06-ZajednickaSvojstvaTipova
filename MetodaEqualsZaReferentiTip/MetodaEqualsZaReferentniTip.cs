using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    class Osoba
    {
        public Osoba(string ime, int matičniBroj)
        {
            m_ime = ime;
            m_matičniBroj = matičniBroj;
        }

        string m_ime;       // član referentnog tipa
        int m_matičniBroj;  // član vrijednosnog tipa

        // TODO: Pregaziti (override) metodu Equals tako da za osobe s istim imenom i istim matičnim brojem rezultat bude true


        public override string ToString()
        {
            return string.Format("'{0}, {1}'", m_ime, m_matičniBroj);
        }
    }

    public class MetodaEqualsZaReferentniTip
    {
        public static void UsporedbaReferenciNaIstiObjekt()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;

            // TODO: Ispisati rezultat poziva metode osobaA.Equals(osobaB)
            Console.WriteLine(osobaA.Equals(osobaB));

            // TODO: Ispisati rezultat poziva metode ReferenceEquals(osobaB)
            Console.WriteLine(object.ReferenceEquals(osobaA, osobaB));
        }

        public static void UsporedbaOsobaSRazličitimImenimaRazličitimMatičnimBrojem()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Darko", 2);

            // TODO: Ispisati rezultat poziva metode osobaA.Equals(osobaB)
            Console.WriteLine(osobaA.Equals(osobaB));

            // TODO: Ispisati rezultat poziva metode ReferenceEquals(osobaB)
            Console.WriteLine(object.ReferenceEquals(osobaA, osobaB));
        }

        public static void UsporedbaOsobaSIstimImenimaRazličtitimMatičnimBrojem()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Janko", 2);

            // TODO: Ispisati rezultat poziva metode osobaA.Equals(osobaB)
            Console.WriteLine(osobaA.Equals(osobaB));

            // TODO: Ispisati rezultat poziva metode ReferenceEquals(osobaB)
            Console.WriteLine(object.ReferenceEquals(osobaA, osobaB));
        }

        public static void UsporedbaOsobaSIstimImenimaIstimMatičnimBrojem()
        {
            Osoba osobaA = new Osoba("Janko", 5);
            Osoba osobaB = new Osoba("Janko", 5);

            // TODO: Ispisati rezultat poziva metode osobaA.Equals(osobaB)
            Console.WriteLine(osobaA.Equals(osobaB));

            // TODO: Ispisati rezultat poziva metode ReferenceEquals(osobaB)
            Console.WriteLine(object.ReferenceEquals(osobaA, osobaB));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Usporedba referenci na isti bojekt:");
            UsporedbaReferenciNaIstiObjekt();

            Console.WriteLine("Usporedba dviju osoba s različitim imenima i matičnim brojevima:");
            UsporedbaOsobaSRazličitimImenimaRazličitimMatičnimBrojem();

            Console.WriteLine("Usporedba dviju osoba s isitim imenima i različitim matičnim brojevima:");
            UsporedbaOsobaSIstimImenimaRazličtitimMatičnimBrojem();

            Console.WriteLine("Usporedba dviju osoba s isitim imenima i istim matičnim brojevima:");
            UsporedbaOsobaSIstimImenimaIstimMatičnimBrojem();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
