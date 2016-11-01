using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestEqualsZaReferentniTip : ConsoleTest
    {
        [TestMethod]
        public void EqualsZaReferentniTip_UsporedbaReferenciNaIstiObjektUvijekVraćaTrue()
        {
            Osoba o1 = new Osoba("Janko", 1);
            Osoba o2 = o1;
            MetodaEqualsZaReferentniTip.UsporedbaOsoba(o1, o2);
            Assert.AreEqual(o1.ToString(), ((Osoba)cw.GetObject()).ToString());
            Assert.AreEqual(o2.ToString(), ((Osoba)cw.GetObject()).ToString());
            Assert.IsTrue(cw.GetBoolean());
            Assert.IsTrue(cw.GetBoolean());
            Assert.IsTrue(cw.GetBoolean());
        }

        [TestMethod]
        public void EqualsZaReferentniTip_UsporedbaDvijuOsobaSRazličitimImenimaRazličitimMatičnimBrojemVraćaFalse()
        {
            Osoba o1 = new Osoba("Janko", 1);
            Osoba o2 = new Osoba("Marko", 2);
            MetodaEqualsZaReferentniTip.UsporedbaOsoba(o1, o2);
            Assert.AreEqual(o1.ToString(), ((Osoba)cw.GetObject()).ToString());
            Assert.AreEqual(o2.ToString(), ((Osoba)cw.GetObject()).ToString());
            Assert.IsFalse(cw.GetBoolean());
            Assert.IsFalse(cw.GetBoolean());
            Assert.IsFalse(cw.GetBoolean());
        }

        [TestMethod]
        public void EqualsZaReferentniTip_UsporedbaDvijuOsobaSIstimImenimaRazličtitimMatičnimBrojemVraćaFalse()
        {
            Osoba o1 = new Osoba("Janko", 1);
            Osoba o2 = new Osoba("Janko", 2);
            MetodaEqualsZaReferentniTip.UsporedbaOsoba(o1, o2);
            Assert.AreEqual(o1.ToString(), ((Osoba)cw.GetObject()).ToString());
            Assert.AreEqual(o2.ToString(), ((Osoba)cw.GetObject()).ToString());
            Assert.IsFalse(cw.GetBoolean());
            Assert.IsFalse(cw.GetBoolean());
            Assert.IsFalse(cw.GetBoolean());
        }

        [TestMethod]
        public void EqualsZaReferentniTip_UsporedbaSNullReferencomVraćaFalse()
        {
            Osoba o1 = new Osoba("Janko", 1);
            Osoba o2 = null;
            MetodaEqualsZaReferentniTip.UsporedbaOsoba(o1, o2);
            Assert.AreEqual(o1.ToString(), ((Osoba)cw.GetObject()).ToString());
            Assert.IsNull(cw.GetObject());
            Assert.IsFalse(cw.GetBoolean());
            cw.GetString();
            Assert.IsFalse(cw.GetBoolean());
        }

        [TestMethod]
        public void EqualsZaReferentniTip_UsporedbaDvijuOsobaSIstimImenimaIstimMatičnimBrojemVraćaTrue()
        {
            Osoba o1 = new Osoba("Janko", 1);
            Osoba o2 = new Osoba("Janko", 1);
            MetodaEqualsZaReferentniTip.UsporedbaOsoba(o1, o2);
            Assert.AreEqual(o1.ToString(), ((Osoba)cw.GetObject()).ToString());
            Assert.AreEqual(o2.ToString(), ((Osoba)cw.GetObject()).ToString());
            Assert.IsTrue(cw.GetBoolean());
            Assert.IsTrue(cw.GetBoolean());
            Assert.IsFalse(cw.GetBoolean());
        }
    }
}
