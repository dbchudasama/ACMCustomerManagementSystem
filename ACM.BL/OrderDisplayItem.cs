using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    //This class only has the properties required to display the order items on the order
    public class OrderDisplayItem
    {
        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public string ProductName { get; set; }
        //Nullable value type
        public decimal? PurchasePrice { get; set; }
    }
}
