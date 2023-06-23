using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem1480_Tests
    {
        private Problem1480 _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Problem1480();
        }

        [Test]
        public void Example1()
        {
            var nums = new int[] { 1, 2, 3, 4 };

            var result = _sut.RunningSum(nums);
            Assert.AreEqual(new int[] { 1, 3, 6, 10 }, result);
        }
    }
}
