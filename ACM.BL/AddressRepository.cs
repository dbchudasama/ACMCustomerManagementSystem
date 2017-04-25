using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        //Method to save current address
        private void Save(Address address)
        {
            address.Save(); //Invoking Save Method
        }

        //Return a sequence of Data as the customer may have more than 1 address.
        public IEnumerable<Address> LoadCustomerAddress(Customer customer)
        {
            return new List<Address>()
            {
                 new Address(1)
                    {
                        //Temporary hard coded values to return a set of addresses for a customer
                        AddressType = 1,
                        StreetLine1 = "Durham Road",
                        City = "Loughborough",
                        State = "Lesicestershire",
                        Country = "UK",
                        PostalCode = "ABCDEF"
                    },
                 new Address(2)
                    {
                        //Temporary hard coded values to return a set of addresses for a customer
                        AddressType = 2,
                        StreetLine1 = "Rendell Streeet",
                        City = "Loughborough",
                        State = "Leicestershire",
                        Country = "UK",
                        PostalCode = "ABBCCD"
                    }
            };
        }
}
