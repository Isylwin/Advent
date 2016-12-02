using System;
using Advent.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day1Test
{
    [TestClass]
    public class PointTest
    {
        private Point MakePoint_WithInstructions(int x, int y)
        {
            return new Point(x, y);
        }

        private Step MakeStep_WithIntruction(string arg)
        {
            return new Step(arg);
        }

        [TestMethod]
        public void GetX_WithXFive_ReturnsFive()
        {
            var x = 5;
            var y = 1;

            var point = MakePoint_WithInstructions(x, y);

            var actual = point.X;
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetY_WithYFive_ReturnsFive()
        {
            var x = 1;
            var y = 5;

            var point = MakePoint_WithInstructions(x, y);

            var actual = point.Y;
            var expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDistance_WithInstruction_ReturnsSixty()
        {
            var point1 = MakePoint_WithInstructions(0, 0);
            var point2 = MakePoint_WithInstructions(30, 30);

            var actual = point1.Distance(point2);
            var expected = 60;

            Assert.AreEqual(expected, actual);
        }
    }
}
