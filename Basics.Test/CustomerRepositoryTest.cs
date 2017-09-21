using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Basics.Test
{
    [TestClass]
    class CustomerRepositoryTest
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void FindExistingCustomerTest()
        {
            //Arrange 
            var repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            //Act 
            var customer = repository.FindCustomer(customerList, 1);

            //Assert
            Assert.IsNotNull(customer);
            Assert.AreEqual(2, customer.CustomerId);

        }
    }
}
    