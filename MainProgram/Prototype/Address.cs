using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.Prototype
{
	/*
	public class Address : RepositoryBase, IRepository
	{
		public int AddressId { get; private set; }
		public int AddressType { get; set; }
		public string StreetLine1 { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }

		public List<Address> CreateAddress(Address a)
		{
			return new List<Address>() {new Address()
											{
                                                //Temporary hard coded values to return a set of addresses for a customer
                                                AddressType = 1,
												StreetLine1 = "Durham Road",
												City = "Loughborough",
												State = "Lesicestershire",
												Country = "UK",
												PostalCode = "ABCDEF",
											},

											new Address()

											{

                                                //Temporary hard coded values to return a set of addresses for a customer
                                                AddressType = 2,
												StreetLine1 = "Rendell Streeet",
												City = "Loughborough",
												State = "Leicestershire",
												Country = "UK",
												PostalCode = "ABBCCD"
											}

										};
		}

		Address c = new Address();
		Address d = new Address();

		public void Add()
		{
			c.CreateAddress(d);
			base.AddBase(c);
		}

		public void Get()
		{
			base.GetBase(AddressId);
		}

		public void GetAll()
		{
			base.GetAllBase();
		}

		public void Remove()
		{
			base.RemoveBase(AddressId);
		}

		public void Save()
		{
			base.SaveBase(c);
		}

		public void Validate()
		{
			base.ValidateBase(c);
		}
	}
	*/
}
