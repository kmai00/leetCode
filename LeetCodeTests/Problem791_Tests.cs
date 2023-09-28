using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem791_Tests
    {

        [Test]
        public void Example1()
        {

            var input = "cba";
            var s = "abcd";
            var result = Problem791.CustomSortString(input, s);

            Assert.AreEqual("cbad", result);
        }
    }
}
