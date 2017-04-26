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
        public void Save(Product p)
        {
            p.Save(); //Invoking the Save method on Product
        }

        //Method to retrieve A SPECIFIC product - Using the productId as a parameter
        public Product LoadProduct(int productId)
        {
            //Create the instance of the product class. Pass in the requested Id.
            Product product = new Product(productId);

            //Temporary hard coded values to return a product
            if (productId == 2)
            {
                //Building product
                product.ProductName = "Snapback";
                product.ProductDescription = "DC Batman Snapback Cap. Black and Grey.";
                product.CurrentPrice = 40;
            }
            return product;
        }

        //Load ALL Products
        //Return a list of all Products
        public static List<Product> LoadAllProducts()
        {
            return new List<Product>();
        }

        //Load a selected number of products 
        public static List<Product> LoadManyProducts(string filter)
        {
            return new List<Product>();
        }
    }
}
