using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.Prototype
{
	public class Customer : RepositoryBase, IRepository
	{
		
		public int CustomerId { get; set; }

		//Customer type variable
		public string CustomerType { get; set; }

		//Last Name property
		public string LastName { get; set; }

		//First Name property
		public string FirstName { get; set; }

		//Email address property
		public string EmailAddress { get; set; }

		//Fullname of customer. No setter only a getter as nothing should be able to change the value of this property
		public string FullName { get; private set; }

		public void Add()
		{
			//Logic in here to add a record to database

			//Calls RepositoryBase Add method, this way the correct type is passed in
			base.AddBase(this);
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
			base.SaveBase(this);
		}

		public void Validate()
		{
			base.ValidateBase(this);
		}

		public string GenerateFullName(string firstName, string lastName)
		{
			//Adding in logic to test for whether ',' is needed if first or last name is empty (For automated testing code to pass)
			string fullname = firstName;
			//If the last name is populated
			if (!string.IsNullOrWhiteSpace(lastName))
			{
				//If the first name is populated
				if (!string.IsNullOrWhiteSpace(fullname))
				{
					//Add a comma after it
					fullname += ", ";
				}
				//Now add the Last name
				fullname += lastName;
			}

			//Return the fullname - First Name + Last Name
			return fullname;
		}
	}
}
