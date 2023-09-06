using NUnit.Framework;
using Hum.Sample.Editor;

namespace Hum.Sample.Tests.Editor
{
    public class MathUtilTests
    {
        [Test]
        [TestCase(2, 1, 3, 2)] // 範囲内
        [TestCase(0, 1, 3, 1)] // 範囲外
        [TestCase(4, 1, 3, 3)] // 範囲外
        [TestCase(1, 1, 3, 1)] // 境界値と同値は範囲内
        [TestCase(3, 1, 3, 3)] // 境界値と同値は範囲内
        public void TestSaturate(int value, int min, int max, int expected)
        {
            // NOTE:
            // ゼロや負の数をテストしていないから境界値が甘いんじゃないかという点は問題ない。
            // 理由は、ゼロや負の数で問題がないことはMin()とMax()のテストで保証されているため。
            // もしMin()やMax()のテストがない or ゼロや負の数でテストしていない場合は、
            // このTestSaturate()でテストする必要がある。

            // 単体テストは機能結合テストにならないように十分に注意する必要がある
            // 上位のモジュールで下位のモジュールの責務までテストシナリオを増やすと、
            // 際限なくパターンが増えてしまう。
            // 下位モジュールで心配しなくても良いとわかったリスクは無視し、
            // テスト対象のロジック検証のみに集中するのが単体テストを積み重ねる意味。
            var mathUtil = new MathUtil();
            var saturateResult = mathUtil.Saturate(value, min, max);
            Assert.That(saturateResult, Is.EqualTo(expected));
        }
    }
}
