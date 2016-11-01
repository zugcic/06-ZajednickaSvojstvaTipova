using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestEqualsZaIzvedeniReferentiTip : ConsoleTest
    {
        [TestMethod]
        public void EqualsZaIzvedeniReferentiTip_UsporedbaReferenciNaIstiObjektUvijekVraćaTrue()
        {
            Student s1 = new Student("Janko", 1, "računarstvo", 3);
            Student s2 = s1;
            MetodaEqualsZaIzvedeniReferentiTip.UsporedbaStudenata(s1, s2);
            Assert.AreEqual(s1.ToString(), ((Student)cw.GetObject()).ToString());
            Assert.AreEqual(s2.ToString(), ((Student)cw.GetObject()).ToString());
            Assert.IsTrue(cw.GetBoolean());
            Assert.IsTrue(cw.GetBoolean());
            Assert.IsTrue(cw.GetBoolean());
        }

        [TestMethod]
        public void EqualsZaIzvedeniReferentiTip_UsporedbaDvijeIsteOsobeSRazličitimSmjeromIGodinomVraćaFalse()
        {
            Student s1 = new Student("Janko", 1, "računarstvo", 3);
            Student s2 = new Student("Janko", 1, "elektronika", 3);
            MetodaEqualsZaIzvedeniReferentiTip.UsporedbaStudenata(s1, s2);
            Assert.AreEqual(s1.ToString(), ((Student)cw.GetObject()).ToString());
            Assert.AreEqual(s2.ToString(), ((Student)cw.GetObject()).ToString());
            Assert.IsFalse(cw.GetBoolean());
            Assert.IsFalse(cw.GetBoolean());
            Assert.IsFalse(cw.GetBoolean());
        }

        [TestMethod]
        public void EqualsZaIzvedeniReferentiTip_UsporedbaDvijeIsteOsobeSIstogSmjeraIGodineVraćaTrue()
        {
            Student s1 = new Student("Janko", 1, "računarstvo", 3);
            Student s2 = new Student("Janko", 1, "računarstvo", 3);
            MetodaEqualsZaIzvedeniReferentiTip.UsporedbaStudenata(s1, s2);
            Assert.AreEqual(s1.ToString(), ((Student)cw.GetObject()).ToString());
            Assert.AreEqual(s2.ToString(), ((Student)cw.GetObject()).ToString());
            Assert.IsTrue(cw.GetBoolean());
            Assert.IsTrue(cw.GetBoolean());
            Assert.IsFalse(cw.GetBoolean());
        }
    }
}
