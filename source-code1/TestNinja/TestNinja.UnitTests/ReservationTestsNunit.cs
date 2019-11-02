using NUnit.Framework;
using TestNinja.Fundamentals;


namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTestsNunit
    {
        [Test]
        public void CanBeCancelledByUser_AdminUser_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();
            
            // Act
            var result = reservation.CanBeCancelledBy(new User {IsAdmin = true});

            // Assert
//            Assert.IsTrue(result);
            Assert.That(result);
//            Assert.That(result, Is.True);
        }
        
    }
}   