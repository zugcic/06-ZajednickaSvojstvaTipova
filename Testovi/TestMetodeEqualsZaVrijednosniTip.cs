using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestMetodeEqualsZaVrijednosniTip
    {
        [TestMethod]
        public void EqualsZaVrijednosniTip_ZaObjekteSRazličitimČlanovimaVraćaFalse()
        {
            MetodaEqualsZaVrijednosniTip.Osoba osobaA = new MetodaEqualsZaVrijednosniTip.Osoba("Janko", 1);
            MetodaEqualsZaVrijednosniTip.Osoba osobaB = new MetodaEqualsZaVrijednosniTip.Osoba("Darko", 2);
            Assert.IsFalse(osobaA.Equals(osobaB));
        }

        [TestMethod]
        public void EqualsZaVrijednosniTip_ZaOsobeSJednakimImenomRazličitimMatičnimBrojemVraćaFalse()
        {
            MetodaEqualsZaVrijednosniTip.Osoba osobaA = new MetodaEqualsZaVrijednosniTip.Osoba("Janko", 1);
            MetodaEqualsZaVrijednosniTip.Osoba osobaB = new MetodaEqualsZaVrijednosniTip.Osoba("Janko", 2);
            Assert.IsFalse(osobaA.Equals(osobaB));
        }

        [TestMethod]
        public void EqualsZaVrijednosniTip_ZaOsobeSRazličitimImenimaIstimMatičnimBrojemVraćaFalse()
        {
            MetodaEqualsZaVrijednosniTip.Osoba osobaA = new MetodaEqualsZaVrijednosniTip.Osoba("Janko", 1);
            MetodaEqualsZaVrijednosniTip.Osoba osobaB = new MetodaEqualsZaVrijednosniTip.Osoba("Darko", 1);
            Assert.IsFalse(osobaA.Equals(osobaB));
        }

        [TestMethod]
        public void EqualsZaVrijednosniTip_ZaKopijuOsobeVraćaTrue()
        {
            MetodaEqualsZaVrijednosniTip.Osoba osobaA = new MetodaEqualsZaVrijednosniTip.Osoba("Janko", 1);
            MetodaEqualsZaVrijednosniTip.Osoba osobaB = osobaA;
            Assert.IsTrue(osobaA.Equals(osobaB));
        }

        [TestMethod]
        public void EqualsZaVrijednosniTip_ZaOsobeSJednakimImenimaIMatičnimBrojevimaVraćaTrue()
        {
            MetodaEqualsZaVrijednosniTip.Osoba osobaA = new MetodaEqualsZaVrijednosniTip.Osoba("Janko", 1);
            MetodaEqualsZaVrijednosniTip.Osoba osobaB = new MetodaEqualsZaVrijednosniTip.Osoba("Janko", 1);
            Assert.IsTrue(osobaA.Equals(osobaB));
        }
    }
}
