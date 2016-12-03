using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2Test
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void GetX_WithXFive_ReturnsFive()
        {
            var actual = TestUtil.MakePoint_WithXAndY(5, 1);

            Assert.AreEqual(5, actual.X);
        }

        [TestMethod]
        public void GetY_WithYSeven_ReturnsSeven()
        {
            var actual = TestUtil.MakePoint_WithXAndY(1, 7);

            Assert.AreEqual(7, actual.Y);
        }

        [TestMethod]
        public void GetEquals_WithTwoPoints_ReturnsTrue()
        {
            var actual = TestUtil.MakePoint_WithXAndY(1, 1);
            var expected = TestUtil.MakePoint_WithXAndY(1, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetHashCode_WithTwoPoints_ReturnsTrue()
        {
            var actual = TestUtil.MakePoint_WithXAndY(1, 1).GetHashCode();
            var expected = TestUtil.MakePoint_WithXAndY(1, 1).GetHashCode();

            Assert.AreEqual(expected, actual);
        }
    }
}
