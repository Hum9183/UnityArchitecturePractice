using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

using Hum.FizzBuzz.Editor;

namespace Hum.FizzBuzz.Tests.Editor
{
    /// <summary>
    /// 対応するクラスはなし。全体の振る舞いに対するBDD的なテスト
    /// </summary>
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        public void TestFizzBuzz(int number, string expectedStr)
        {
            var rules = new List<IReplaceRule>
            {
                new CyclicNumberRule(3, "Fizz"),
                new CyclicNumberRule(5, "Buzz"),
                new PassThroughRule()
            };

            var fizzBuzz = new NumberConverter(rules);
            Assert.That(fizzBuzz.Convert(number), Is.EqualTo(expectedStr));
        }
    }
}
