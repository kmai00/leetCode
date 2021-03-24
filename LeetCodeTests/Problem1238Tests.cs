using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem1238Tests
    {
        Problem1238 _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Problem1238();
        }

        [Test]
        public void Example_1()
        {
            var n = 2;
            var start = 3;

            var result = _sut.CircularPermutation(n, start);

            var expected = new List<int> { 3, 2, 0, 1 };
            Assert.AreEqual(expected, result);
        }
    }
}
