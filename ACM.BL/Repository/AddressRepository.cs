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

        //Method to Create Address
        public void CreateAddress(Address a)
        {
            var a2 = new Address();
            a2.CreateAddress(a); //Invoking the Create Address method
        }

        //Load Address Method
        public Address LoadCustomerAddress(Address a)
        {
            return a;
        }

        //Load ALL Addresses
        //Return a list of all Addresses
        public static List<Address> LoadAllAddresses()
        {
            return new List<Address>();
        }

        //Load a selected number of addresses 
        public static List<Address> LoadManyAddresses(string filter)
        {
            return new List<Address>();
        }
    }
}
