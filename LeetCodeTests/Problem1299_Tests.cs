using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem1299_Tests
    {
        private Problem1299 _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Problem1299();
        }

        [Test]
        public void Example1()
        {
            var input = new int[] { 17, 18, 5, 4, 6, 1 };
            var expected = new int[] { 18, 6, 6, 6, 1, -1 };

            var result = _sut.ReplaceElements(input);
            Assert.AreEqual(expected, result);
        }
    }
}
