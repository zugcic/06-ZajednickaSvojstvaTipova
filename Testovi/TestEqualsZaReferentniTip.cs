using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestEqualsZaReferentniTip
    {
        [TestMethod]
        public void EqualsZaReferentniTip_UsporedbaReferenciNaIstiObjektUvijekVraćaTrue()
        {
            Osoba o1 = new Osoba("Janko", 1);
            Osoba o2 = o1;

            Assert.IsTrue(o1.Equals(o2));
            Assert.IsTrue(o2.Equals(o1));
            Assert.IsTrue(Osoba.Equals(o1, o2));
            Assert.IsTrue(Osoba.ReferenceEquals(o1, o2));
        }

        [TestMethod]
        public void EqualsZaReferentniTip_UsporedbaDvijuOsobaSRazličitimImenimaRazličitimMatičnimBrojemVraćaFalse()
        {
            Osoba o1 = new Osoba("Janko", 1);
            Osoba o2 = new Osoba("Marko", 2);

            Assert.IsFalse(o1.Equals(o2));
            Assert.IsFalse(o2.Equals(o1));
            Assert.IsFalse(Osoba.Equals(o1, o2));
            Assert.IsFalse(Osoba.ReferenceEquals(o1, o2));
        }

        [TestMethod]
        public void EqualsZaReferentniTip_UsporedbaDvijuOsobaSIstimImenimaRazličtitimMatičnimBrojemVraćaFalse()
        {
            Osoba o1 = new Osoba("Janko", 1);
            Osoba o2 = new Osoba("Janko", 2);

            Assert.IsFalse(o1.Equals(o2));
            Assert.IsFalse(o2.Equals(o1));
            Assert.IsFalse(Osoba.Equals(o1, o2));
            Assert.IsFalse(Osoba.ReferenceEquals(o1, o2));
        }

        [TestMethod]
        public void EqualsZaReferentniTip_UsporedbaSNullReferencomVraćaFalse()
        {
            Osoba o1 = new Osoba("Janko", 1);
            Osoba o2 = null;

            Assert.IsFalse(o1.Equals(o2));
            Assert.IsFalse(Osoba.Equals(o1, o2));
            Assert.IsFalse(Osoba.ReferenceEquals(o1, o2));
        }

        [TestMethod]
        public void EqualsZaReferentniTip_UsporedbaDvijuOsobaSIstimImenimaIstimMatičnimBrojemVraćaTrue()
        {
            Osoba o1 = new Osoba("Janko", 1);
            Osoba o2 = new Osoba("Janko", 1);

            Assert.IsTrue(o1.Equals(o2));
            Assert.IsTrue(o2.Equals(o1));
            Assert.IsTrue(Osoba.Equals(o1, o2));
            Assert.IsFalse(Osoba.ReferenceEquals(o1, o2));
        }
    }
}
