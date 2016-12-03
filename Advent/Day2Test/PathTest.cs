using System;
using System.Collections.Generic;
using Day2.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2Test
{
    [TestClass]
    public class PathTest
    {
        [TestMethod]
        public void GetNode_WithString_ReturnsSix()
        {
            var path = TestUtil.MakePath_WithString("URRLDR");

            var actual = path.Node;
            var expected = new Node("6");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPoint_WithString_ReturnsPoint()
        {
            var path = TestUtil.MakePath_WithString("URRLDR");

            var actual = path.Point;
            var expected = new Point(1,0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetNodes_WithString_ReturnsCollection()
        {
            var path = TestUtil.MakePath_WithString("URRLDR");

            var actual = path.VisitedNodes;
            var expected = new List<Node>
            {
                new Node("5"),
                new Node("2"),
                new Node("3"),
                new Node("2"),
                new Node("5"),
                new Node("6")
            };

            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
