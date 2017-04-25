using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address : EntityBase
    {
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
    }
}
