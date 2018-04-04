using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutput_GivenNumberIsDivisableBy3And5_ReturnsFizzBuzz() {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_GivenNumberIsDivisableBy3Only_ReturnsFizz() {
            var result = FizzBuzz.GetOutput(9);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_GivenNumberIsDivisableBy5Only_ReturnsBuzz() {
            var result = FizzBuzz.GetOutput(25);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_GivenNumberNotDivisableBy3or5or3and5_ReturnsGivenNumberAsString() {
            var result = FizzBuzz.GetOutput(2);

            Assert.That(result, Is.EqualTo("2"));
        }
    }
}
    
    
