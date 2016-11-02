using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestJednakostiReferentnogTipa
    {
        [TestMethod]
        public void JednakostReferentogTipa_VraćaFalseZaUsporedbuOsobeSNullReferencom()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = null;
            Assert.IsFalse(osobaA == osobaB);
            Assert.IsTrue(osobaA != osobaB);
        }

        [TestMethod]
        public void JednakostReferentogTipa_VraćaFalseZaUsporedbuNullReferenceSOsobom()
        {
            Osoba osobaA = null;
            Osoba osobaB = new Osoba("Janko", 1);
            Assert.IsFalse(osobaA == osobaB);
            Assert.IsTrue(osobaA != osobaB);
        }

        [TestMethod]
        public void JednakostReferentogTipa_VraćaTrueZaDvijeOsobeJednakihImenaIMatičnogBroja()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Janko", 1);
            Assert.IsTrue(osobaA == osobaB);
            Assert.IsFalse(osobaA != osobaB);
        }

        [TestMethod]
        public void JednakostReferentogTipa_VraćaFalseZaDvijeOsobeJednakihImenaRazličitihMatičnihBrojeva()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Janko", 2);
            Assert.IsFalse(osobaA == osobaB);
            Assert.IsTrue(osobaA != osobaB);
        }

        [TestMethod]
        public void JednakostReferentogTipa_VraćaFalseZaDvijeOsobeRazličitihImenaJednakihMatičnihBrojeva()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Darko", 1);
            Assert.IsFalse(osobaA == osobaB);
            Assert.IsTrue(osobaA != osobaB);
        }
    }
}
