using System;
using NUnit.Framework;
using TestProject;

namespace TestProject.UnitTests
{
    [TestFixture]
    public class UnitTesting
    {
        private MyMath _math;

        [SetUp]
        public void Setup()
        {
            _math = new MyMath();
        }
        
        [Test]
        [TestCase(0, 1)]
        public void NotZero_InputX_Return0(int x, int y)
        {
            var result = _math.Division(x, y);
            
            Assert.That(result, Is.EqualTo(0));
        }
    }
}