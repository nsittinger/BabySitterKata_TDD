using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabySitterKata;


namespace BabySitter_Tests
{
    [TestClass]
    public class BabySittersKata_UnitTests
    {
        TimeConfirmation timeConfirmation = new TimeConfirmation();

        [TestMethod]
        public void CannotWorkUntilFivePM()
        {
            Assert.AreEqual(true, timeConfirmation.CannotWorkUntilFivePM(18));
            Assert.AreEqual(true, timeConfirmation.CannotWorkUntilFivePM(17));
            Assert.AreEqual(false, timeConfirmation.CannotWorkUntilFivePM(13));
        }

        [TestMethod]
        public void CannotWorkPastFourAM()
        {
            Assert.AreEqual(true, timeConfirmation.CannotWorkPastFourAM(2));
            Assert.AreEqual(false, timeConfirmation.CannotWorkPastFourAM(7));
            Assert.AreEqual(true, timeConfirmation.CannotWorkPastFourAM(20));
        }
    }
}
