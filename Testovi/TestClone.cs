using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestClone : ConsoleTest
    {
        [TestMethod]
        public void Clone_VraćaNoviObjektSIstimSadržajem()
        {
            MetodaClone.Jednakost();
            Assert.IsTrue(cw.GetString().EndsWith("false"));
            Assert.IsTrue(cw.GetString().EndsWith("true"));
            Assert.IsTrue(cw.GetString().EndsWith("false"));
        }
    }
}
