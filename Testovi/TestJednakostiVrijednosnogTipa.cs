using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    using Osoba = Vsite.CSharp.MetodaEqualsZaVrijednosniTip.Osoba;

    [TestClass]
    public class TestJednakostiVrijednosnogTipa : ConsoleTest
    {
        [TestMethod]
        public void JednakostVrijednosnogTipa_VraćaTrueZaIsteOsobe()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = osobaA;
            JednakostVrijednogTipa.Jednakost(osobaA, osobaB);
            Assert.IsTrue(cw.GetString().EndsWith("true"));
            Assert.IsTrue(cw.GetString().EndsWith("false"));
        }

        [TestMethod]
        public void JednakostVrijednosnogTipa_VraćaTrueZaJednakeOsobe()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Janko", 1);
            JednakostVrijednogTipa.Jednakost(osobaA, osobaB);
            Assert.IsTrue(cw.GetString().EndsWith("true"));
            Assert.IsTrue(cw.GetString().EndsWith("false"));
        }

        [TestMethod]
        public void JednakostVrijednosnogTipa_VraćaFalseZaRazličiteOsobe()
        {
            Osoba osobaA = new Osoba("Janko", 1);
            Osoba osobaB = new Osoba("Janko", 2);
            JednakostVrijednogTipa.Jednakost(osobaA, osobaB);
            Assert.IsTrue(cw.GetString().EndsWith("false"));
            Assert.IsTrue(cw.GetString().EndsWith("true"));
        }
    }
}
