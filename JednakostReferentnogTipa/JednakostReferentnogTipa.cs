using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    // TODO: U klasi Osoba iz projekta MetodaEqualsZaReferentiTip definirati operatore == i != tako da donji primjeri daju očekivane rezultate.

    public class JednakostReferentnogTipa
    {
        static void Main(string[] args)
        {
            // dvije osobe s različitim imenima i MB
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Darko", 2);
            Debug.Assert((osobaA == osobaB) == false);
            Debug.Assert(osobaA != osobaB);

            // novi "Janko" s drugim matičnim brojem
            osobaB = new Osoba("Janko", 2);
            Debug.Assert((osobaA == osobaB) == false);
            Debug.Assert(osobaA != osobaB);

            // novi "Janko" s istim matičnim brojem
            osobaB = new Osoba("Janko", 1);
            Debug.Assert(osobaA == osobaB);
            Debug.Assert((osobaA != osobaB) == false);

            osobaB = osobaA;
            Debug.Assert(osobaA == osobaB);
            Debug.Assert((osobaA != osobaB) == false);

            osobaB = null;
            Debug.Assert((osobaA == osobaB) == false);
            Debug.Assert(osobaA != osobaB);

            osobaA = null;
            Debug.Assert(osobaA == osobaB);
            Debug.Assert((osobaA != osobaB) == false);


            Console.ReadLine();
        }
    }
}
