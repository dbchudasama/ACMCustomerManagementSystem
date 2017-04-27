using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
       /* [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange - Initialised variables
            Customer customer = new Customer();
            customer.FirstName = "Divyesh";
            customer.LastName = "Chudasama";

            string expected = "Divyesh, Chudasama";

            //Actual - Actual expected outcome - Expecting Full Name to be returned
            string actual = customer.FullName;

            //Assert - Build the test
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.LastName = "Chudasama";

            string expected = "Chudasama";

            //Actual
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Divyesh";

            string expected = "Divyesh";

            //Actual
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void StaticTest()
        {
            //Arrange
            var c1 = new Customer();
            c1.FirstName = "Bhavini";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Bhakti";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Bhagirath";
            Customer.InstanceCount += 1;

            //Actual

            //Assert - Instance count should be equal to '3'
            Assert.AreEqual(3, Customer.InstanceCount);
        }*/

        /*
        [TestMethod]

        public void ValidateValid()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "Bhavini";
            customer.EmailAddress = "bhavini@abc.com";

            var expected = true;

            //Actual - Invoking the Validate() Method on this Customer object instance
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);

        }
        */

        /*
        [TestMethod]

        public void ValidateMissingFirstName()
        {
            //Arrange
            var customer = new Customer();
            customer.EmailAddress = "bhavini@abc.com";

            var expected = false;

            //Actual - Invoking the Validate() Method on this Customer object instance
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);

        }
        */
    }
}
