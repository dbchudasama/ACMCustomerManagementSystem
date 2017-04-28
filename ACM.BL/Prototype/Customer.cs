using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Prototype
{
	public class Customer : RepositoryBase, IRepository
	{
		public int CustomerId { get; set; }

		//Customer type variable
		public int CustomerType { get; set; }

		//Last Name property
		public string LastName { get; set; }

		//First Name property
		public string FirstName { get; set; }

		//Email address property
		public string EmailAddress { get; set; }

		//Fullname of customer. No setter only a getter as nothing should be able to change the value of this property
		public string FullName { get; private set; }

		Customer c = new Customer();
		

		public void Add()
		{
			//Logic in here to add a record to database

			//Calls RepositoryBase Add method, this way the correct type is passed in
			base.AddBase(c);
		}

		public void GetAll()
		{
			base.GetAllBase();
		}

		public void Get()
		{
			base.GetBase(CustomerId);
		}

		public void Remove()
		{
			base.RemoveBase(CustomerId);
		}

		public void Save()
		{
			base.SaveBase(c);
		}

		public void Validate()
		{
			base.ValidateBase(c);
		}

		private string GenerateFullName()
		{
			//Adding in logic to test for whether ',' is needed if first or last name is empty (For automated testing code to pass)
			string fullname = FirstName;
			//If the last name is populated
			if (!string.IsNullOrWhiteSpace(LastName))
			{
				//If the first name is populated
				if (!string.IsNullOrWhiteSpace(fullname))
				{
					//Add a comma after it
					fullname += ", ";
				}
				//Now add the Last name
				fullname += LastName;
			}

			//Return the fullname - First Name + Last Name
			return fullname;
		}
	}
}
