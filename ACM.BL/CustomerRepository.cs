using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        //Private as no access to this
        private AddressRepository addressRepository { get; set; }
       
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        //Method 'Save' to save the defined customer. Outlines a collaboration relationship.
        public bool Save(Customer customer)
        {
            //Saves the defined customer
            return true;
        }

        //Method to retrieve A SPECIFIC customer - Using the customerId as a parameter
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            //Creating address list for the customer. Collaborative relationship between the Customer and Address Repository
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();

            //Temporary hard coded values to return a populated customer
            if (customerId == 1)
            {
                //Building customer
                customer.EmailAddress = "divyesh@me.com";
                customer.FirstName = "Divyesh";
                customer.LastName = "Chudasama";
            }
            return customer;
        }

        //Second Retrieve Method that returns a LIST of customers
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
    }
}
