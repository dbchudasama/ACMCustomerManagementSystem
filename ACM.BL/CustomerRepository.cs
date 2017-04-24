using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        //Method 'Save' to save the defined customer
        public bool Save()
        {
            return true;
        }

        //Method to retrieve A SPECIFIC customer - Using the customerId as a parameter
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

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
