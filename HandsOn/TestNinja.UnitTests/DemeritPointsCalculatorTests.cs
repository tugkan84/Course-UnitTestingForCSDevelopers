using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {

        private DemeritPointsCalculator _demeritPointsCalculator;
        
        [SetUp]
        public void SetUp() {
            _demeritPointsCalculator  = new DemeritPointsCalculator();
        }
        
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_InvalidInput_ThrowArgumentOutOfRangeException( int input) {
            Assert.That(() => _demeritPointsCalculator.CalculateDemeritPoints(input),Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        
        [Test]
        [TestCase(0)]
        [TestCase(65)]
        public void CalculateDemeritPoints_InputIsSmallerOrEqualSpeedLimit_Retuns0(int speed) {
            var result = _demeritPointsCalculator.CalculateDemeritPoints(speed);
            
            Assert.That(result, Is.EqualTo(0));
        }
        
        [Test]
        public void CalculateDemeritPoints_InputIsGreaterThanSpeedLimit_ReturnsQtyDemeritPoints() {
            var result = _demeritPointsCalculator.CalculateDemeritPoints(70);
            
            Assert.That(result, Is.EqualTo(1));
            
        }
    }
}