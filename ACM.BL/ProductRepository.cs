using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        //Method 'Save' to save the defined product
        public bool Save()
        {
            return true;
        }

        //Method to retrieve A SPECIFIC product - Using the productId as a parameter
        public Product Retrieve(int productId)
        {
            //Create the instance of the product class. Pass in the requested Id.
            Product product = new Product(productId);

            //Temporary hard coded values to return a product
            if (productId == 2)
            {
                //Building customer
                product.ProductName = "Snapback";
                product.ProductDescription = "DC Batman Snapback Cap. Black and Grey.";
                product.CurrentPrice = 40;
            }
            return product;
        }

        //Second Retrieve Method that returns a LIST of products
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }
    }
}
