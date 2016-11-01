using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestEqualsZaIzvedeniReferentiTip
    {
        [TestMethod]
        public void EqualsZaIzvedeniReferentiTip_UsporedbaReferenciNaIstiObjektUvijekVraćaTrue()
        {
            Student s1 = new Student("Janko", 1, "računarstvo", 3);
            Student s2 = s1;

            Assert.IsTrue(s1.Equals(s2));
            Assert.IsTrue(s2.Equals(s1));
            Assert.IsTrue(Osoba.Equals(s1, s2));
            Assert.IsTrue(Osoba.ReferenceEquals(s1, s2));
        }

        [TestMethod]
        public void EqualsZaIzvedeniReferentiTip_UsporedbaDvijeIsteOsobeSRazličitimSmjeromIGodinomVraćaFalse()
        {
            Student s1 = new Student("Janko", 1, "računarstvo", 3);
            Student s2 = new Student("Janko", 1, "elektronika", 3);

            Assert.IsFalse(s1.Equals(s2));
            Assert.IsFalse(s2.Equals(s1));
            Assert.IsFalse(Osoba.Equals(s1, s2));
            Assert.IsFalse(Osoba.ReferenceEquals(s1, s2));
        }

        [TestMethod]
        public void EqualsZaIzvedeniReferentiTip_UsporedbaDvijeIsteOsobeSIstogSmjeraIGodineVraćaTrue()
        {
            Student s1 = new Student("Janko", 1, "računarstvo", 3);
            Student s2 = new Student("Janko", 1, "računarstvo", 3);

            Assert.IsTrue(s1.Equals(s2));
            Assert.IsTrue(s2.Equals(s1));
            Assert.IsTrue(Osoba.Equals(s1, s2));
            Assert.IsFalse(Osoba.ReferenceEquals(s1, s2));
        }

        [TestMethod]
        public void EqualsZaIzvedeniReferentiTip_UsporedbaDvijeRazličiteOsobeSIstogSmjeraIGodineVraćaFalse()
        {
            Student s1 = new Student("Janko", 1, "računarstvo", 3);
            Student s2 = new Student("Marko", 3, "računarstvo", 3);

            Assert.IsFalse(s1.Equals(s2));
            Assert.IsFalse(s2.Equals(s1));
            Assert.IsFalse(Osoba.Equals(s1, s2));
            Assert.IsFalse(Osoba.ReferenceEquals(s1, s2));
        }
    }
}
