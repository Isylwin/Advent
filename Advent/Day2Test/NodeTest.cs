using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2Test
{
    [TestClass]
    public class NodeTest
    {
        [TestMethod]
        public void GetValue_WithString_ReturnsFive()
        {
            var actual = TestUtil.MakeNode_WithString("5");

            Assert.AreEqual("5", actual.Value);
        }
    }
}
