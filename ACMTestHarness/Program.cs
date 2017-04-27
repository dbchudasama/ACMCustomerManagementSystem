using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;

namespace ACMTestHarness
{
	class Program
	{
		static void Main(string[] args)
		{
			//Create new Customer Entity Object (disconnected mode)
			var c = new Customer();

			var a = new List<Address>()
							{new Address()
								{
									AddressType = 1,
									StreetLine1 = "12 ABC Steet",
									City = "Nottingham",
									PostalCode = "NG1 ABC",
									State = "Nottinghamshire",
									Country = "UK"
								}
							};
			
			//Set the Customer Object attributes
			c.CustomerType = 1;
			c.FirstName = "Divyesh";
			c.LastName = "Holliday";
			c.EmailAddress = "david@me.com";
			c.AddressList = a;

			//Creating DBContext object
			using (var dbCtx = new ACMDBEntities())
			{
				//Add Customer object into Customers DBSet
				dbCtx.Customers.Add(c);

				//Call SaveChanges method to save customer into database
				dbCtx.SaveChanges();
			}
		}
	}
}
