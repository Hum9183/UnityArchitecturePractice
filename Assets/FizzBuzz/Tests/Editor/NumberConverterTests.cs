using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

using Hum.FizzBuzz.Editor;

namespace Hum.FizzBuzz.Tests.Editor
{
    public class NumberConverterTests
    {
        [Test]
        [TestCase(1, "")]
        public void TestConvertWithEmptyRules(int number, string expected)
        {
            var fizzBuzz = new NumberConverter(new List<IReplaceRule>());
            Assert.That(fizzBuzz.Convert(number), Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1, "Replaced")]
        public void TestConvertWithSingleRules(int number, string expected)
        {
            var rule = new ReplaceRuleMock("", 1, true, "Replaced");
            var fizzBuzz = new NumberConverter(new List<IReplaceRule> { rule });
            Assert.That(fizzBuzz.Convert(number), Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1, "FizzBuzz")]
        public void TestConvertCompositingRuleResults(int number, string expected)
        {
            var rule01 = new ReplaceRuleMock("", 1, true, "Fizz");
            var rule02 = new ReplaceRuleMock("Fizz", 1, true, "FizzBuzz");
            var fizzBuzz = new NumberConverter(new List<IReplaceRule> { rule01, rule02 });
            Assert.That(fizzBuzz.Convert(number), Is.EqualTo(expected));
        }

        [Test]
        [TestCase(1, "1")]
        public void TestConvertSkippingUnmatchedRules(int number, string expected)
        {
            var rule01 = new ReplaceRuleMock("", 1, false, "Fizz");
            var rule02 = new ReplaceRuleMock("", 1, false, "Buzz");
            var rule03 = new ReplaceRuleMock("", 1, true, "1");
            var fizzBuzz = new NumberConverter(new List<IReplaceRule> { rule01, rule02, rule03 });
            Assert.That(fizzBuzz.Convert(number), Is.EqualTo(expected));
        }

        private class ReplaceRuleMock : IReplaceRule
        {
            private readonly string _expectedCarry;
            private readonly int    _expectedNumber;
            private readonly bool   _matchResult;
            private readonly string _replacement;

            public ReplaceRuleMock(
                string expectedCarry, int expectedNumber,
                bool matchResult, string replacement)
            {
                _expectedCarry = expectedCarry;
                _expectedNumber = expectedNumber;
                _matchResult = matchResult;
                _replacement = replacement;
            }

            public string Apply(string carry, int number)
            {
                if (carry.Equals(_expectedCarry) && number.Equals(_expectedNumber))
                    return _replacement;
                return string.Empty;
            }

            public bool Match(string carry, int number)
            {
                if (carry.Equals(_expectedCarry) && number.Equals(_expectedNumber))
                    return _matchResult;
                return false;
            }
        }
    }
}
