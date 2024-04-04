using NUnit.Framework;

namespace TrpoLab3.Tests
{
    [TestFixture]
    public class CalcTest
    {
        [Test]
        public void SurfAreaTest()
        {
            const double r = 6;
            const double h = 7;
            const double pi = Math.PI;
            const double expected = 156 * pi;

            var result = new TRPO_Lab3.Lib.Cylinder().SurfArea(r, h);

            Assert.AreEqual(expected, result);
        }
    }
}
