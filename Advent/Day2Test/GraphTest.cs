using System;
using System.Collections.Generic;
using Day2.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2Test
{
    [TestClass]
    public class GraphTest
    {
        [TestMethod]
        public void GetMap_WithListOfTuples_ReturnsDictionary()
        {
            var arg = new List<Tuple<int, int, string>>
            {
                new Tuple<int, int, string>(0,0, "5"),
                new Tuple<int, int, string>(1,0, "6")
            };

            var actual = TestUtil.MakeGraph_WithListOfTuples(arg);
            var expected = new Dictionary<Point, Node>
            {
                {new Point(0,0), new Node("5")  },
                {new Point(1,0), new Node("6")  }
            };

            CollectionAssert.AreEquivalent(expected, actual.Map);
        }

        [TestMethod]
        public void GetNode_WithPoint_ReturnsNode()
        {
            var graph = TestUtil.MakeGraph_WithoutArgument();

            var actual = graph.GetNodeFrom(new Point(1, 0));
            var expected = new Node("6");

            Assert.AreEqual(expected, actual);
        }
    }
}
