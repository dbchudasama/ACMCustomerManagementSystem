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
            Address address = new Address();

            //Temporary hard coded values to return a populated address
            if (addressId == 1)
            {
                address.StreetLine1 = "Durham Road";
                address.City = "Loughborough";
                address.State = "Leicestershire";
                address.Country = "UK";
                address.PostalCode = "ABCDEF";
            }
            return address;
        }

        //Return a sequence of Data aas the customer may have more than 1 address
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                //Temporary hard coded values to return a set of addresses for a customer
                AddressType = 1,
                StreetLine1 = "Durham Road",
                City = "Loughborough",
                State = "Lesicestershire",
                Country = "UK",
                PostalCode = "ABCDEF"
            };
            addressList.Add(address);

            //Second Address
            address = new Address(2)
            {
                //Temporary hard coded values to return a set of addresses for a customer
                AddressType = 2,
                StreetLine1 = "Rendell Streeet",
                City = "Loughborough",
                State = "Leicestershire",
                Country = "UK",
                PostalCode = "ABBCCD"
            };
            addressList.Add(address);

            return addressList;
        }

        //Method to return current address
        public bool Save(Address address)
        {
            return true;
        }
    }
}
