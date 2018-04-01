using System.Runtime.CompilerServices;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger _errorLogger;

        [SetUp]
        public void SetUp() {
            _errorLogger = new ErrorLogger();
        }

    [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty() {
            _errorLogger.Log("a");
            
            Assert.That(_errorLogger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error) {
            /* This will cause an exception*/
            //_errorLogger.Log(error);
            
            /* Need to use a delegate (lambda expression) */
            Assert.That(() => _errorLogger.Log(error), Throws.ArgumentNullException);
        }
    }
}