using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    using Osoba = Vsite.CSharp.MetodaEqualsZaVrijednosniTip.Osoba;

    // TODO: Strukturi Osoba u projektu MetodaEqualsZaVrijednosniTip definirati operatore == i != tako da donji primjeri daju očekivane rezultate.

    public class JednakostVrijednogTipa
    {
        public static bool JednakiSu(Osoba osobaA, Osoba osobaB)
        {
            // TODO: Otkomentirati donju naredbu.
            //return osobaA == osobaB;
            return false;
        }

        public static bool RazličitiSu(Osoba osobaA, Osoba osobaB)
        {
            // TODO: Otkomentirati donju naredbu.
            //return osobaA != osobaB;
            return false;
        }

        static void Main(string[] args)
        {

            // dvije osobe s različitim imenima i MB
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Darko", 2);
            Console.WriteLine(JednakiSu(osobaA, osobaB));
            //Debug.Assert((osobaA == osobaB) == false);
            //Debug.Assert(osobaA != osobaB);

            // preslika osobe A
            osobaB = osobaA;
            //Debug.Assert(osobaA == osobaB);
            //Debug.Assert((osobaA != osobaB) == false);

            // novi "Janko" s istim matičnim brojem
            osobaB = new Osoba("Janko", 1);
            //Debug.Assert(osobaA == osobaB);
            //Debug.Assert((osobaA != osobaB) == false);

            // "Janko", ali s drugim matičnim brojem
            osobaB = new Osoba("Janko", 2);
            //Debug.Assert((osobaA == osobaB) == false);
            //Debug.Assert(osobaA != osobaB);

            Console.ReadLine();
        }
    }
}
