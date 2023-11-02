using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests
{

    [TestFixture]
    public class ChatamAssessment_1_Tests
    {
        private ChatamAssessment_1 sut;
        
        public ChatamAssessment_1_Tests()
        {
            sut = new ChatamAssessment_1();
        }

        [Test]
        public void NumberOfWords_Ok()
        {
            var doc = "I'm a very good programmer. Even though I am just 12 years old.";
            var result = sut.Analyze(doc);
            Assert.AreEqual(13, result.NumberOfAllWords);
        }

        [Test]
        public void NumbersOfOnlyDigit_Ok()
        {
            var doc = "I'm a very good programmer. Even though I am just 12 years old.";
            var result = sut.Analyze(doc);
            Assert.AreEqual(1, result.NumberOfWordsThatContainOnlyDigits);
        }

        [Test]
        public void NumbersOfStartingLowercase_Ok()
        {
            var doc = "I'm a very good programmer. Even though I am just 12 years old.";
            var result = sut.Analyze(doc);
            Assert.AreEqual(9, result.NumberOfWordsStartingWithSmallLetter);
        }


        [Test]
        public void NumbersOfStartingUppercase_Ok()
        {
            var doc = "I'm a very good programmer. Even though I am just 12 years old.";
            var result = sut.Analyze(doc);
            Assert.AreEqual(3, result.NumberOfWordsStartingWithCapitalLetter);
        }

        [Test]
        public void LongestWord_Ok()
        {
            var doc = "I'm a very good programmer. Even though I am just 12 years old.";
            var result = sut.Analyze(doc);
            Assert.AreEqual("programmer.", result.TheLongestWord);
        }

        [Test]
        public void ShortestWord_Ok()
        {
            var doc = "I'm a very good programmer. Even though I am just 12 years old.";
            var result = sut.Analyze(doc);
            Assert.AreEqual("a", result.TheShortestWord);
        }

        [Test]
        public void TieForShortestAndLongest() {
            var doc = "a b c xxx yyy zzz";
            var result = sut.Analyze(doc);
            Assert.AreEqual("a", result.TheShortestWord);
            Assert.AreEqual("xxx", result.TheLongestWord);
        }

        [Test]
        public void IndexOutOfBound()
        {
            var doc = ", A . 1 B 2 C a&^&&%%$##%%^&5656 3 a 4 b 5 c 6 &8&%%$67 jkkk sssff , A . 1 B 2 C a&^&&%%$##%%^&5656 3 a 4 b 5 c 6 &8&%%$67 jkkk sssff , A . 1 B 2 C a&^&&%%$##%%^&5656 3 a 4 b 5 c 6 &8&%%$67 jkkk sssff , A . 1 B 2 C a&^&&%%$##%%^&5656 3 a 4 b 5 c 6 &8&%%$67 jkkk sssff , A . 1 B 2 C a&^&&%%$##%%^&5656 3 a 4 b 5 c 6 &8&%%$67 jkkk sssff , A . 1 B 2 C a&^&&%%$##%%^&5656 3 a 4 b 5 c 6 &8&%%$67 jkkk sssff , A . 1 B 2 C a&^&&%%$##%%^&5656 3 a 4 b 5 c 6 &8&%%$67 jkkk sssff , A . 1 B 2 C a&^&&%%$##%%^&5656 3 a 4 b 5 c 6 &8&%%$67%^&%&^%67457687643576438756438756$%$%$%%4343 jkkk sssff , A . 1 B 2 C a&^&&%%$##%%^&5656 3 a 4 b 5 c 6 &8&%%$67 jkkk sssff , A . 1 B 2 C a&^&&%%$##%%^&5656 3 a 4 b 5 c 6 &8&%%$67 jkkk sssff";
            var result = sut.Analyze(doc);
        }
    }
}
