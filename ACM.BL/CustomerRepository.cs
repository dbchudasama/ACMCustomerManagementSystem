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
        private void Save(Customer c)
        {
            c.Save(); //Invoking Save Method
        }

        //Create Customer 
         void CreateCustomer(Customer c)
        {
            c.CreateCustomer(c); //Invoking Create Customer Method

        }

        //Load Customer
        public Customer LoadCustomer(Customer c)
        {
            return c;
        }

        //Load ALL Customers
        //Return a list of all Customers
        public static List<Customer> LoadAllCustomers()
        {
            return new List<Customer>();
        }

        //Load a selected number of customers 
        public static List<Customer> LoadManyCustomers(string filter)
        {
            return new List<Customer>();
        }
    }
}
