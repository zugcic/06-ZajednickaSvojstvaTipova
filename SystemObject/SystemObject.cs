using System;

namespace Vsite.CSharp
{
    // TODO: Definirati klasu MojaKlasa bez ikakvih članova, samo s praznom definicijom.


    public class SystemObject
    {
        public static void IspisToString()
        {
            // TODO: Otkomentirati donje naredbe.
            //MojaKlasa mk1 = new MojaKlasa();
            //MojaKlasa mk2 = mk1;
            //MojaKlasa mk3 = new MojaKlasa();

            // TODO: Za svaki objekt (mk1, mk2, mk3) pozvati njegovu metodu ToString i ispisati na konzolu ono što ona vraća.

        }

        public static void IspisGetType()
        {
            // TODO: Otkomentirati donje naredbe.
            //MojaKlasa mk1 = new MojaKlasa();
            //MojaKlasa mk2 = mk1;
            //MojaKlasa mk3 = new MojaKlasa();

            // TODO: Za svaki objekt (mk1, mk2, mk3) pozvati njegovu metodu GetType i ispisati na konzolu ono što ona vraća.

        }

        public static void IspisGetHashCode()
        {
            // TODO: Otkomentirati donje naredbe.
            //MojaKlasa mk1 = new MojaKlasa();
            //MojaKlasa mk2 = mk1;
            //MojaKlasa mk3 = new MojaKlasa();

            // TODO: Za svaki objekt (mk1, mk2, mk3) pozvati njegovu metodu GetHashCode i ispisati na konzolu ono što ona vraća.

        }

        public static void IspisEquals()
        {
            // TODO: Otkomentirati donje naredbe.
            //MojaKlasa mk1 = new MojaKlasa();
            //MojaKlasa mk2 = mk1;
            //MojaKlasa mk3 = new MojaKlasa();

            // TODO: Otkomentirati donje naredbe i ispisati na konzolu rezultate usporedbi.
            //Console.WriteLine(mk1.Equals(mk2));
            //Console.WriteLine(mk1.Equals(mk3));
            //Console.WriteLine(mk2.Equals(mk1));
            //Console.WriteLine(mk2.Equals(mk3));
            //Console.WriteLine(mk3.Equals(mk1));
            //Console.WriteLine(mk3.Equals(mk2));
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Ispis ToString");
            IspisToString();

            Console.WriteLine("Ispis GetType");
            IspisGetType();

            Console.WriteLine("Ispis GetHashCode");
            IspisGetHashCode();

            Console.WriteLine("Ispis Equals");
            IspisEquals();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
