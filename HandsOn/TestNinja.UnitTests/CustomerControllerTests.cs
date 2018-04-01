using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound() {
            var controller = new CustomerController();

            var result =  controller.GetCustomer(0);
            
            /* The type itself */
            Assert.That(result, Is.TypeOf<NotFound>());
            
            /*The type or one of its derivatives*/
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }
        
        [Test]
        public void GetCustomer_IdIsZero_ReturnOk() {
            
        }
        
    }
}