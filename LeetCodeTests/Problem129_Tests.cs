using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem129_Tests
    {
        private Problem1296 _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Problem1296();
        }

        [Test]
        public void Example1()
        {
            var input = new int[] { 3, 2, 1, 2, 3, 4, 3, 4, 5, 9, 10, 11 };
            var result = _sut.IsPossibleDivide(input, 3);
            Assert.IsTrue(result);
        }

        [Test]
        public void Example2()
        {
            var input = new int[] { 16, 21, 26, 35 };
            var result = _sut.IsPossibleDivide(input, 4);
            Assert.IsFalse(result);
        }

        [Test]
        public void Example3()
        {
            var input = new int[] { 2, 3, 8, 11 };
            var result = _sut.IsPossibleDivide(input, 2);
            Assert.IsFalse(result);
        }
    }
}
