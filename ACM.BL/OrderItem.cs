using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        //Constructor
        public OrderItem()
        {

        }

        //Constructor overload for orderItem
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        //Nullable value type
        public decimal? PurchasePrice { get; set; }

        //Method 'Save' to save the order item
        public bool Save()
        {
            return true;
        }

        //Method to retrieve A SPECIFIC Order Item - Using the orderItemId as a parameter
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        //Method 'Validate' to validate the order data
        public bool Validate()
        {
            var isValid = true;

            //If the order quantity is less than 0 then validation will fail
            if (OrderQuantity <= 0) isValid = false;
            //If the product ID is less than 0 then validation will fail
            if (ProductId <= 0) isValid = false;
            //If the purchase price is null or empty then validation will fail
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
