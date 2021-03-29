using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem594Tests
    {
        Problem594 _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Problem594();
        }

        [Test]
        public void Example_1()
        {
            var nums = new int[] { 1, 3, 2, 2, 5, 2, 3, 7 };

            var result = _sut.FindLHS(nums);

            Assert.AreEqual(5, result);
        }

        [Test]
        public void Example_2()
        {
            var nums = new int[] { 1, 2, 3, 4 };

            var result = _sut.FindLHS(nums);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Example_3()
        {
            var nums = new int[] { 1, 1, 1, 1 };

            var result = _sut.FindLHS(nums);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Example_4()
        {
            var nums = new int[] { 1, 2, 1, 3, 0, 0, 2, 2, 1, 3, 3 };
            var result = _sut.FindLHS(nums);

            Assert.AreEqual(6, result);
        }

        [Test]
        public void Example_5()
        {
            var nums = new int[] { 1, 4, 1, 3, 1, -14, 1, -13 };
            var result = _sut.FindLHS(nums);

            Assert.AreEqual(2, result);
        }

    }
}
