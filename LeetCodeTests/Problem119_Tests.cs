using LeetCode;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem119_Tests
    {
        public Problem119 sut;

        public Problem119_Tests()
        {
            sut = new Problem119();
        }

        [Test]
        public void Example1_Ok()
        {
            var input = 0;
            var result = sut.GetRow(input);

            var expected = new List<int> { 1 };
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Example2_Ok()
        {
            var input = 1;
            var result = sut.GetRow(input);

            var expected = new List<int> { 1, 1 };
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Example3_Ok()
        {
            var input = 3;
            var result = sut.GetRow(input);

            var expected = new List<int> { 1, 3, 3, 1 };
            Assert.AreEqual(expected, result);
        }

    }
}
