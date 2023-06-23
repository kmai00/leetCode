using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestFixture]
    public class Assesstment2
    {
        private Assessment2 _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Assessment2();
        }

        [Test]
        public void Example1()
        {
            var forest = new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 0, 0, 4 }, new List<int> { 7, 6, 5 } };
            var result = _sut.CutOffTree(forest);
            Assert.AreEqual(6, result);
        }
    }
}
