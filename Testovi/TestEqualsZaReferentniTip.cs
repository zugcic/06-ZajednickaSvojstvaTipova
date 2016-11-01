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
            MetodaEqualsZaReferentniTip.UsporedbaReferenciNaIstiObjekt();
            Assert.IsTrue(cw.GetBoolean());
            Assert.IsTrue(cw.GetBoolean());
        }

        [TestMethod]
        public void EqualsZaReferentniTip_UsporedbaDvijuOsobaSRazličitimImenimaRazličitimMatičnimBrojemVraćaFalse()
        {
            MetodaEqualsZaReferentniTip.UsporedbaOsobaSRazličitimImenimaRazličitimMatičnimBrojem();
            Assert.IsFalse(cw.GetBoolean());
            Assert.IsFalse(cw.GetBoolean());
        }

        [TestMethod]
        public void EqualsZaReferentniTip_UsporedbaDvijuOsobaSIstimImenimaRazličtitimMatičnimBrojemVraćaFalse()
        {
            MetodaEqualsZaReferentniTip.UsporedbaOsobaSRazličitimImenimaRazličitimMatičnimBrojem();
            Assert.IsFalse(cw.GetBoolean());
            Assert.IsFalse(cw.GetBoolean());
        }

        [TestMethod]
        public void EqualsZaReferentniTip_UsporedbaDvijuOsobaSIstimImenimaIstimMatičnimBrojemVraćaTrue()
        {
            MetodaEqualsZaReferentniTip.UsporedbaOsobaSIstimImenimaIstimMatičnimBrojem();
            Assert.IsTrue(cw.GetBoolean());
            Assert.IsFalse(cw.GetBoolean());
        }
    }
}
