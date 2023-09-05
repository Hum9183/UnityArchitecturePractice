using NUnit.Framework;
using Hum.ArchitecturePractice.Editor;

namespace Hum.ArchitecturePractice.Tests.Editor
{
    public class MathTests
    {
        [Test]
        public void TestMinMax()
        {
            var math = new Math();

            var minExpected = 1;
            var minResult = math.Min(1, 2);
            Assert.That(minExpected, Is.EqualTo(minResult));

            var maxExpected = 2;
            var maxResult = math.Max(1, 2);
            Assert.That(maxExpected, Is.EqualTo(maxResult));
        }
    }
}
