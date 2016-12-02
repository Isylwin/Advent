using System;
using Advent.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day1Test
{
    [TestClass]
    public class DirectionTest
    {
        private Direction MakeDirection_WithParseString(string arg)
        {
            return DirectionExt.ParseString(arg);
        }

        [TestMethod]
        public void ParseString_LeftInstruction_ReturnsLeft()
        {
            var arg = "L1";

            var actual = MakeDirection_WithParseString(arg);
            var expected = Direction.Left;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ParseString_RightIntruction_ReturnsRight()
        {
            var arg = "R1";

            var actual = MakeDirection_WithParseString(arg);
            var expected = Direction.Right;

            Assert.AreEqual(expected, actual);
        }
    }
}
