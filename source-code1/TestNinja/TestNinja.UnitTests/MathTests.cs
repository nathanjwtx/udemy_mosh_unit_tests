using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        // this replace the 3 single test methods below
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnGreaterArg(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [Ignore("For learning purposes only")]
        public void Add_WhenCalled_ReturnArgSum()
        {

            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgGreater_FirstArg()
        {

            var result = _math.Max(2, 1);

            Assert.That(result, Is.EqualTo(2));
        }
        
        [Test]
        public void Max_SecondArgGreater_SecondArg()
        {

            var result = _math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgsEqual_ReturnSameArg()
        {

            var result = _math.Max(3, 3);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void GetOddNumbers_LimitGreaterThanZero_ReturnOddUpToLimit()
        {
            var result =_math.GetOddNumbers(5);

//            Assert.That(result, Is.Not.Empty);
//            Assert.That(result.Count(), Is.EqualTo(3));
//            Assert.That(result, Does.Contain(1));
//            Assert.That(result, Does.Contain(3));
//            Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new [] {1, 3, 5}));

//            Assert.That(result, Is.Ordered);
//            Assert.That(result, Is.Unique);
        }
    }
}   