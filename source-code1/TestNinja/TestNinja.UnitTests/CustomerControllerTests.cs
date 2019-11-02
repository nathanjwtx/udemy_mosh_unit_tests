using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IDIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);
            // NotFound
            Assert.That(result, Is.TypeOf<NotFound>());
//            or
            // NotFound or one of its derivatives
//            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IDIsNotZero_ReturnOK()
        {
            
        }
    }
}