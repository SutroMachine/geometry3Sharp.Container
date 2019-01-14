﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}