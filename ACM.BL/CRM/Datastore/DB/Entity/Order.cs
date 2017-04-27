using ACM.BL.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : IEntity
    {
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        //Nullable value type. Using DateTimeOffset as this is very useful in calculating offsets for different time zones for different countries. Can get the time in local time.
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> orderItems { get; set; }

        
        //Method 'Validate' to validate the order data. Overidding from base class
        public  bool Validate()
        {
            return (OrderDate == null) ? false : true;
        }
    }
}
