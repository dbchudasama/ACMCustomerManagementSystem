﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderDisplay
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> orderDisplayItemList { get; set; }
        public int OrderId { get; set; }
        public Address ShippingAddress { get; set; }
    }
}
