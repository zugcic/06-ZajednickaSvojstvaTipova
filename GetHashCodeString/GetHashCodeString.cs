using System;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Pokrenuti program i ispis preslikati u datoteku GetHashCodeString.txt pridruženu projektu
            // U datoteci navesti koja dva znakovan niza daju najbliže brojeve

            Console.WriteLine("cat".GetHashCode());
            Console.WriteLine("cta".GetHashCode());
            Console.WriteLine("cap".GetHashCode());
            Console.WriteLine("car".GetHashCode());
            Console.WriteLine("cut".GetHashCode());

            Console.ReadKey();
        }
    }
}
