using mathtesting;
using NUnit.Framework;

namespace mathtestingtests
{
    [TestFixture]
    public class Tests
    {
        private MathTests _math;
        
        [SetUp]
        public void Setup()
        {
            _math = new MathTests();
        }

        [TestCase(0, 1)]
        [TestCase(1, 0)]
        public void Division_WhenCalled_Returns0IfXorYis0(int x, int y)
        {
            var result = _math.Division(x, y);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}