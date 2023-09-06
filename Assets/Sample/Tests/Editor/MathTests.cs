using NUnit.Framework;
using Hum.Sample.Editor;

namespace Hum.Sample.Tests.Editor
{
    public class MathTests
    {
        [Test]
        [TestCase(0, 1, 0)]
        [TestCase(1, 0, 0)]
        [TestCase(0, -1, -1)]
        [TestCase(-1, 0, -1)]
        [TestCase(0, 0, 0)]
        [TestCase(0, int.MaxValue, 0)]
        [TestCase(0, int.MinValue, int.MinValue)]
        public void TestMin(int minA, int minB, int minExpected)
        {
            var math = new Math();
            var minResult = math.Min(minA, minB);
            Assert.That(minResult, Is.EqualTo(minExpected));
        }

        [Test]
        [TestCase(0, 1, 1)]
        [TestCase(1, 0,1)]
        [TestCase( 0, -1,-0)]
        [TestCase(-1, 0,0)]
        [TestCase(0, 0,0)]
        [TestCase(0, int.MaxValue, int.MaxValue)]
        [TestCase(0, int.MinValue, 0)]
        public void TestMax(int maxA, int maxB, int maxExpected)
        {
            var math = new Math();
            var minResult = math.Max(maxA, maxB);
            Assert.That(minResult, Is.EqualTo(maxExpected));
        }
    }
}
