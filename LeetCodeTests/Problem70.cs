using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem70Tests
    {
        Problem70 sut;

        public Problem70Tests()
        {
            sut = new Problem70();
        }

        [Test]
        public void Example1_Ok()
        {
            var result = sut.ClimbStairs(2);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Example2_Ok()
        {
            var result = sut.ClimbStairs(3);
            Assert.AreEqual(3, result);
        }
    }
}
