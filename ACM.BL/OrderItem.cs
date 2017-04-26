using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem : EntityBase
    {
        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        //Nullable value type
        public decimal? PurchasePrice { get; set; }

        //Constructor overload for orderItem
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        //Method 'Save' to save the order item
        public void Save(OrderItem o)
        {
            o.Save(); //Invoking Save method from Base Class
        }

        //Method to retrieve A SPECIFIC Order Item - Using the orderItemId as a parameter
        public OrderItem LoadOrderItem(int orderItemId)
        {
            return this;
        }

        //Method 'Validate' to validate the order data. Overiding from baase class
        public override bool Validate()
        {
            //If the order quantity is less than 0 then validation will fail
            //If the product ID is less than 0 then validation will fail
            //If the purchase price is null or empty then validation will fail
            return (OrderQuantity <= 0 || ProductId <= 0 || PurchasePrice == null) ? false : true;
        }
    }
}
