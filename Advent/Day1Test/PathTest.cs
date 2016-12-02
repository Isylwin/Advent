using System;
using System.Collections.Generic;
using Advent.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day1Test
{
    [TestClass]
    public class PathTest
    {
        private Point MakePoint_WithInstructions(int x, int y)
        {
            return new Point(x, y);
        }

        private Path MakePath_WithStepCollection(List<Step> steps)
        {
            return new Path(steps);
        }

        private List<Step> MakeStepCollection_WithInstruction(string arg)
        {
            return Step.GetStepsFromString(arg);
        }

        [TestMethod]
        public void GetEnd_WithInstructions_ReturnsPoint()
        {
            var steps = MakeStepCollection_WithInstruction("R1, L1, R1");

            var path = MakePath_WithStepCollection(steps);

            var actual = path.End;
            var expected = MakePoint_WithInstructions(2, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetNodes_WithInstructions_ReturnsPointCollection()
        {
            var steps = MakeStepCollection_WithInstruction("R1, L1, R1");

            var path = MakePath_WithStepCollection(steps);

            var actual = path.Nodes;
            var expected = new List<Point>()
            {
                MakePoint_WithInstructions(0,0),
                MakePoint_WithInstructions(1,0),
                MakePoint_WithInstructions(1,1),
                MakePoint_WithInstructions(2,1)
            };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDupPoints_WithInstructions_ReturnsPointCollection()
        {
            var steps = MakeStepCollection_WithInstruction("L1, R1, R1, R1");

            var path = MakePath_WithStepCollection(steps);

            var actual = path.Duplicated;
            var expected = new List<Point>()
            {
                MakePoint_WithInstructions(0,0)
            };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
