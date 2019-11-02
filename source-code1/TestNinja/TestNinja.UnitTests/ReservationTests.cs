using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User {IsAdmin = true});

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsMadeBy_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user};
            
            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanNotBeCancelledByOtherUser_ReturnsFalse()
        {
             // Arrange
            var user = new User(); // didn't need to declare these here. See below
            var user1 = new User();
            var reservation = new Reservation {MadeBy = user};
//            var reservation = new Reservation {MadeBy = new User()};
            
            // Act
            var result = reservation.CanBeCancelledBy(user1);
//            var result = reservation.CanBeCancelledBy(new User());
            
            // Assert
            Assert.IsFalse(result);
            
        }
    }
}
