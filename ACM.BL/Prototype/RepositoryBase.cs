using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Prototype
{
	//Needs to be a generic class that can take argument of type 'anything'. DBContext code needs to go in here.
	public class RepositoryBase : DbContext, IRepositoryBase<Customer>
	{
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Product> Products { get; set; }

		//Passing in class name into base constructor
		public RepositoryBase()
			: base("name=ACMTest")
		{

		}

		public void AddBase(Customer c)
		{
			if (c == null)
				return;

			using (var ctx = new RepositoryBase())
			{
				//Add Customer object into Customers DBSet
				ctx.Customers.Add(c);

				//Call SaveChanges method to save customer into database
				ctx.SaveChanges();
			}

		}

		public IList<Customer> GetAllBase()
		{
			throw new NotImplementedException();
		}

		public Customer GetBase(int id)
		{
			using (var ctx = new RepositoryBase())
			{
				return ctx.Customers.Where(cus => cus.CustomerId == id).FirstOrDefault<Customer>();
			}
		}

		public void RemoveBase(int id)
		{
			using (var ctx = new RepositoryBase())
			{
				var cusToRemove = ctx.Customers.FirstOrDefault(cus => cus.CustomerId == id);

				if (cusToRemove != null)
				{
					ctx.Customers.Remove(cusToRemove);
					ctx.SaveChanges();
				}
			}
		}


		//Naming convention here isn't the best but this method is for saving changes for edits and updates
		public void SaveBase(Customer c)
		{
			throw new NotImplementedException();
		}

		public void ValidateBase(Customer c)
		{
			throw new NotImplementedException();
		}
	}
}
