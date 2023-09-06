using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

using Hum.FizzBuzz.Editor;

namespace Hum.FizzBuzz.Tests.Editor
{
    public class CyclicNumberTest
    {
        [Test]
        [TestCase("", 0, "Buzz")]
        [TestCase("Fizz", 0, "FizzBuzz")]
        public void TestApply(string carry, int number, string expectedStr)
        {
            var rule = new CyclicNumberRule(0, "Buzz");
            Assert.That(rule.Apply(carry, number), Is.EqualTo(expectedStr));
        }

        [Test]
        [TestCase("", 1, false)]
        [TestCase("", 3, true)]
        [TestCase("", 6, true)]
        public void TestMatch(string carry, int number, bool expected)
        {
            var rule = new CyclicNumberRule(3, string.Empty);
            Assert.That(rule.Match(carry, number), Is.EqualTo(expected));
        }
    }
}
