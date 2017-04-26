using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order : EntityBase
    {
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        //Nullable value type. Using DateTimeOffset as this is very useful in calculating offsets for different time zones for different countries. Can get the time in local time.
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> orderItems { get; set; }

        //Construct overload for Order 
        public Order(int orderId)
        {
            //'this' refers to the current instance of the order object being used
            this.OrderId = orderId;
        }

        //Method 'Validate' to validate the order data. Overidding from base class
        public override bool Validate()
        {
            var isValid = true;

            //If the order date is blank or empty then validation will fail
            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
