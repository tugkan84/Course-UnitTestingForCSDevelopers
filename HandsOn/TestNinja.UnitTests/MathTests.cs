using System.Linq.Expressions;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests {

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments() {
            var math = new Math();

            var result =  math.Add(1, 2);
            
            Assert.That(result, Is.EqualTo(3));
        }
    }
} 