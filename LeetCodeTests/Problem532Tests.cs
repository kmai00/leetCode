using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem532Tests
    {
        Problem532 _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Problem532();
        }

        [Test]
        public void Example_1()
        {
            var nums = new int[] { 3, 1, 4, 1, 5 };
            var k = 2;

            var result = _sut.FindPairs(nums, k);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Example_2()
        {
            var nums = new int[] { 1, 2, 3, 4, 5 };
            var k = 1;

            var result = _sut.FindPairs(nums, k);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Example_3()
        {
            var nums = new int[] { 1, 3, 1, 5, 4 };
            var k = 0;

            var result = _sut.FindPairs(nums, k);
            Assert.AreEqual(1, result);
        }


        [Test]
        public void Example_4()
        {
            var nums = new int[] { 1, 2, 4, 4, 3, 3, 0, 9, 2, 3 };
            var k = 3;

            var result = _sut.FindPairs(nums, k);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Example_5()
        {
            var nums = new int[] { -1, -2, -3 };
            var k = 1;

            var result = _sut.FindPairs(nums, k);
            Assert.AreEqual(2, result);
        }

    }
}
