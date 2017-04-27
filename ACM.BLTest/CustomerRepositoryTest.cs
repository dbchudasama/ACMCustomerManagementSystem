using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
       /* [TestMethod]
        public void RetrievingExisting()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer()
            { 
                //Setting Email Address, First Name and Last Name 
                EmailAddress = "divyesh@me.com",
                FirstName = "Divyesh",
                LastName = "Chudasama",
            };

            //Act
            var actual = customerRepository.LoadCustomer(expected);

            //Assert - Comparing each property of the object and assuming these to be the same as the ibject types are not the same
            //Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer()
            {
                //Setting Email Address, First Name and Last Name 
                EmailAddress = "divyesh@me.com",
                FirstName = "Divyesh",
                LastName = "Chudasama",
                AddressList = new List<Address>()
                    {
                        new Address()
                        {
                            AddressType = 1,
                            StreetLine1 = "Durham Road",
                            City = "Loughborough",
                            State = "Lesicestershire",
                            Country = "UK",
                            PostalCode = "ABCDEF"
                        },
                        new Address()
                        {
                            AddressType = 2,
                            StreetLine1 = "Rendell Streeet",
                            City = "Loughborough",
                            State = "Leicestershire",
                            Country = "UK",
                            PostalCode = "ABBCCD"
                        }
                    }
            };

            //Act
            var actual = customerRepository.LoadCustomer(expected);

            //Assert - Comparing each property of the object and assuming these to be the same as the ibject types are not the same
            //Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            //For loop to check both the addresses
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }*/
    }
}
