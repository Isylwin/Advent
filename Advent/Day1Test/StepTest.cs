using System;
using System.Collections.Generic;
using Advent.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day1Test
{
    [TestClass]
    public class StepTest
    {
        private Step MakeStep_WithIntruction(string arg)
        {
            return new Step(arg);
        }

        private List<Step> MakeStepCollection_WithInstruction(string arg)
        {
            return Step.GetStepsFromString(arg);
        }

        [TestMethod]
        public void GetDirection_RightInstruction_ReturnsRightDirection()
        {
            var arg = "R1";

            var step = MakeStep_WithIntruction(arg);

            var actual = step.Direction;
            var expected = Direction.Right;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDirection_LeftInstruction_ReturnsLeftDirection()
        {
            var arg = "L1";

            var step = MakeStep_WithIntruction(arg);

            var actual = step.Direction;
            var expected = Direction.Left;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDistance_TwentyThreeInstruction_ReturnsTwentyThreeDistance()
        {
            var arg = "L23";

            var step = MakeStep_WithIntruction(arg);

            var actual = step.Distance;
            var expected = 23;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDistance_HundredAndEightyInstruction_ReturnsHundredAndEightyDistance()
        {
            var arg = "L180";

            var step = MakeStep_WithIntruction(arg);

            var actual = step.Distance;
            var expected = 180;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSteps_WithInstruction_ReturnsStepCollection()
        {
            var arg = "L1, R2, L3";

            var actual = MakeStepCollection_WithInstruction(arg);
            var expected = new List<Step>()
            {
                MakeStep_WithIntruction("L1"),
                MakeStep_WithIntruction("R2"),
                MakeStep_WithIntruction("L3")
            };

            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
