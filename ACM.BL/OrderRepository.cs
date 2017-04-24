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
        public bool Save()
        {
            return true;
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
