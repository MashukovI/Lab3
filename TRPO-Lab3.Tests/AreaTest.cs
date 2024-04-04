using NUnit.Framework;
using TRPO_Lab3.Lib;

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

        [Test]
        public void SurfAreaExcTest()
        {
            const double r = -6;
            const double h = 7;
            Cylinder cylinder = new Cylinder();
            Assert.Throws<ArgumentOutOfRangeException>(() => cylinder.SurfArea(r, h));

        }
    }
}
