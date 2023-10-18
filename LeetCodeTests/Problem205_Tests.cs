using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem205_Tests
    {
        Problem205 sut;

        public Problem205_Tests()
        {
            sut = new Problem205();
        }

        [Test]
        public void Example1_Ok()
        {
            var result = sut.IsIsomorphic("egg", "add");
            Assert.IsTrue(result);
        }

        [Test]
        public void Example37_Ok()
        {
            var result = sut.IsIsomorphic("badc", "baba");
            Assert.IsFalse(result);
        }
    }
}
