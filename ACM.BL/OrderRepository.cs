using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        //Method 'Save' to save the order
        public bool Save(Order order)
        {
            var success = true;

            //If the order has not changed and is not valid then it won't save
            if (order.HasChanges && order.IsValid)
            {
                if (order.IsNew)
                {
                    //Call an Insert Stored Procedure
                }
                else
                {
                    //Call an Update Stored Procedure
                }
            }
            return success;
        }

        //Method to retrieve the defined order
        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            //Temp hard coded data
            if (orderId == 10)
            {
                orderDisplay.FirstName = "Divyesh";
                orderDisplay.LastName = "Chudasama";
                orderDisplay.OrderDate = new DateTimeOffset(2017, 4, 25, 10, 00, 00, new TimeSpan(2,0,0));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Durham Road",
                    City = "Loughborough",
                    State = "Lesicestershire",
                    Country = "UK",
                    PostalCode = "ABCDEF"
                };
            }
            
            //Creating an instance of the order display item list
            orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();

            //Temp hard coded data
            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    //Building product
                    ProductName = "Snapback",
                    OrderQuantity = 1,
                    PurchasePrice = 40
                };
                //Adding these order details to the order list
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Raspberry Pi",
                    PurchasePrice = 30,
                    OrderQuantity = 1
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
            }

            return orderDisplay;
        }

        //Method to retrieve A SPECIFIC Order - Using the orderId as a parameter
        public Order Retrieve(int orderId)
        {
            //Creating the new instance of the Order class. Pass in requested Id.
            Order order = new Order(orderId);

            //Temporary hard coded values to return a populated order
            if (orderId == 10)
            {
                //Defining new DateTime
                var utcDateTime = new DateTime(2017, 04, 24, 15, 25, 0, DateTimeKind.Local);
                //Setting the offset for the order date
                order.OrderDate = new DateTimeOffset(utcDateTime,TimeSpan.FromHours(2));
            }
            return order;
        }

    }
}
