using NUnit.Framework;
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


    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue() {
            //Arrange; Initialization
            var reservation = new Reservation();

            //Act; Calliing a method
            var result = reservation.CanBeCancelledBy(new User {IsAdmin = true});

            //Assert: Verifying if 'result' is correct.
            Assert.That(result,Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue() {
            var user = new User();
            var reservation = new Reservation {MadeBy = user};

            var result = reservation.CanBeCancelledBy(user);

            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse() {
            var reservation = new Reservation {MadeBy = new User()};

            var result = reservation.CanBeCancelledBy(new User());

            Assert.That(result, Is.False);
        }
    }
}
