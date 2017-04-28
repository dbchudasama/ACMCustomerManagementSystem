using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;

namespace ACMTestHarness
{
	static class Program
	{

		public static void Run(ACM.BL.Prototype.RepositoryBase ctx)
		{

			Customer c1 = new Customer();

			String a, b, c, d, e;

			Console.WriteLine("Please Enter the Customer's First Name:");
			a = Console.ReadLine();
			c1.FirstName = a;

			Console.WriteLine("Please Enter the Customer's Last Name:");
			b = Console.ReadLine();
			c1.LastName = b;

			Console.WriteLine("Please Enter the Customer Type - 1 = Standard, 2 = Business, 3 = Premium:");
			c = Console.ReadLine();
			//Need to convert input value to 'int'
			//c1.CustomerType =;

			Console.WriteLine("Please Enter the Customer's Email Address:");
			d = Console.ReadLine();

			
			//Console.WriteLine("Thank you" + );





		}
		static void Main(string[] args)
		{
			//Single Entity Entry ONLY 

			/*
			//Create new Customer Entity Object (disconnected mode)
			var c = new Customer();

			var a = new List<Address>()
							{new Address()
								{
									AddressType = 1,
									StreetLine1 = "24 Durham Road",
									City = "Loughborough",
									PostalCode = "ABC ABC",
									State = "Leicestershire",
									Country = "UK"
								}
							};
			
			//Set the Customer Object attributes
			c.CustomerType = 1;
			c.FirstName = "Bhavini";
			c.LastName = "Chudasama";
			c.EmailAddress = "bhavini@me.com";
			c.AddressList = a;
			*/

			var c = new Product();

			c.ProductName = "MacBook Pro";
			c.ProductId= 1;
			c.ProductDescription = "i7, 8GB RAM, 500GB, 2011";
			c.CurrentPrice = 1400;

			//Creating DBContext object
			using (var dbCtx = new ACMDBEntities())
			{
				//Add Customer object into Customers DBSet
				dbCtx.Products.Add(c);

				//Call SaveChanges method to save customer into database
				dbCtx.SaveChanges();
			}
			//As soon as we end the using statement implicitly the Dispose method (as part of the DataEntity object) is called and this closes
			//the connection to the database for security
		}
	}
}
