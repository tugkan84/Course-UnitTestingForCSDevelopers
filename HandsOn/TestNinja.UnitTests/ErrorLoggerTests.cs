            using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger _logger;

        [SetUp]
        public void SetUp() {
            _logger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty() {
            _logger.Log("a");
            
            Assert.That(_logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error) {
            /* This will cause an exception*/
            //_logger.Log(error);
            
            /* Need to use a delegate (lambda expression) */
            Assert.That(() => _logger.Log(error), Throws.ArgumentNullException);
        }
        
        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent() {
            
            /* arrange */
            var id = Guid.Empty;
            _logger.ErrorLogged += (sender, args) => { id = args; };
            
            
            /* Act */
            _logger.Log("a");
            
            /* Assert */
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    
    
    
    }
}
