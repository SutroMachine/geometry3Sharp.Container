using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace g3.Test
{
    [TestClass]
    public class TestVector2d
    {
        private static double etol = 1e-4;

        [TestMethod]
        public void Creation()
        {
            var vec = new Vector2d();

            Assert.AreEqual(0, vec.x, etol);
            Assert.AreEqual(0, vec.y, etol);
        }
    }
}
