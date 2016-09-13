using Nardax;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nardax.Tests
{
    [TestClass]
    public class TruncateStringExtensionsTests
    {
        private string _value;

        [TestInitialize]
        public void TestInitialize()
        {
            _value = "123456789";
        }

        [TestMethod]
        public void TruncateLeft_ValueIsLarger_TruncateRemovesLeftSide()
        {
            var expected = "9";

            var result = _value.TruncateLeft(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TruncateLeft_ValueIsSmaller_TruncateRemovesLeftSide()
        {
            var expected = "123456789";

            var result = _value.TruncateLeft(20);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]

        public void RepeatMeTest()
        {
            var result = "käbbel".RepeatMe(3);
            var expected = "käbbelkäbbelkäbbel";
            Assert.AreEqual(result, expected);
        }

        [TestMethod()]
        public void RepeatMe_DefaultValueTest()
        {
            var result = "NyanCat".RepeatMe();
            var expected = "NyanCatNyanCatNyanCatNyanCatNyanCat";
            Assert.AreEqual(result, expected);
        }

        [TestMethod()]
        public void RemoveWhiteSpaceTest()
        {
            var testString = "i\twill \tsurvive\t";
            var result = testString.RemoveWhiteSpace();
            var expected = "iwillsurvive";
            Assert.AreEqual(expected, result);

        }
    }
}
