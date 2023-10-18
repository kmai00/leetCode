using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem190_Tests
    {
        private Problem190 sut;

        public Problem190_Tests()
        {
            sut = new Problem190();
        }


        [Test]
        public void Example1_Ok()
        {
            uint n = 1;
            var result = sut.reverseBits(n);
            Assert.AreEqual(2147483648, result);
        }

        [Test]
        public void Example2_Ok()
        {
            uint n = 43261596;
            var result = sut.reverseBits(n);
            Assert.AreEqual(964176192, result);
        }
    }
}
