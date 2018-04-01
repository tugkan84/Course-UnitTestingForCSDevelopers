using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement() {
            var formatter = new HtmlFormatter();
            
            var result = formatter.FormatAsBold("abc");
            
            // Specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));    
            
            /*
            // More general
            Assert.That(result, Does.StartWith("<strong>"));
            //or
            Assert.That(result, Does.EndWith("<strong>"));
            //or
            Assert.That(result, Does.Contain("abc"));
            */
        }
    }
}