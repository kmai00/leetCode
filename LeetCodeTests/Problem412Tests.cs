using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem412Tests
    {
        Problem412 _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Problem412();
        }

        [Test]
        public void Example_1()
        {
            var n = 15;
            var expected = new List<string> {
               "1",
               "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "7",
                "8",
                "Fizz",
                "Buzz",
                "11",
                "Fizz",
                "13",
                "14",
                "FizzBuzz"
            };

            var result = _sut.FizzBuzz(n);
            Assert.AreEqual(expected, result);
        }
    }
}
