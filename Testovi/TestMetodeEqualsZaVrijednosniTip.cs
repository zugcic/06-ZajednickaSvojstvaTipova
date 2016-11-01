using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    using Osoba = Vsite.CSharp.MetodaEqualsZaVrijednosniTip.Osoba;

    [TestClass]
    public class TestMetodeEqualsZaVrijednosniTip
    {
        [TestMethod]
        public void EqualsZaVrijednosniTip_ZaObjekteSRazličitimČlanovimaVraćaFalse()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Darko", 2);
            Assert.IsFalse(osobaA.Equals(osobaB));
        }

        [TestMethod]
        public void EqualsZaVrijednosniTip_ZaOsobeSJednakimImenomRazličitimMatičnimBrojemVraćaFalse()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Janko", 2);
            Assert.IsFalse(osobaA.Equals(osobaB));
        }

        [TestMethod]
        public void EqualsZaVrijednosniTip_ZaOsobeSRazličitimImenimaIstimMatičnimBrojemVraćaFalse()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Darko", 1);
            Assert.IsFalse(osobaA.Equals(osobaB));
        }

        [TestMethod]
        public void EqualsZaVrijednosniTip_ZaKopijuOsobeVraćaTrue()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;
            Assert.IsTrue(osobaA.Equals(osobaB));
        }

        [TestMethod]
        public void EqualsZaVrijednosniTip_ZaOsobeSJednakimImenimaIMatičnimBrojevimaVraćaTrue()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Janko", 1);
            Assert.IsTrue(osobaA.Equals(osobaB));
        }
    }
}
