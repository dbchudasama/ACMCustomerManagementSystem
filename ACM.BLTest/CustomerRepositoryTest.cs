using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrievingExisting()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            { 
                //Setting Email Address, First Name and Last Name 
                EmailAddress = "divyesh@me.com",
                FirstName = "Divyesh",
                LastName = "Chudasama"
            };

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert - Comparing each property of the object and assuming these to be the same as the ibject types are not the same
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
