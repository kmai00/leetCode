using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{
    [TestFixture]
    public class Problem28_Tests
    {
        Problem28 _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Problem28();
        }

        [Test]
        public void DoubleLs()
        {
            var haystack = "hello";
            var needle = "ll";

            var result = _sut.StrStr(haystack, needle);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void NotSubstring() { 
            var haystack = "aaaaa";
            var needle = "bba";

            var result = _sut.StrStr(haystack, needle);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void EmptyString() { 
            var haystack = "";
            var needle = "";

            var result = _sut.StrStr(haystack, needle);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void NoHayButOneNeedle() { 
            var haystack = "";
            var needle = "a";

            var result = _sut.StrStr(haystack, needle);
            Assert.AreEqual(-1, result);
        }
        
        [Test]
        public void SingleCharacter() { 
            var haystack = "a";
            var needle = "a";

            var result = _sut.StrStr(haystack, needle);
            Assert.AreEqual(0, result);
        }

    }
}
