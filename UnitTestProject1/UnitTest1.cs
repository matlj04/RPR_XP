using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        enum spec
        {
            Berserker, Kouzelník, Inženýr, Cizák, a
        }
        enum obl
        {
            velký_nos, ušoplesk, make_up, a
        }
        enum vlas 
        { 
            culík, drdol, pleška, a
        }
        enum barva
        { 
            kaštanová, blond, červená, a 
        }
        enum prace
        {
            obchodník, nepřítel, obyvatel, a
        }
        [TestMethod]
        public void TestMethodHPPOZ()
        {
            string jmeno = "Lucifer";
            Assert.IsTrue(jmeno.Length < 10);
        }
        [TestMethod]
        public void TestMethodHPNEG()
        {
            string jmeno = "Luciferkofík";
            Assert.IsTrue(jmeno.Length < 10);
        }
        [TestMethod]
        public void TestMethodLVLPOZ()
        {
            int lvl = 1;
            Assert.IsTrue(lvl == 1);
        }
        [TestMethod]
        public void TestMethodLVLNEG()
        {
            int lvl = 30;
            Assert.IsTrue(lvl == 1);
        }
        [TestMethod]
        public void TestMethodPOSPOZ()
        {
            int x = 0;
            int y = 0;
            Assert.IsTrue(x == 0 && y == 0);
        }
        [TestMethod]
        public void TestMethodPOSNEG()
        {
            int x = 2;
            int y = 3;
            Assert.IsTrue(x == 0 && y == 0);
        }
        [TestMethod]
        public void TestMethodSPEPOZ()
        {
            spec spec = spec.Berserker;
            Assert.IsTrue(spec == spec.Berserker || spec == spec.Cizák || spec == spec.Inženýr || spec == spec.Kouzelník);
        }
        [TestMethod]
        public void TestMethodSPENEG()
        {
            spec spec = spec.a;
            Assert.IsTrue(spec == spec.Berserker || spec == spec.Cizák || spec == spec.Inženýr || spec == spec.Kouzelník);
        }
        [TestMethod]
        public void TestMethodOBLPOZ()
        {
            obl obl = obl.make_up;
            Assert.IsTrue(obl == obl.velký_nos || obl == obl.make_up || obl == obl.ušoplesk);
        }
        [TestMethod]
        public void TestMethodOBLNEG()
        {
            obl obl = obl.a;
            Assert.IsTrue(obl == obl.velký_nos || obl == obl.make_up || obl == obl.ušoplesk);
        }
        [TestMethod]
        public void TestMethodVLAPOZ()
        {
            vlas vlas = vlas.culík;
            Assert.IsTrue(vlas == vlas.culík || vlas == vlas.drdol || vlas == vlas.pleška);
        }
        [TestMethod]
        public void TestMethodVLANEG()
        {
            vlas vlas = vlas.a;
            Assert.IsTrue(vlas == vlas.culík || vlas == vlas.drdol || vlas == vlas.pleška);
        }
        [TestMethod]
        public void TestMethodBARPOZ()
        {
            barva bar = barva.blond;
            Assert.IsTrue(bar == barva.blond || bar == barva.kaštanová || bar == barva.červená);
        }
        [TestMethod]
        public void TestMethodBARNEG()
        {
            barva bar = barva.a;
            Assert.IsTrue(bar == barva.blond || bar == barva.kaštanová || bar == barva.červená);
        }
        [TestMethod]
        public void TestMethodXPPOZ()
        {
            int xp = 0;
            Assert.IsTrue(xp == 0);
        }
        [TestMethod]
        public void TestMethodXPNEG()
        {
            int xp = 1000000001;
            Assert.IsTrue(xp == 0);
        }
        [TestMethod]
        public void TestMethodPRIDEJXPPOZ()
        {
            int xp = 100;
            int lvl = 1;
            Assert.IsTrue(100 == xp * lvl);
        }
        [TestMethod]
        public void TestMethodPRIDEJXPNEG()
        {
            int xp = 35;
            int lvl = 5;
            Assert.IsTrue(100 == xp * lvl);
        }
        [TestMethod]
        public void TestMethodPRACPOZ()
        {
            prace prac = prace.nepřítel;
            Assert.IsTrue(prac == prace.nepřítel || prac == prace.obchodník || prac == prace.obyvatel);
        }
        [TestMethod]
        public void TestMethodPRACNEG()
        {
            prace prac = prace.a;
            Assert.IsTrue(prac == prace.nepřítel || prac == prace.obchodník || prac == prace.obyvatel);
        }
    }
}
