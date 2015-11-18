using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    class Osoba : ICloneable
    {
        public Osoba(string ime, int matičniBroj)
        {
            m_ime = ime;
            m_matičniBroj = matičniBroj;
        }

        public string m_ime;       // član referentnog tipa
        public int m_matičniBroj;  // član vrijednosnog tipa

        public override bool Equals(object obj) 
        {
            // TODO: Preslikati implementaciju metode Equals iz EqualsRefTip1

            return true;
        }

        public override string ToString()
        {
            return string.Format("'{0}, {1}'", m_ime, m_matičniBroj);
        }

        object ICloneable.Clone()
        {
            return (object)Clone();
        }

        // tipski sigurna implementacija
        public Osoba Clone()
        {
            // TODO: implementirati metodu tako da se metoda Main može izvesti bez problema
            return null;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // dvije osobe
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;
            Debug.Assert(osobaA.Equals(osobaB));

            osobaB.m_ime = "Marko";
            Debug.Assert(osobaA.Equals(osobaB) == false);

            // kloniramo
            osobaB = osobaA.Clone();
            Debug.Assert(osobaA.Equals(osobaB));

            osobaB.m_ime = "Pero";
            Debug.Assert(osobaA.Equals(osobaB) == false);

            Console.ReadLine();
        }
    }
}
