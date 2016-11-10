﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    //  Pokrenuti program i provjeriti ispis.

    // Implementirati metodu GetHashCode u klasi Osoba iz projekta MetodaEqualsZaReferentiTip tako da se metoda Main može izvesti bez problema

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Osoba, string> mjestaRođenja = new Dictionary<Osoba, string>();
            mjestaRođenja[new Osoba("Pero", 1)] = "Babina Greda";
            mjestaRođenja[new Osoba("Janko", 2)] = "Jarče Polje";
            mjestaRođenja[new Osoba("Darko", 3)] = "Vukova Gorica";

            Console.WriteLine(mjestaRođenja[new Osoba("Pero", 1)]);
            Console.WriteLine(mjestaRođenja[new Osoba("Janko", 2)]);
            Console.WriteLine(mjestaRođenja[new Osoba("Darko", 3)]);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();

        }
    }
}
