using System;
//HashCode -> u Hash tablicu spremmo objekte sa ključem, ključ je broj koji generira HashCode()
//pretraživanje u Hash Tablici ide po inetegeru
namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Pokrenuti program i usporediti ispise. Koja dva znakovna niza daju najbliže brojeve?

            Console.WriteLine(string.Format("cat.GetHashCode() = {0}", "cat".GetHashCode()));
            Console.WriteLine(string.Format("cta.GetHashCode() = {0}", "cta".GetHashCode()));
            Console.WriteLine(string.Format("cap.GetHashCode() = {0}", "cap".GetHashCode()));
            Console.WriteLine(string.Format("car.GetHashCode() = {0}", "car".GetHashCode()));
            Console.WriteLine(string.Format("cut.GetHashCode() = {0}", "cut".GetHashCode()));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
