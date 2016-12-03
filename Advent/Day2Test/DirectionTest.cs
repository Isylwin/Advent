using System;
using Day2.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2Test
{
    [TestClass]
    public class DirectionTest
    {
        [TestMethod]
        public void GetHeading_WithString_ReturnsRight()
        {
            var actual = TestUtil.MakeDirection_WithString('R');

            Assert.AreEqual(Heading.Right, actual.Heading);
        }

        [TestMethod]
        public void GetTranslation_WithHeading_ReturnsPoint()
        {
            var actual = TestUtil.MakeDirection_WithString('R');
            var expected = TestUtil.MakePoint_WithXAndY(1, 0);

            Assert.AreEqual(expected, actual.Translation);
        }
    }
}
