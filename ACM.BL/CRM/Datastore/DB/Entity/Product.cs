using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase //Inheritance
    {
        //Nullable value type. 
        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

        //Method 'Validate' to validate the product data. Overidding method from base class
        public override bool Validate()
        {
            return (string.IsNullOrWhiteSpace(ProductName) || string.IsNullOrWhiteSpace(ProductName)) ? false : true;
        }

        
    }
}
