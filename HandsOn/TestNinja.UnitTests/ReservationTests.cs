using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    /*
    [TestMethod]
    public void CanBeCancelledBy_Scenario_ExpectedBehavior()
    {

    //Arrange; Initialization
    var reservation = new Reservation();

    //Act; Calliing a tested method as assigning the result to a variable.
    var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

    //Assert: Verifying if 'result' is correct.
    Assert.IsTrue(result);
    }
    */


    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue() {
            //Arrange; Initialization
            var reservation = new Reservation();

            //Act; Calliing a method
            var result = reservation.CanBeCancelledBy(new User {IsAdmin = true});

            //Assert: Verifying if 'result' is correct.
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsUser_ReturnsTrue() {
            //Arrange; Initialization
            var reservation = new Reservation {MadeBy = new User()};

            //Act; Calliing a method
            var result = reservation.CanBeCancelledBy(reservation.MadeBy);

            //Assert: Verifying if 'result' is correct.
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsNotRecocgnized_ReturnsFalse() {
            //Arrange; Initialization
            var reservation = new Reservation();

            //Act; Calliing a tested method as assigning the result to a variable.
            var result = reservation.CanBeCancelledBy(new User());

            //Assert: Verifying if 'result' is correct.
            Assert.IsFalse(result);
        }
    }
}
