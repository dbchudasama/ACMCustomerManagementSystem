using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	/*
    public class Product
    {
        //Nullable value type. 
        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

        //Constructor for Product Class
        public Product()
        {

        }

        //Constructor overload for Product
        public Product(int productId)
        {
            //'this' refers to the current instance of the product object being used
            this.ProductId = productId;
        }

        //Method 'Validate' to validate the product data. Overidding method from base class
        public override bool Validate()
        {
            var isValid = true;

            //If prodcut name is blank or empty then validation will fail
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            //If the current price is empty
            if (CurrentPrice == null) isValid = false;
            
            return isValid;
        } 
    }
	*/
}
