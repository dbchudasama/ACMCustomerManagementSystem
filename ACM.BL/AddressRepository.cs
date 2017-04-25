using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            //Creating the instance of the Address class. Passing in the Requested Id
            return new Address()
            {
                //Temporary hard coded values to return a populated address
                StreetLine1 = "Durham Road",
                City = "Loughborough",
                State = "Leicestershire",
                Country = "UK",
                PostalCode = "ABCDEF"
            };
        }

        //Return a sequence of Data aas the customer may have more than 1 address
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
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

        //Method to return current address
        public bool Save(Address address)
        {
            return true;
        }
    }
}
