using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

using Hum.FizzBuzz.Editor;

namespace Hum.FizzBuzz.Tests.Editor
{
    public class PassThroughRuleTests
    {
        [Test]
        [TestCase("", 1, "1")]
        [TestCase("", 2, "2")]
        [TestCase("Fizz", 3, "3")]
        public void TestApply(string carry, int number, string expectedStr)
        {
            var rule = new PassThroughRule();
            Assert.That(rule.Apply(carry, number), Is.EqualTo(expectedStr));
        }

        [Test]
        [TestCase("", 0, true)]
        [TestCase("Fizz", 0, false)]
        public void TestMatch(string carry, int number, bool expected)
        {
            var rule = new PassThroughRule();
            Assert.That(rule.Match(carry, number), Is.EqualTo(expected));
        }
    }
}
