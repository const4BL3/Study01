using NUnit.Framework;
using Study01;

namespace Study01Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MakeALine()
        {
            string expected = @"3 3 3
";

            Lines lines = new Lines();
            var result = lines.MakeALine(3);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void MakeAllLines()
        {
            string expected = @"1
2 2
3 3 3
4 4 4 4";
            Lines lines = new Lines();
            var result = lines.MakeAllLines(4);
            Assert.AreEqual(expected, result);
        }
    }
}
