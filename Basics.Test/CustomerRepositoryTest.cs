using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Basics.Test
{
    [TestClass]
    public class CustomerRepositoryTest
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
            Assert.AreEqual(1, customer.CustomerId);
            Assert.AreEqual("Kishor", customer.FirstName);
            Assert.AreEqual("Kira", customer.LastName);


        }
        [TestMethod]
        public void SortByName()
        {
            //Arrange 
            var repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            //Act 
            var customers = repository.SortByName(customerList);
            var customer = customers.First();

            //Assert
            Assert.IsNotNull(customer);
            Assert.AreEqual(3, customer.CustomerId);
            Assert.AreEqual("Ram", customer.FirstName);
            Assert.AreEqual("DVS", customer.LastName);


        }
        [TestMethod]
        public void SortByNameReverse()
        {
            //Arrange 
            var repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            //Act 
            var customers = repository.SortByNameReverse(customerList);
            var customer = customers.First();

            //Assert
            Assert.IsNotNull(customer);
            Assert.AreEqual(2, customer.CustomerId);
            Assert.AreEqual("Aditya", customer.FirstName);
            Assert.AreEqual("Vardhan", customer.LastName);


        }
        [TestMethod]
        public void SortByTypeId()
        {
            //Arrange 
            var repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            //Act 
            var customers = repository.SortByTypeId(customerList);
           

            //Assert
            Assert.IsNotNull(customers);
            Assert.AreEqual(null, customers.Last().CustomerTypeId);
          


        }
        [TestMethod]
        public void GetNames()
        {
            //Arrange 
            var repository = new CustomerRepository();
            var customerList = repository.Retrieve();
            
            //Act 
            var customers = repository.GetNames(customerList);
           
            //Assert
            Assert.IsNotNull(customers);
            Assert.AreEqual("Kishor, Kira", customers.First());
        }
    }
}
    