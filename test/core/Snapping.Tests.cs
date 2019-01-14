using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace g3.Test
{
    [TestClass]
    public class SnappingTests
    {
        private static double etol = 1e-4;

        [TestMethod]
        public void SnapToIncrement_Low()
        {
            double snapped = Snapping.SnapToIncrement(1.2, 3.5);
            Assert.AreEqual(0, snapped);
        }

        [TestMethod]
        public void SnapToIncrement_High()
        {
            double snapped = Snapping.SnapToIncrement(6.8, 3.5);
            Assert.AreEqual(7, snapped);
        }

        [TestMethod]
        public void SnapToIncrement_LowOffset()
        {
            double snapped = Snapping.SnapToIncrement(1.2, 3.5, 0.2);
            Assert.AreEqual(0.2, snapped);
        }


        [TestMethod]
        public void SnapToNearbyIncrement_Nearby()
        {
            double snapped = Snapping.SnapToNearbyIncrement(4.2, 2, 0.3);
            Assert.AreEqual(4, snapped);
        }

        [TestMethod]
        public void SnapToNearbyIncrement_NotNearby()
        {
            double snapped = Snapping.SnapToNearbyIncrement(4.4, 2, 0.3);
            Assert.AreEqual(4.4, snapped);
        }

        [TestMethod]
        public void SnapToIncrementLow_LowPos()
        {
            double snapped = Snapping.SnapToIncrementLow(4.2, 2);
            Assert.AreEqual(4, snapped);
        }

        [TestMethod]
        public void SnapToIncrementLow_LowNeg()
        {
            double snapped = Snapping.SnapToIncrementLow(-4.2, 2);
            Assert.AreEqual(-6, snapped);
        }

        [TestMethod]
        public void SnapToIncrementLow_HighPos()
        {
            double snapped = Snapping.SnapToIncrementLow(5.9, 2);
            Assert.AreEqual(4, snapped);
        }

        [TestMethod]
        public void SnapToIncrementLow_HighNeg()
        {
            double snapped = Snapping.SnapToIncrementLow(-5.9, 2);
            Assert.AreEqual(-6, snapped);
        }

        [TestMethod]
        public void SnapToIncrementLow_LowPosOffset()
        {
            double snapped = Snapping.SnapToIncrementLow(4.2, 2, -0.7);
            Assert.AreEqual(4 - 0.7, snapped);
        }

        [TestMethod]
        public void SnapToIncrementHigh_LowPos()
        {
            double snapped = Snapping.SnapToIncrementHigh(4.2, 2);
            Assert.AreEqual(6, snapped);
        }

        [TestMethod]
        public void SnapToIncrementHigh_LowNeg()
        {
            double snapped = Snapping.SnapToIncrementHigh(-4.2, 2);
            Assert.AreEqual(-4, snapped);
        }

        [TestMethod]
        public void SnapToIncrementHigh_HighPos()
        {
            double snapped = Snapping.SnapToIncrementHigh(5.9, 2);
            Assert.AreEqual(6, snapped);
        }

        [TestMethod]
        public void SnapToIncrementHigh_HighNeg()
        {
            double snapped = Snapping.SnapToIncrementHigh(-5.9, 2);
            Assert.AreEqual(-4, snapped);
        }

        [TestMethod]
        public void SnapToIncrementHigh_HighNegOffset()
        {
            double snapped = Snapping.SnapToIncrementHigh(-5.9, 2, 0.8);
            Assert.AreEqual(-5.2, snapped);
        }

    }
}
