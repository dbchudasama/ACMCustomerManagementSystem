using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address 
    {
		/*
        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        //Addres constructor
        public Address()
        {

        }

        //Address constructor overload
        public Address(int addressId)
        {
            this.AddressId = addressId;
        }

        public override bool Validate()
        {
            //Simple Test to to validate address. Here the post code is needed for the address otherwise will fail the check. 
            return (string.IsNullOrEmpty(PostalCode)) ? false : true;
        }

        //Return a sequence of Data as the customer may have more than 1 address.
        public List<Address> CreateAddress(Address a)
        {
            return new List<Address>() {new Address()
                                            {
                                                //Temporary hard coded values to return a set of addresses for a customer
                                                AddressType = 1,
                                                StreetLine1 = "Durham Road",
                                                City = "Loughborough",
                                                State = "Lesicestershire",
                                                Country = "UK",
                                                PostalCode = "ABCDEF",
                                            },

                                            new Address()

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
		*/
    }
}
