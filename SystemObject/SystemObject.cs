using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa mk2 = mk1;
            MojaKlasa mk3 = new MojaKlasa();

            // metoda ToString
            // TODO: za svaki objekt pozvati njegovu metodu ToString i ispisati na konzolu ono što ona vraća


            // metoda GetType
            // TODO: za svaki objekt pozvati njegovu metodu GetType i ispisati na konzolu ono što ona vraća


            // metoda GetHashCode
            // TODO: za svaki objekt pozvati njegovu metodu GetHashCode i ispisati na konzolu ono što ona vraća


            // metoda Equals
            // TODO: za svaki objekt pozvati njegovu metodu Equals i usporedbu napraviti sa svim ostalim objektima te ispisati na konzolu ono što ona vraća


            // TODO: ispise pohraniti u datoteku SystemObjects.txt priloženu projektu te u njoj obrazložiti rezultate za svaku metodu!


            Console.ReadKey();
        }
    }
}
