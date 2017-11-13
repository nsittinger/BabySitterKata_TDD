using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabySitterKata;


namespace BabySitter_Tests
{
    [TestClass]
    public class BabySittersKata_UnitTests
    {
        TimeConfirmation timeConfirmation = new TimeConfirmation();
        Calculator calculator = new Calculator();

        //TIME CONFIRMATION TESTS
        [TestMethod]
        public void CannotWorkUntilFivePMTest()
        {
            Assert.AreEqual(true, timeConfirmation.CannotWorkUntilFivePM(18));
            Assert.AreEqual(true, timeConfirmation.CannotWorkUntilFivePM(17));
            Assert.AreEqual(false, timeConfirmation.CannotWorkUntilFivePM(13));
        }

        [TestMethod]
        public void CannotWorkPastFourAMTest()
        {
            Assert.AreEqual(true, timeConfirmation.CannotWorkPastFourAM(2));
            Assert.AreEqual(false, timeConfirmation.CannotWorkPastFourAM(7));
            Assert.AreEqual(true, timeConfirmation.CannotWorkPastFourAM(20));
        }

        [TestMethod]
        public void BedTimeIsAfterStartTimeTest()
        {
            Assert.AreEqual(true, timeConfirmation.BedTimeIsAfterStartTime(18, 20));
            Assert.AreEqual(true, timeConfirmation.BedTimeIsAfterStartTime(19, 22));
            Assert.AreEqual(false, timeConfirmation.BedTimeIsAfterStartTime(19, 18));
        }

        [TestMethod]
        public void EndTimeIsAfterStartTimeTest()
        {
            Assert.AreEqual(true, timeConfirmation.EndTimeIsAfterStartTime(18, 20));
            Assert.AreEqual(false, timeConfirmation.EndTimeIsAfterStartTime(20, 18));
            Assert.AreEqual(true, timeConfirmation.EndTimeIsAfterStartTime(18, 1));
            Assert.AreEqual(false, timeConfirmation.EndTimeIsAfterStartTime(3, 1));
        }

        [TestMethod]
        public void TimeConfirmationPassTest()
        {
            Assert.AreEqual(true, timeConfirmation.TimeConfirmationPass(18, 20, 1));
            Assert.AreEqual(false, timeConfirmation.TimeConfirmationPass(12, 20, 1));
            Assert.AreEqual(false, timeConfirmation.TimeConfirmationPass(18, 20, 6));

        }

        //CALCULATOR TESTS
        [TestMethod]
        public void StartToBedTimePayTest()
        {
            Assert.AreEqual(24.00, calculator.StartToBedTimePay(17, 19));
            Assert.AreEqual(48.00, calculator.StartToBedTimePay(17, 21));
        }

        [TestMethod]
        public void BedTimeToMidnightPayTest()
        {
            Assert.AreEqual(16.00, calculator.BedTimeToMidnightPay(22));
            Assert.AreEqual(32.00, calculator.BedTimeToMidnightPay(20));
        }
    }
}
