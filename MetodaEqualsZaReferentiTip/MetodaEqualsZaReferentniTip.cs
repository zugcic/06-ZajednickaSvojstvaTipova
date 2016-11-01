using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    public class Osoba
    {
        public Osoba(string ime, int matičniBroj)
        {
            m_ime = ime;
            m_matičniBroj = matičniBroj;
        }

        string m_ime;       // član referentnog tipa
        int m_matičniBroj;  // član vrijednosnog tipa

        // TODO: Pregaziti (override) metodu Equals tako da za osobe s istim imenom i istim matičnim brojem rezultat bude true
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != GetType())
                return false;
            Osoba druga = (Osoba)obj;
            if (!Osoba.Equals(m_ime, druga.m_ime))
                return false;
            return m_matičniBroj.Equals(druga.m_matičniBroj);
        }

        public override string ToString()
        {
            return string.Format("'{0}, {1}'", m_ime, m_matičniBroj);
        }
    }

    public class MetodaEqualsZaReferentniTip
    {
        public static void UsporedbaOsoba(Osoba osobaA, Osoba osobaB)
        {
            Console.WriteLine(osobaA);
            Console.WriteLine(osobaB);

            try
            {
                Console.WriteLine(osobaA.Equals(osobaB));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("POGREŠKA: osobaA je null referenca pa nema metodu Equals!");
            }
            try
            {
                Console.WriteLine(osobaB.Equals(osobaA));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("POGREŠKA: osobaB je null referenca pa nema metodu Equals!");
            }

            Console.WriteLine(Osoba.ReferenceEquals(osobaA, osobaB));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Usporedba referenci na isti objekt:");
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;
            UsporedbaOsoba(osobaA, osobaB);
            Console.WriteLine();

            Console.WriteLine("Usporedba s null referencom na objekt istog tipa:");
            UsporedbaOsoba(osobaA, null);
            Console.WriteLine();

            Console.WriteLine("Usporedba dviju osoba s različitim imenima i matičnim brojevima:");
            osobaB = new Osoba("Marko", 2);
            UsporedbaOsoba(osobaA, osobaB);
            Console.WriteLine();

            Console.WriteLine("Usporedba dviju osoba s isitim imenima i različitim matičnim brojevima:");
            osobaB = new Osoba("Janko", 5);
            UsporedbaOsoba(osobaA, osobaB);
            Console.WriteLine();

            Console.WriteLine("Usporedba dviju osoba s isitim imenima i istim matičnim brojevima:");
            osobaB = new Osoba("Janko", 1);
            UsporedbaOsoba(osobaA, osobaB);
            Console.WriteLine();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
