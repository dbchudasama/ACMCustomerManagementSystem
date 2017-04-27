using ACM.BL.DB.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    [Table("Address")]
    public class Address : IEntity
    {
        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public int CustomerId { get; set; }

        public override bool Equals(Object obj)
        {
           var objAsAddr = (Address)obj;
            return objAsAddr.AddressType == this.AddressType &&
                 objAsAddr.Street == this.Street &&
                 objAsAddr.City == this.City &&
                 objAsAddr.State == this.State &&
                 objAsAddr.PostCode == this.PostCode &&
                 objAsAddr.Country == this.Country;
        }

        public bool Validate()
        {
            //Simple Test to to validate address. Here the post code is needed for the address otherwise will fail the check. 
            return (string.IsNullOrEmpty(PostCode)) ? false : true;
        }

  

    }
}
