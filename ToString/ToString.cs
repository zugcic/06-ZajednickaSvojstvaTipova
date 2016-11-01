using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Vsite.CSharp
{
    public struct KompleksniBroj
    {
        public KompleksniBroj(double realni, double imaginarni)
        {
            Realni = realni;
            Imaginarni = imaginarni;
        }

        public double Realni;
        public double Imaginarni;

        // TODO: Pregaziti (override) metodu ToString tako da vraća niz u obliku: "2+3j", "2-j", "0", "j", "-j"
        // (ako je implementacija ispravna, metoda Main bi se trebala izvesti bez problema)
        public override string ToString()
        {
            if (Imaginarni == 0)
                return Realni.ToString();
            if (Realni == 0)
                return FormatirajImaginarni();
            if (Imaginarni < 0)
                return string.Format("{0}{1}", Realni, FormatirajImaginarni());
            return string.Format("{0}+{1}", Realni, FormatirajImaginarni());
        }

        private string FormatirajImaginarni()
        {
            if (Imaginarni == 1)
                return "j";
            if (Imaginarni == -1)
                return "-j";
            return string.Format("{0}j", Imaginarni);
        }
    }

    class ToString
    {
        static void Main(string[] args)
        {
            KompleksniBroj kb = new KompleksniBroj(2, 3);
            Console.WriteLine(kb); // "2+3j"

            kb.Imaginarni = -3;
            Console.WriteLine(kb); // "2-3j"

            kb.Realni = 0;
            Console.WriteLine(kb); // "-3j"

            kb.Imaginarni = 0;
            Console.WriteLine(kb); // "0"

            kb.Imaginarni = 1;
            Console.WriteLine(kb); // "j"

            kb.Imaginarni = -1;
            Console.WriteLine(kb); // "-j"

            kb.Imaginarni = 0;
            kb.Realni = -2;
            Console.WriteLine(kb); // "-2"

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
