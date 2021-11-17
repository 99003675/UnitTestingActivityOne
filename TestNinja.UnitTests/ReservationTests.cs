using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestNinja;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
        {
            // Arrange
            //var user = new User();
            var reservation = new Reservation { MadeBy = new User() };

            // Act
            var result = reservation.CanBeCancelledBy(new User());

            // Assert
            Assert.IsFalse(result);
        }
    }
}
