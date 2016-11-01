using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSherp.Testovi
{
    [TestClass]
    public class TestToString
    {
        [TestMethod]
        public void ToString_VraćaTekstZaKompleksniBrojSRealnimIPozitvnimImaginarnimDijelom()
        {
            KompleksniBroj kb = new KompleksniBroj(2, 3);
            Assert.AreEqual("2+3j", kb.ToString());
        }

        [TestMethod]
        public void ToString_VraćaTekstZaKompleksniBrojSRealnimINegativnimImaginarnimDijelom()
        {
            KompleksniBroj kb = new KompleksniBroj(2, -3);
            Assert.AreEqual("2-3j", kb.ToString());
        }

        [TestMethod]
        public void ToString_VraćaTekstZaKompleksniBrojSamoSNegativnimImaginarnimDijelom()
        {
            KompleksniBroj kb = new KompleksniBroj(0, -3);
            Assert.AreEqual("-3j", kb.ToString());
        }

        [TestMethod]
        public void ToString_VraćaTekstZaImaginarnuJedinicu()
        {
            KompleksniBroj kb = new KompleksniBroj(0, 1);
            Assert.AreEqual("j", kb.ToString());
        }

        [TestMethod]
        public void ToString_VraćaTekstZaNulu()
        {
            KompleksniBroj kb = new KompleksniBroj(0, 0);
            Assert.AreEqual("0", kb.ToString());
        }

        [TestMethod]
        public void ToString_VraćaTekstZaBrojSamoSNegativnimRealnimDijelom()
        {
            KompleksniBroj kb = new KompleksniBroj(-2, 0);
            Assert.AreEqual("-2", kb.ToString());
        }
    }
}
